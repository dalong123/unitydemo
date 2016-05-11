Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim exist As Boolean = resource.Exists("http://myserver/dav/MyFolder")

            If (exist) Then
                Console.WriteLine("Folder exists")
            Else
                Console.WriteLine("Folder does not exist")
            End If

            Console.Read()
        End Sub
    End Class
End Namespace

