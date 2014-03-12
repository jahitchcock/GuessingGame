Option Explicit On
Option Strict On

Public Class frmMain
    Dim rndm As New Random
    Dim dblNumber As Double
    Dim dblCount As Double = 0

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Dim dblGuess As Double = (Val(txtGuess.Text))
        Call guess(dblGuess, dblNumber)
        dblCount = Heckle(dblCount)
        txtGuess.Text = ""
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dblNumber = rndm.Next(1, 100)

    End Sub

    Private Sub btnGiveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiveUp.Click
        MessageBox.Show("The number was " & dblNumber & " you gave up after " & dblCount & " guesses!", "I Win, You Lose!", MessageBoxButtons.OK)
        dblNumber = rndm.Next(1, 100)
        dblCount = 0
        txtGuess.Text = " "
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MessageBox.Show("Giving up already", "Quit?", MessageBoxButtons.OK)
        Me.Close()
    End Sub
    Public Function Heckle(ByVal dblCount As Double) As Double
        Select Case dblCount
            Case Is = 4
                MessageBox.Show("You guessed five times already!", "Ha Ha Ha Ha Ha", MessageBoxButtons.OK)
            Case Is = 9
                MessageBox.Show("10 Guesses!! How pathetic!!", "Loser!", MessageBoxButtons.OK)
            Case Is = 14
                MessageBox.Show("That is just sad, 15 guesses!", "Face Palm", MessageBoxButtons.OK)
            Case Is = 19
                MessageBox.Show("You are either really determined or just stupid!", "20 Guesses", MessageBoxButtons.OK)
            Case Is = 29
                MessageBox.Show("Yeah, stupid it is!!!", "30 Guesses!", MessageBoxButtons.OK)
        End Select
        Return (dblCount + 1)
    End Function
    Public Sub guess(ByVal dblGuess As Double, ByVal dblNumber As Double)
        Select Case dblGuess
            Case Is = dblNumber
                MessageBox.Show("Hey you're not as dumb as you look!", "Winner! " & dblCount & " guesses!", MessageBoxButtons.OK)

            Case Is > dblNumber
                MessageBox.Show("Hey bozo, your guess is too high!", "Too High!", MessageBoxButtons.OK)
            Case Is < dblNumber
                MessageBox.Show("What is wrong with you? Guess higher next time!", "Too Low", MessageBoxButtons.OK)
        End Select
    End Sub
End Class
