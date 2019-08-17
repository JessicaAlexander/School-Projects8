'Name: Serenity Photos
'Purpose: Keep track of checks
'Programmer: <Jessica Alexander> on <01/16/2019>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Dim CheckFile As String = "Check.txt"
    Dim Saved As Boolean = False


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If IO.File.Exists("Check.txt") Then
            Dim checksLines() As String = IO.File.ReadAllLines(CheckFile)
            lstCheck.Items.AddRange(checksLines)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outCheck As IO.StreamWriter
        Saved = True
        outCheck = IO.File.AppendText("lstCheck")
        For i As Integer = 0 To lstCheck.Items.Count - 1
            outCheck.WriteLine(lstCheck.Items(i))
        Next i
        outCheck.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult
        If Not Saved Then
            result = MessageBox.Show("File not saved! Continue with saving?", "Files Not Saved!!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                SaveToolStripMenuItem.PerformClick()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub BtnSavee_Click(sender As Object, e As EventArgs) Handles BtnSavee.Click
        Dim amount As Double
        Dim strCheck As String


        Double.TryParse(txtCheckamount.Text, amount)
        If amount > 0 Then
            MessageBox.Show(amount.ToString("C2"))
        Else
            MessageBox.Show("Text could not be converted to a double!")
        End If

        Dim chk As New Checks(txtChecknumber.Text, txtCheckdate.Text, amount, txtPayableto.Text)

        chk.SaveCheck(txtChecknumber.Text, txtCheckdate.Text, amount, txtPayableto.Text)

        strCheck = txtChecknumber.Text & ", " & txtCheckdate.Text & ", " & amount.ToString("n2") & ", " & txtPayableto.Text
        txtChecknumber.Clear()
        txtCheckamount.Clear()
        txtCheckdate.Clear()
        txtPayableto.Clear()

    End Sub

    Private Sub btnexitt_Click(sender As Object, e As EventArgs) Handles btnexitt.Click, BtnExit.Click

        Me.Close()
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim amount As Double
        Dim strCheck As String


        Double.TryParse(txtCheckamount.Text, amount)
        If amount > 0 Then
            MessageBox.Show(amount.ToString("C2"))
        Else
            MessageBox.Show("Text could not be converted to a double!")
        End If

        Dim chk As New Checks(txtChecknumber.Text, txtCheckdate.Text, amount, txtPayableto.Text)

        chk.SaveCheck(txtChecknumber.Text, txtCheckdate.Text, amount, txtPayableto.Text)

        strCheck = txtChecknumber.Text & ", " & txtCheckdate.Text & ", " & amount.ToString("n2") & ", " & txtPayableto.Text
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim aCheck As New Checks()
        Dim bCheck As New Checks("123", "01-16-2019", 123.45, "Jessica Alexander")
    End Sub

    Private Sub txtCheckNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChecknumber.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCheckAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheckamount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class