Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            'Set property
            Dim myProperty As Independentsoft.Webdav.Property = New Independentsoft.Webdav.Property("myproperty", "independentsoft:", "1.0")
            resource.SetProperty("http://myserver/dav/file1.dat", myProperty)

            'Set array of properties
            Dim propertyArray() As Independentsoft.Webdav.Property = New Independentsoft.Webdav.Property(4) {}
            propertyArray(0) = New Independentsoft.Webdav.Property("property1", "myNamespace:", "value1")
            propertyArray(1) = New Independentsoft.Webdav.Property("property2", "myNamespace:", "value2")
            propertyArray(2) = New Independentsoft.Webdav.Property("property3", "myNamespace:", "value3")
            propertyArray(3) = New Independentsoft.Webdav.Property("property4", "myNamespace:", "value4")
            propertyArray(4) = New Independentsoft.Webdav.Property("property5", "myNamespace:", "value5")

            resource.SetProperty("http://myserver/dav/file1.dat", propertyArray)
        End Sub
    End Class
End Namespace

