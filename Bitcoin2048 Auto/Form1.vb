Public Class Form1

    Dim a As String = "1"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' wb.Navigate("http://bitcoin2048.com/")
        '  System.Windows.Forms.SendKeys.SendWait("{ENTER}")
        '  SendKeys.Send("{ENTER}")
        '  SendKeys.Send("{LEFT}")
        '  SendKeys.Send("{ENTER}")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If a = "1" Then
                SendKeys.Send("{UP}")
                a = a + 1
            ElseIf a = "2" Then
                SendKeys.Send("{LEFT}")
                a = a + 1
            ElseIf a = "3" Then
                SendKeys.Send("{DOWN}")
                a = a + 1
            ElseIf a = "4" Then
                SendKeys.Send("{RIGHT}")
                a = "1"
            End If
            '  Label2.Text = Label2.Text + 1
        Catch

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = TextBox1.Text

        Timer1.Start()
        Timer3.Start()
        Timer4.Start()
        If TextBox2.Text = "max" Then
            Timer2.Stop()

        Else
            Timer2.Start()
            Timer2.Interval = TextBox2.Text
        End If
        Button2.Enabled = True

        Button1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'wb.Document.GetElementById("retry-button").InvokeMember("Click")
        '   wb.Document.GetElementById("keep-playing-button").InvokeMember("Click")
        '  wb.Document.GetElementById("continue-button").InvokeMember("Click")
        SendKeys.Send("{ENTER}")
        SendKeys.Send("{F5}")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Button1.Enabled = True
        Button2.Enabled = False

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Timer1.Start()
            Timer2.Start()

        End If
        If e.KeyCode = Keys.F2 Then
            Timer1.Stop()
            Timer2.Stop()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer1.Interval = "300"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer1.Interval = TextBox1.Text
    End Sub
End Class
