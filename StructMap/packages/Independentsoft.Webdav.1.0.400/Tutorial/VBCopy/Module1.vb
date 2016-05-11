Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            'Copy file
            resource.Copy("http://myserver/dav/file1.dat", "http://myserver/dav/backup/file1.dat")

            'Copy folder and all subfolders
            resource.Copy("http://myserver/dav/MyFolder", "http://myserver/dav/backup/MyFolder", True, True)
        End Sub
    End Class
End Namespace

