Public Class Form1


    'Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    'End Sub

    'Private Sub WebBrowser2_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

    'End Sub

    'Private Sub WebBrowser3_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted

    'End Sub

    'Private Sub WebBrowser4_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser4.DocumentCompleted

    'End Sub

    'Private Sub WebBrowser5_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser5.DocumentCompleted

    'End Sub

    'Private Sub WebBrowser6_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser6.DocumentCompleted

    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        pt1.Navigate("https://assess.joincyberdiscovery.com/challenge-files/clock-pt1?verify=yuxGN7k6RzMtoatsmmXt%2Fw%3D%3D")
        pt1.Refresh()
        pt2.Refresh()
        p3.Refresh()
        p4.Refresh()
        p5.Refresh()
        validate.Navigate("https://assess.joincyberdiscovery.com/challenge-files/get-flag?verify=yuxGN7k6RzMtoatsmmXt%2Fw%3D%3D&string=<clock pts>")








    End Sub
End Class
