Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim properties() As Independentsoft.Webdav.Property = resource.GetProperties("http://myserver/dav/file1.dat")

            Dim i As Integer
            For i = 0 To properties.Length - 1
                Console.WriteLine(properties(i).Name)
                Console.WriteLine(properties(i).Namespace)
                Console.WriteLine(properties(i).Value)
                Console.WriteLine("-------------------------------------------------------------")
            Next

            Console.Read()
        End Sub
    End Class
End Namespace

