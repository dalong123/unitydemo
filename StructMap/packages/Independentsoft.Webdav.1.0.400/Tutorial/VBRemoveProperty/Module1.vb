Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim myPropertyName As PropertyName = New PropertyName("myproperty", "independentsoft:")
            resource.RemoveProperty("http://myserver/dav/file1.dat", myPropertyName)
        End Sub
    End Class
End Namespace

