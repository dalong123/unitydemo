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

            AddHandler resource.DownloadProgress, AddressOf OnDownloadProgress

            Try

                Dim download As FileDownload = resource.DownloadFile("http://myserver/dav/file1.txt", "c:\\file1.txt")

                'Press ENTER to abort download
                Console.Read()
                download.Abort()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.Read()
            End Try

            'Wait till download is finished and press ENTER to exit.
            Console.Read()
        End Sub

        Private Shared Sub OnDownloadProgress(ByVal sender As Object, ByVal e As ProgressEventArgs)

            If (e.Exception IsNot Nothing) Then
                Console.WriteLine(e.Exception.Message)
                Console.Read()
            ElseIf (e.IsComplete) Then
                Console.WriteLine("Download completed")
            Else
                Console.WriteLine(e.Progress)
            End If
        End Sub

    End Class
End Namespace

