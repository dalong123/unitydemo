Imports System
Imports System.Net
Imports Independentsoft.Webdav

Module Module1
    Sub Main(ByVal args() As String)

        Dim credential As NetworkCredential = New NetworkCredential("username", "password")
        Dim session As WebdavSession = New WebdavSession(credential)
        Dim resource As Resource = New Resource(session)

        resource.Download("http://myserver/dav/file1.txt", "c:\\file1.txt")

    End Sub
End Module

