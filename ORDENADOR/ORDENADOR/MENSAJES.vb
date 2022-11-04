Public Class MENSAJES

    Private Sub MENSAJES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.TopMost = True
        TextBoxMENSAJES.ReadOnly = True
        Label1.Focus()
    End Sub

    Private Sub TextBoxMENSAJES_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMENSAJES.TextChanged

    End Sub
End Class