Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim xml As String = "<i:Software xmlns:i=""independentsoft:""><i:Name>WebDAV .NET</i:Name>" & _
            "<i:Version>1.0</i:Version><i:Date>01.01.2005</i:Date></i:Software>"

            Dim myProperty As Independentsoft.Webdav.Property = New Independentsoft.Webdav.Property(xml)
            resource.SetProperty("http://myserver/dav/file1.dat", myProperty)
        End Sub
    End Class
End Namespace

