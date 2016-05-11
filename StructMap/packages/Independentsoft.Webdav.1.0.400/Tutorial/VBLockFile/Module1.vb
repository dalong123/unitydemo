Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            'Lock file for 10 minutes
            Dim fileLock As ActiveLock = resource.Lock("http://myserver:8080/dav/file1.dat", Depth.Zero, 600)

            'Unlock file
            resource.Unlock("http://myserver:8080/dav/file1.dat", fileLock)
        End Sub
    End Class
End Namespace

