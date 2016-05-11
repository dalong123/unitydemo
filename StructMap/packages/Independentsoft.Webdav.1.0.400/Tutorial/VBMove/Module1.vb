Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            'Rename file
            resource.Move("http://myserver/dav/file1.dat", "http://myserver/dav/file2.dat")

            'Move folder and all subfolders
            resource.Move("http://myserver/dav/MyFolder", "http://myserver/dav/backup/MyFolder")
        End Sub
    End Class
End Namespace

