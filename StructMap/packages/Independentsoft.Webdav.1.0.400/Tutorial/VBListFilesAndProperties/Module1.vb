Imports System
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Program
        Shared Sub Main(ByVal args As String())

            Dim credential As New NetworkCredential("username", "password")
            Dim session As New WebdavSession(credential)
            Dim resource As New Resource(session)

            Dim propertyName As PropertyName() = New PropertyName(4) {}

            propertyName(0) = DavProperty.DisplayName
            propertyName(1) = DavProperty.CreationDate
            propertyName(2) = DavProperty.GetLastModified
            propertyName(3) = DavProperty.GetContentLength
            propertyName(4) = DavProperty.IsCollection

            Dim info As ResourceInfo() = resource.List("http://myserver/dav", propertyName)

            For i As Integer = 0 To info.Length - 1
                Dim displayName As [Property] = info(i).Properties(DavProperty.DisplayName)
                Dim creationDate As [Property] = info(i).Properties(DavProperty.CreationDate)
                Dim getLastModified As [Property] = info(i).Properties(DavProperty.GetLastModified)
                Dim getContentLength As [Property] = info(i).Properties(DavProperty.GetContentLength)
                Dim isCollection As [Property] = info(i).Properties(DavProperty.IsCollection)

                Console.WriteLine(info(i).Address)

                If displayName IsNot Nothing Then
                    Console.WriteLine(displayName.Value)
                End If

                If creationDate IsNot Nothing Then
                    Console.WriteLine(creationDate.Value)
                End If

                If getLastModified IsNot Nothing Then
                    Console.WriteLine(getLastModified.Value)
                End If

                If getContentLength IsNot Nothing Then
                    Console.WriteLine(getContentLength.Value)
                End If

                If isCollection IsNot Nothing Then
                    Console.WriteLine(isCollection.Value)
                End If

                Console.WriteLine("-------------------------------------------------------------------")
            Next

            'Press ENTER to exit.
            Console.Read()
        End Sub
    End Class
End Namespace
