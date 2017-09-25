Public Class Form3
    'morning
    Dim conn As New System.Data.Odbc.OdbcConnection("DRIVER={MySQL ODBC 5.2 ANSI Driver};SERVER=localhost;PORT=3306;DATABASE=prototype nea;USER=root;PASSWORD=root;OPTION=3;")
    Dim rs As Odbc.OdbcDataReader
    Dim ID(100, 3) As String
    Dim Count As Integer


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As New Odbc.OdbcCommand("SELECT QuestionID, Question, Answer FROM questions, topics WHERE questions.TopicID = topics.TopicID AND TopicName = '" & Topic & "' ", conn)
        conn.Open()
        rs = sql.ExecuteReader()
        Count = 1
        Do While rs.Read()
            QuestionID = rs.Item("QuestionID")
            Question = rs.Item("Question")
            Answer = rs.Item("Answer")
            For i = 1 To 99
                If i = QuestionID Then
                    ID(Count, 1) = i
                    ID(Count, 2) = Question
                    ID(Count, 3) = Answer
                    Count += 1
                    QuestionBox.Text = rs.Item("Question")
                    AnswerLabel.Text = rs.Item("Answer")
                End If
            Next
        Loop
        Count -= 1

    End Sub

    Private Sub MarkBtn_Click(sender As Object, e As EventArgs) Handles MarkBtn.Click
        If AnswerBox.Text = AnswerLabel.Text Then
            MarkImage.Image = My.Resources.tick
        ElseIf AnswerBox.Text <> AnswerLabel.Text Then
            MarkImage.Image = My.Resources.cross
            AnswerLabel.Visible = True
        End If
        MarkImage.Visible = True
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Count -= 1
        If Count > 0 Then
            QuestionBox.Text = ID(Count, 2)
            AnswerLabel.Text = ID(Count, 3)
            AnswerLabel.Visible = False
            AnswerBox.Text = ""
            MarkImage.Visible = False
        Else
            AnswerLabel.Visible = False
            AnswerBox.Visible = False
            MarkImage.Visible = False
            Label1.Visible = False
            NextBtn.Visible = False
            MarkBtn.Visible = False
            QuestionBox.Text = "Finished!"
        End If
    End Sub


End Class