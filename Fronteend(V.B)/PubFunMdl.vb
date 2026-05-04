Imports RestSharp
Imports System.Data
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports ComponentFactory.Krypton.Toolkit

Public Module PubFunMdl
    Dim dt As New System.Data.DataTable
    Public nextProcessdt As New System.Data.DataTable
    Public user_id, request_no As String
    Public codApp, reqno, prjid, indi As String
    Public Modify As Integer = 0
    Public Err, itp, qcp, result, contct, remarks1 As String

    Public Function Select_Data(ByVal arg As String)
        If access_token = "" Then Exit Function
        Dim client = New RestClient(conn & arg)
        client.Timeout = -1
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("Authorization", token_type + " " + access_token)
        request.AddHeader("Content-Type", "application/json")
        Dim response = client.Execute(request)
        Return response.Content
    End Function


End Module
