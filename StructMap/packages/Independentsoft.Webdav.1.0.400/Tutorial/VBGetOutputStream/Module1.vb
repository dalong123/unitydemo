Imports System
Imports System.IO
Imports System.Net
Imports Independentsoft.Webdav

Namespace Sample
    Class Module1
        Shared Sub Main(ByVal args() As String)

            Dim credential As NetworkCredential = New NetworkCredential("username", "password")
            Dim session As WebdavSession = New WebdavSession(credential)
            Dim resource As Resource = New Resource(session)

            Dim output As Stream = resource.GetOutputStream("http://myserver/dav/file1.dat")

            Dim file As FileStream = New FileStream("c:\\file1.dat", FileMode.Open)

            Dim buffer() As Byte = New Byte(2048) {}
            Dim len As Integer = file.Read(buffer, 0, buffer.Length)

            While (len > 0)
                output.Write(buffer, 0, len)
                output.Flush()
                len = file.Read(buffer, 0, buffer.Length)
            End While

            file.Close()
            output.Close()

            'Press ENTER to exit
            Console.Read()
        End Sub
    End Class
End Namespace

