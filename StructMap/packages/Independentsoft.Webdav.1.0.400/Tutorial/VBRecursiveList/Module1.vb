Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim list() As String = resource.List("http://myserver/dav/", True)

            Dim i As Integer
            For i = 0 To list.Length - 1
                Console.WriteLine(list(i))
            Next

            'Press ENTER to exit.
            Console.Read()
        End Sub
    End Class
End Namespace
