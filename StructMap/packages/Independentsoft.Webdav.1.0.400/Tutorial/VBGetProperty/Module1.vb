Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim sizeProperty As Independentsoft.Webdav.Property = resource.GetProperty("http://myserver/dav/file1.dat", DavProperty.GetContentLength)
            Console.WriteLine("File size = " & sizeProperty.Value)

            Dim myPropertyName As PropertyName = New PropertyName("myproperty", "independentsoft:")
            Dim myProperty As Independentsoft.Webdav.Property = resource.GetProperty("http://myserver/dav/file1.dat", myPropertyName)
            Console.WriteLine("My property = " + myProperty.Value)

            'Press ENTER to exit
            Console.Read()
        End Sub
    End Class
End Namespace

