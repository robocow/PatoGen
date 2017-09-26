Public Class frmMain

    Public MAXPIXELS = 50
    Public FIXTURESIZE = 7
    Public RGBFIXTUREOFFSET = 3
    Public MAXFRAMES = 12000                              ' five minutes at 40 frames per second

    Dim output(MAXFRAMES, MAXPIXELS * FIXTURESIZE) As Short       ' output(frame number, channel)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub picGradientColor1_Click(sender As Object, e As EventArgs) Handles picGradientColor1.Click
        If cdPicker.ShowDialog() = DialogResult.OK Then
            Me.picGradientColor1.BackColor = cdPicker.Color
            GradientDisplay()
        End If

    End Sub

    Private Sub picGradientColor2_Click(sender As Object, e As EventArgs) Handles picGradientColor2.Click

        If cdPicker.ShowDialog() = DialogResult.OK Then
            Me.picGradientColor2.BackColor = cdPicker.Color
            GradientDisplay()
        End If

    End Sub

    Public Sub GradientDisplay()

        'gradient display in control's paint handler
        Me.Refresh()

    End Sub


    Private Sub picGradientPreview_Paint(sender As Object, e As PaintEventArgs) Handles picGradientPreview.Paint

        Dim colorA As Color
        Dim colorB As Color

        colorA = Me.picGradientColor1.BackColor
        colorB = Me.picGradientColor2.BackColor
        Dim steps = Me.picGradientPreview.Width



        ' colorB - colorA, care with negative

        Dim redColorDiff, greenColorDiff, blueColorDiff As Integer
        redColorDiff = Int(colorB.R) - Int(colorA.R)
        greenColorDiff = Int(colorB.G) - Int(colorA.G)
        blueColorDiff = Int(colorB.B) - Int(colorA.B)

        Dim redres, grnres, blures As Integer
        Dim colres As Color


        For x = 0 To steps

            redres = Int((redColorDiff / steps) * x) + Int(colorA.R)
            grnres = Int((greenColorDiff / steps) * x) + Int(colorA.G)
            blures = Int((blueColorDiff / steps) * x) + Int(colorA.B)

            colres = Color.FromArgb(255, redres, grnres, blures)

            'draw line 
            Dim pen As New Pen(colres, 1)

            'vertical lines
            Dim y1 As Integer = 0
            Dim y2 As Integer = Me.picGradientPreview.Height

            e.Graphics.DrawLine(pen, x, y1, x, y2)

        Next

        renderGradientFrames(colorA, colorB, 800, 1)


    End Sub

    Private Sub renderGradientFrames(colorA As Color, colorB As Color, steps As Integer, phase As Short)

        If steps < MAXFRAMES Then
            'default is to cycle....
        End If

        Dim redColorDiff, greenColorDiff, blueColorDiff As Integer
        redColorDiff = Int(colorB.R) - Int(colorA.R)
        greenColorDiff = Int(colorB.G) - Int(colorA.G)
        blueColorDiff = Int(colorB.B) - Int(colorA.B)


        Dim redres, grnres, blures As Integer
        Dim fixtureindex As Integer
        Dim phased As Single

        Dim x, y, z As Integer

        For y = 0 To MAXPIXELS
            fixtureindex = 0
            For x = 0 To ((MAXPIXELS - 1) * FIXTURESIZE) Step FIXTURESIZE

                phased = (fixtureindex + y) Mod MAXPIXELS

                redres = Int((redColorDiff / MAXPIXELS) * phased) + Int(colorA.R)
                grnres = Int((greenColorDiff / MAXPIXELS) * phased) + Int(colorA.G)
                blures = Int((blueColorDiff / MAXPIXELS) * phased) + Int(colorA.B)

                output(y, x + RGBFIXTUREOFFSET) = redres
                output(y, x + 1 + RGBFIXTUREOFFSET) = grnres
                output(y, x + 2 + RGBFIXTUREOFFSET) = blures

                output(y, x + 6) = Int(txtEffectChannel.Text)

                fixtureindex += 1
            Next
            z = y
        Next


        y = z

        If True Then
            Do Until z = 0

                fixtureindex = 0
                For x = 0 To ((MAXPIXELS - 1) * FIXTURESIZE) Step FIXTURESIZE

                    phased = (fixtureindex + y) Mod MAXPIXELS

                    redres = Int((redColorDiff / MAXPIXELS) * phased) + Int(colorA.R)
                    grnres = Int((greenColorDiff / MAXPIXELS) * phased) + Int(colorA.G)
                    blures = Int((blueColorDiff / MAXPIXELS) * phased) + Int(colorA.B)

                    output(y, x + RGBFIXTUREOFFSET) = redres
                    output(y, x + 1 + RGBFIXTUREOFFSET) = grnres
                    output(y, x + 2 + RGBFIXTUREOFFSET) = blures

                    output(y, x + 6) = Int(txtEffectChannel.Text)

                    fixtureindex += 1

                    y += 1
                    z -= 1

                Next

            Loop
        End If

        'output stop
        output(y, 0) = -10

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        'Dim saveFilename As String

        'open/create file
        Try
            If dlgSceneFileSave.ShowDialog() = DialogResult.OK Then

                txtSaveFileName.Text = dlgSceneFileSave().FileName

            Else
                Exit Sub
            End If

            Dim objWriter As IO.StreamWriter = IO.File.CreateText(txtSaveFileName.Text)
            Dim x As Integer
            x = 0

            'do while output is not stop or ended
            Do While output(x, 0) >= 0




                If x > MAXFRAMES Then
                    Throw New ApplicationException("Exceeded max frames")
                End If


                For y = 0 To MAXPIXELS * FIXTURESIZE

                    If y < MAXPIXELS * FIXTURESIZE Then
                        objWriter.Write(Str(output(x, y)) + ",")
                    Else
                        objWriter.Write(Str(output(x, y)))
                    End If

                Next

                objWriter.Write(Environment.NewLine)
                x += 1

            Loop

            'Dim bounceenabled = True

            'If bounceenabled = True Then
            '    Dim x2 As Integer
            '    x2 = x
            '    Do While x >= 0


            '        For y = 0 To MAXPIXELS * FIXTURESIZE
            '            If y < MAXPIXELS * FIXTURESIZE Then
            '                objWriter.Write(Str(output(x2, y)) + ",")
            '            Else
            '                objWriter.Write(Str(output(x2, y)))
            '            End If

            '        Next

            '        objWriter.Write(Environment.NewLine)
            '        x -= 1
            '        x2 += 1

            '    Loop

            'End If



            objWriter.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub

    Private Sub barEffect_Scroll(sender As Object, e As EventArgs) Handles barEffect.Scroll
        txtEffectChannel.Text = barEffect.Value

    End Sub

    Private Sub tabGradient_Click(sender As Object, e As EventArgs) Handles tabGradient.Click

    End Sub

End Class
