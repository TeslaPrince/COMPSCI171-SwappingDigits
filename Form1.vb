Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim input As Integer
        Dim inputMod As Integer
        Dim inputSub As Integer
        Dim inputDiv As Integer
        Dim inputMult As Integer
        Dim inputAdd As Integer
        Dim output As Integer
        input = CInt(txtInput.Text)
        inputMod = input Mod 10
        MessageBox.Show(inputMod)
        inputSub = input - inputMod
        MessageBox.Show(inputSub)
        inputDiv = inputSub \ 10
        MessageBox.Show(inputDiv)
        inputMult = inputMod * 10
        MessageBox.Show(inputMult)
        inputAdd = inputDiv + inputMult
        MessageBox.Show(inputAdd)
        output = inputAdd * 2
        MessageBox.Show(output)
        txtOutput.Text = CStr(output)
    End Sub
End Class
