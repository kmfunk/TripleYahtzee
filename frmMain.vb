Public Class frmMain
    Private roll As Integer = 0
    '
    Dim diceButtons As New List(Of Button)
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click

        ' Initialize the random-number generator.
        Randomize()

        roll += 1
        'MessageBox.Show("diceButtons is " & diceButtons.Count & " item is " & diceButtons.Item(0).ToString)
        For i = 0 To 4
            'MessageBox.Show("Loop " & i)
            If diceButtons(i).Enabled = True Then
                ' diceButtons.Item(i).Enabled = True
                diceButtons.Item(i).Text = Int((5 * Rnd()) + 1)
                diceButtons(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 5
            Dim ctl As Control = Me.Controls.Find("btnDice" & i, True).FirstOrDefault
            If Not IsNothing(ctl) AndAlso TypeOf ctl Is Button Then
                diceButtons.Add(DirectCast(ctl, Button))
            End If
        Next
    End Sub
End Class
