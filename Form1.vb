Imports System.IO
Public Class Form1


    'Notes TODO
    'Add difficulty (easy, medium, hard, extreme)
    'Read questions from a txt file
    'add new questions and write them to the txt file


    'Read and wright text to question.txt
    'vetores para o texto
    Dim quest(1)
    Dim um(1)
    Dim dois(1)
    Dim tres(1)
    Dim quatro(1)
    Dim correto(1)



    'Global vars
    Dim gameTimer, gamePoints, gameDifficulty
    Dim level

    'tempo maximo de jogo
    Dim totalTime = 100
    'pontos minimos de jogo
    Dim minPoints = -20

    'For the game
    Dim answer, question
    'Dim question = 1





    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        'Start new game
        'start the gamequiz
        'with the 1st question
        question = 1
        startGame()

    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        'Call About Form
        Form2.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        'Exit game
        Close()
    End Sub



    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Exit message
        MessageBox.Show("Thank you for playing!")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Clock count
        gameTimer += 1
        ltTime.Text = "Time: " & gameTimer

        'Add time limit?
        endGame()
    End Sub

    Function gameQuiz(q)
        Select Case q
            Case 1
                lQuestion.Text = "First question is something cool!"
                btAnswer1.Text = "First answer (T)"
                btAnswer2.Text = "Second answer"
                btAnswer3.Text = "Third answer"
                btAnswer4.Text = "Fourth answer"
                answer = 1
            Case 2
                lQuestion.Text = "Second question is something cool!"
                btAnswer1.Text = "First answer"
                btAnswer2.Text = "Second answer(T)"
                btAnswer3.Text = "Third answer"
                btAnswer4.Text = "Fourth answer"
                answer = 2
            Case 3
                lQuestion.Text = "Third question is something cool!"
                btAnswer1.Text = "First answer"
                btAnswer2.Text = "Second answer"
                btAnswer3.Text = "Third answer(T)"
                btAnswer4.Text = "Fourth answer"
                answer = 3
            Case 4
                lQuestion.Text = "Fourth question is something cool!"
                btAnswer1.Text = "First answer"
                btAnswer2.Text = "Second answer"
                btAnswer3.Text = "Third answer"
                btAnswer4.Text = "Fourth answer(T)"
                answer = 4
            Case 5
                lQuestion.Text = "Fifth question is something cool!"
                btAnswer1.Text = "First answer(T)"
                btAnswer2.Text = "Second answer"
                btAnswer3.Text = "Third answer"
                btAnswer4.Text = "Fourth answer"
                answer = 1
            Case 6
                lQuestion.Text = "Sixth question is something cool!"
                btAnswer1.Text = "First answer"
                btAnswer2.Text = "Second answer(T)"
                btAnswer3.Text = "Third answer"
                btAnswer4.Text = "Fourth answer"
                answer = 2
            Case Else
                lQuestion.Visible = False
                btAnswer1.Visible = False
                btAnswer2.Visible = False
                btAnswer3.Visible = False
                btAnswer4.Visible = False
                Me.BackgroundImage = cQuiz.My.Resources.Resources.backwelcome
                'MessageBox.Show("No more questions!")
                Dim msg As Integer = MessageBox.Show("Wanna play again?", "No more questions!", MessageBoxButtons.YesNo)
                If msg = DialogResult.No Then
                    'MessageBox.Show("Thanks for playing!")
                    Me.Close()
                ElseIf msg = DialogResult.Yes Then
                    MessageBox.Show("Good luck again!")
                    startGame()

                End If
        End Select

    End Function

    Function points(n)
        'function gives or takes points
        gamePoints = gamePoints + n
        tlPoints.Text = "Points: " & gamePoints
    End Function

    Function endGame()
        'this will control when the game ends

        'end by time?
        If gameTimer >= totalTime Or gamePoints <= minPoints Then
            Timer1.Stop()
            lQuestion.Visible = False
            btAnswer1.Visible = False
            btAnswer2.Visible = False
            btAnswer3.Visible = False
            btAnswer4.Visible = False
            Me.BackgroundImage = cQuiz.My.Resources.Resources.backgameover
            Dim msg As Integer = MessageBox.Show("Game over, wanna play again?", "Game Over!", MessageBoxButtons.YesNo)
            If msg = DialogResult.No Then
                'MessageBox.Show("Thanks for playing!")
                Me.Close()
            ElseIf msg = DialogResult.Yes Then
                MessageBox.Show("Good luck again!")
                startGame()
            End If
        End If



    End Function

    Function startGame()
        'Start new game

        gameTimer = 0
        'points status
        '10pts for 1 correct, -5pts for 1 rong answer
        gamePoints = 0

        points(0)
        'gameDifficulty = "Easy"
        ltDifficulty.Visible = False 'inactive for now, see TODO list

        'Change background
        Me.BackgroundImage = cQuiz.My.Resources.Resources.back 'game background
        'Me.BackgroundImage = cQuiz.My.Resources.Resources.backgameover 'game over
        'Me.BackgroundImage = cQuiz.My.Resources.Resources.backwelcome 'game start

        'start clock
        Timer1.Start()

        'start the gamequiz
        'with the 1st question
        question = 1
        gameQuiz(question)


        'Turn my objects visible
        lQuestion.Visible = True
        btAnswer1.Visible = True
        btAnswer2.Visible = True
        btAnswer3.Visible = True
        btAnswer4.Visible = True
    End Function

    Private Sub btAnswer1_Click(sender As Object, e As EventArgs) Handles btAnswer1.Click
        If answer = 1 Then
            'correct answer

            'win points
            points(10)

            'go to next question
            question += 1
            gameQuiz(question)


        Else
            'rong question
            points(-5)
        End If
        'go to next question here
        'question += 1
    End Sub

    Private Sub btAnswer2_Click(sender As Object, e As EventArgs) Handles btAnswer2.Click
        If answer = 2 Then
            'correct answer

            'win points
            points(10)

            'go to next question
            question += 1
            gameQuiz(question)


        Else
            'rong question
            points(-5)
        End If
        'go to next question here
        'question += 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        read()
        MessageBox.Show(quest(1))
    End Sub

    Private Sub btAnswer3_Click(sender As Object, e As EventArgs) Handles btAnswer3.Click
        If answer = 3 Then
            'correct answer

            'win points
            points(10)

            'go to next question
            question += 1
            gameQuiz(question)


        Else
            'rong question
            points(-5)
        End If
        'go to next question here
        'question += 1
    End Sub
    Private Sub btAnswer4_Click(sender As Object, e As EventArgs) Handles btAnswer4.Click
        If answer = 4 Then
            'correct answer

            'win points
            points(10)

            'go to next question
            question += 1
            gameQuiz(question)


        Else
            'rong question
            points(-5)
        End If
        'go to next question here
        'question += 1
    End Sub

    Function read()
        'code copied from https://support.microsoft.com/en-us/kb/315828

        Dim objStreamReader As StreamReader
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader("C:\Users\va2015185\Downloads\cQuiz\cQuiz\cQuiz\questions.txt")

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            quest(0) = strLine


            'For i = 0 To quest.Length
            '    quest(i) = strLine
            '    um(i) = strLine
            '    dois(i) = strLine
            '    tres(i) = strLine
            '    quatro(i) = strLine
            '    correto(i) = strLine

            'Next

            'Write the line to the Console window.
            'Console.WriteLine(strLine)
            ' MessageBox.Show(strLine)
            quest(0) = strLine
            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()

        'Console.ReadLine()
        'MessageBox.Show(strLine)
        'MessageBox.Show(quest(0))
    End Function

End Class
