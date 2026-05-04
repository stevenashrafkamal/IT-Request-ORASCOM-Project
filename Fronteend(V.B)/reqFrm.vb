Imports RestSharp
Imports Newtonsoft.Json
Imports System.Data
Imports System.Net.Http


Public Class reqFrm
    Private Sub reqFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' استدعاء API الخاص بالـ ReqType
        Dim client = New RestClient(conn & "/api/Request/GetReqType")
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("Authorization", "Bearer " & access_token)

        Dim response = client.Execute(request)
        Dim reqType = response.Content

        If reqType.StartsWith("{") Then
            MsgBox("Error: " & reqType)
            Exit Sub
        End If

        Dim dtreqType As DataTable = JsonConvert.DeserializeObject(Of DataTable)(reqType)

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("")
        For Each row As DataRow In dtreqType.Rows
            ComboBox1.Items.Add(row("Name").ToString())
        Next
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim mainDepartment = Select_Data("/api/Request/Getreq?cat=" & ComboBox5.Text)
        If mainDepartment = "null" Then Exit Sub

        Dim dtmainDepartment As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(mainDepartment)
        ComboBox6.Items.Clear()
        ComboBox6.Items.Add("")
        For i = 0 To dtmainDepartment.Rows.Count - 1
            ComboBox6.Items.Add(dtmainDepartment.Rows(i)("Name").ToString)
        Next
    End Sub
    ' 🔹 لو اختار "For me"
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Dim client = New RestClient(conn & "/api/Request/GetUsersWithManagers")
            Dim request = New RestRequest(Method.GET)
            request.AddHeader("Authorization", "Bearer " & access_token)

            Dim response = client.Execute(request)
            Dim usersJson = response.Content

            If usersJson.StartsWith("{") Then
                MsgBox("Error: " & usersJson)
                Exit Sub
            End If

            Dim dtUsers As DataTable = JsonConvert.DeserializeObject(Of DataTable)(usersJson)
            ComboBox3.Tag = dtUsers

            Dim rows() As DataRow = dtUsers.Select("Email = '" & userid & "'")

            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()

            If rows.Length > 0 Then
                ComboBox3.Items.Add(rows(0)("Email").ToString())
                ComboBox3.SelectedIndex = 0

                ComboBox4.Items.Add(rows(0)("Maneger").ToString())
                ComboBox4.SelectedIndex = 0
            Else
                MsgBox("User not found in API data.")
            End If
        End If
    End Sub

    ' 🔹 لو اختار "On behalf of"
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dim client = New RestClient(conn & "/api/Request/GetUsersWithManagers")
            Dim request = New RestRequest(Method.GET)
            request.AddHeader("Authorization", "Bearer " & access_token)

            Dim response = client.Execute(request)
            Dim usersJson = response.Content

            If usersJson.StartsWith("{") Then
                MsgBox("Error: " & usersJson)
                Exit Sub
            End If

            Dim dtUsers As DataTable = JsonConvert.DeserializeObject(Of DataTable)(usersJson)

            ComboBox3.Items.Clear()
            For Each row As DataRow In dtUsers.Rows
                ComboBox3.Items.Add(row("Email").ToString())
            Next

            ComboBox3.Tag = dtUsers

            ' 🔹 أول يوزر يتعرض مع المانجر بتاعه على طول
            If ComboBox3.Items.Count > 0 Then
                ComboBox3.SelectedIndex = 0
                ShowManagerForSelectedUser()
            End If
        End If
    End Sub

    ' 🔹 لما يختار يوزر نجيب المانجر بتاعه تلقائي
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ShowManagerForSelectedUser()
    End Sub

    ' 🔹 دالة مشتركة لعرض المانجر
    Private Sub ShowManagerForSelectedUser()
        Dim dtUsers As DataTable = TryCast(ComboBox3.Tag, DataTable)
        If dtUsers Is Nothing Then Exit Sub
        If ComboBox3.SelectedIndex < 0 Then Exit Sub

        Dim email As String = ComboBox3.SelectedItem.ToString()
        Dim rows() As DataRow = dtUsers.Select("Email = '" & email & "'")

        If rows.Length > 0 Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add(rows(0)("Maneger").ToString())
            ComboBox4.SelectedIndex = 0
        End If
    End Sub






    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' اجمع البيانات من الكنترولات
        Dim req As String = ComboBox1.Text ' Req Type
        Dim details As String = ComboBox6.Text ' TextBox بتاع Details
        Dim isPrivate As String = If(CheckBox1.Checked, "Yes", "No") ' Private checkbox
        Dim other As String = TextBox1.Text ' TextBox بتاع Other
        Dim remarks As String = TextBox2.Text ' TextBox بتاع Remarks
        Dim status As String = "New" ' أو أي قيمة افتراضية

        ' أضف صف جديد للـ DataGridView
        DataGridView1.Rows.Add(req, details, isPrivate, other, remarks, status)
    End Sub


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' تصفير الـ ComboBox
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""

        ' تصفير الـ TextBox
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

        ' تصفير الـ RadioButton
        RadioButton1.Checked = True
        RadioButton2.Checked = False

        ' تصفير الـ CheckBox
        CheckBox1.Checked = False

        ' تفريغ الـ DataGridView
        DataGridView1.Rows.Clear()

        ' أول ما الفورم يفتح
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        TextBox3.Enabled = True
        GroupBox1.Enabled = True
        GroupBox3.Enabled = False

    End Sub


    Public Class RequestClass
        Public Property Req As String
        Public Property Details As String

        ' نسميه PrivateRequest في الكود لأن "Private" كلمة محجوزة في VB
        ' لكن نعطيه اسم JSON "Private" لكي يطابق الـ API
        <JsonProperty("Private")>
        Public Property PrivateRequest As Boolean

        <JsonProperty("Other")>
        Public Property Other As String  ' استخدم اسم مختلف لو تحب، مع الـ JsonProperty

        Public Property Remarks As String
        Public Property Status As String
        Public Property Req_type As String
        Public Property Site As String
        Public Property Date_Time As String
        Public Property User_ID As String
    End Class


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then

                ' معالجة قيمة العمود Private
                Dim privateVal As Boolean = False
                If row.Cells(2).Value IsNot Nothing Then
                    Dim cellValue As String = row.Cells(2).Value.ToString().Trim().ToLower()

                    If cellValue = "true" OrElse cellValue = "1" OrElse cellValue = "yes" Then
                        privateVal = True
                    Else
                        privateVal = False
                    End If
                End If

                ' إنشاء الموديل
                Dim model As New RequestClass With {
                    .Req = If(row.Cells(0).Value, "").ToString(),
                    .Details = If(row.Cells(1).Value, "").ToString(),
                    .PrivateRequest = privateVal,
                    .Other = If(row.Cells(3).Value, "").ToString(),
                    .Remarks = If(row.Cells(4).Value, "").ToString(),
                    .Status = If(row.Cells(5).Value, "").ToString(),
                    .Req_type = ComboBox1.Text,
                    .Site = ComboBox2.Text,
                    .Date_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                }

                ' إرسال الريكويست
                Dim client = New RestClient(conn & "/api/Request/AddRequest")
                Dim request = New RestRequest(Method.POST)
                request.AddHeader("Authorization", "Bearer " & access_token)
                request.AddHeader("Content-Type", "application/json")

                Dim body As String = JsonConvert.SerializeObject(model)
                request.AddParameter("application/json", body, ParameterType.RequestBody)

                Dim response = client.Execute(request)

                If Not response.IsSuccessful Then
                    MessageBox.Show("خطأ في حفظ الطلب: " & response.Content)
                End If
            End If
        Next

        MessageBox.Show("Save done")
        NewToolStripMenuItem_Click(Nothing, Nothing)
    End Sub


    Private Sub ReqForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' أول ما الفورم يفتح
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        TextBox3.Enabled = True
        GroupBox1.Enabled = True
        GroupBox3.Enabled = False
        RadioButton1.Checked = True

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        ' لما تدوس على زرار Create
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        TextBox3.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
