Imports Newtonsoft.Json.Linq
Imports RestSharp

Module loginFunction
    Public userid As String
    Public password As String
    Public Function logins()

        Dim client = New RestClient(conn & "/token")
        client.Timeout = -1
        Dim request = New RestRequest(Method.POST)
        request.AddHeader("Content-Type", "text/plain")
        request.AddHeader("Cookie", ".AspNet.Cookies=pMH8tZuHFDwOO3pLq_6LK3UFoUveNRNuAb-oTWwD4kKv3oIDXOxl0CbdGpVPz9cOrKv2c3JduwvC_m54sKqnGjededAho_l1nJtWpKeorvcAd8QzNAbN0efQzMcKslwoMJspVuoR6TFedJ6IRL4onmrLMgM_0nXYvWMsDhevgsCfJeJe1vUlxaqYlWIj-CfUGiBtkJ57M7xvFMKFaU5_H426Np9se2UCqERtdZd4oW1bKYpnaZ9nU_abuhWHNcLwQhQ6l2qVP4efuTd_qhQE35GoDAG2CXB4nwF60GD9TiGz4wMEcg6h8VkdZ2Linu_7aJXRjFWdMUkHBOOU7MAeXaZiIPKC7wiKmUmwq7hUMDVFBjMxVT2vVmlddOGO--mqoZmFY9mo7sWPKwWWi_aPbCzLf3BYHAoq6hBoJs_kA4u37ARJXthUc61aFdc8GcDZTY3VKI8UPkjny0SMr0__PAQ03fsIR5K9Wo-0hSy1GjA")
        Dim body = "username=" & userid & "&password=" & password & "&grant_type=password"
        request.AddParameter("text/plain", body, ParameterType.RequestBody)
        Dim response As IRestResponse = client.Execute(request)
        Try
            Dim rawresp As String = response.Content
            Dim json As JObject = JObject.Parse(rawresp)
            access_token = (json.Item("access_token"))
            expires_in = (json.Item("expires_in"))
            token_type = (json.Item("token_type"))
            scope = (json.Item("scope"))
        Catch ex As Exception
        End Try
        Return access_token
    End Function


    Partial Public Class Sec_Credential
        Public Property ID As Integer
        Public Property ComputerName As String
        Public Property OwnerUser As String
        Public Property GuestUser As String
        Public Property Password As String
        Public Property LastLogin As Nullable(Of System.DateTime)
        Public Property Active As Nullable(Of Boolean)
        Public Property PlatForm As String
        Public Property Rev As String
        Public Property remember As Boolean
    End Class


End Module
