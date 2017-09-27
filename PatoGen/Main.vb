Public Class frmMain
    Const FIXTURELIMIT = 73
    Public MAXPIXELS = 50
    Public FIXTURESIZE = 7
    Public RGBFIXTUREOFFSET = 3
    Public MAXFRAMES = 6000                              'w2. five minutes at 40 frames per second

    Dim output(MAXFRAMES, FIXTURELIMIT * FIXTURESIZE) As Short       ' output(frame number, channel)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudFixtures.Value = MAXPIXELS



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
            z = y       'store end index
        Next

        redColorDiff = Int(colorA.R) - Int(colorB.R)
        greenColorDiff = Int(colorA.G) - Int(colorB.G)
        blueColorDiff = Int(colorA.B) - Int(colorB.B)

        y = z           'start at end!

        If True Then
            For y = z To MAXPIXELS * 2
                fixtureindex = 0
                For x = 0 To ((MAXPIXELS - 1) * FIXTURESIZE) Step FIXTURESIZE

                    phased = (fixtureindex + y) Mod MAXPIXELS

                    redres = Int((redColorDiff / MAXPIXELS) * phased) + Int(colorB.R)
                    grnres = Int((greenColorDiff / MAXPIXELS) * phased) + Int(colorB.G)
                    blures = Int((blueColorDiff / MAXPIXELS) * phased) + Int(colorB.B)

                    output(y, x + RGBFIXTUREOFFSET) = redres
                    output(y, x + 1 + RGBFIXTUREOFFSET) = grnres
                    output(y, x + 2 + RGBFIXTUREOFFSET) = blures

                    output(y, x + 6) = Int(txtEffectChannel.Text)

                    fixtureindex += 1
                Next
                z = y       'store end index
            Next
        End If

        'output stop
        output(y, RGBFIXTUREOFFSET) = -10

    End Sub

    Private Sub WriteOutputToFile()

        'open/create file
        'Try
        If dlgSceneFileSave.ShowDialog() = DialogResult.OK Then

                txtSaveFileName.Text = dlgSceneFileSave().FileName

            Else
                Exit Sub
            End If

            Dim objWriter As IO.StreamWriter = IO.File.CreateText(txtSaveFileName.Text)
            Dim x As Integer
            x = 0

        'do while output is not stop or ended
        Do While output(x, RGBFIXTUREOFFSET) >= 0

            If x > MAXFRAMES Then
                Throw New ApplicationException("Exceeded max frames")
            End If

            For y = 0 To MAXPIXELS * FIXTURESIZE

                If y < MAXPIXELS * FIXTURESIZE Then
                    objWriter.Write(Str(output(x, y)) + ",")        'write out a csv list of DMX values
                Else
                    objWriter.Write(Str(output(x, y)))              'last entry should not have ,
                End If

            Next

            objWriter.Write(Environment.NewLine)
            x += 1

        Loop

        objWriter.Close()

        ' Catch ex As Exception
        'MessageBox.Show(ex.ToString)
        'End Try

    End Sub

    Private Sub btnCyclePreview_Click(sender As Object, e As EventArgs) Handles btnCyclePreview.Click

        Me.Refresh()

    End Sub



    Private Sub picCyclePreview_Paint(sender As Object, e As PaintEventArgs) Handles picCyclePreview.Paint
        Dim gfx = e.Graphics
        Dim degrad = (Math.PI / 180)

        'angle = input + phase
        'col => (sin(angle) * 128) + 128

        If chkRedCycEnable.Checked Then
            Dim penRed As New Pen(Color.Red, 5)
            Dim y As Integer
            For x As Integer = 0 To Me.Width Step (Me.Width / MAXPIXELS)
                y = Int(Math.Sin((x * degrad + nudRedPhase.Value) * nudRedPeriod.Value) * 127) + 127
                gfx.DrawLine(penRed, x, y, x + 1, y)
            Next
        End If

        If chkGrnCycEnable.Checked Then
            Dim penGrn As New Pen(Color.Green, 5)
            Dim y As Integer
            For x As Integer = 0 To Me.Width Step (Me.Width / MAXPIXELS)
                y = Int(Math.Sin((x * degrad + nudGrnPhase.Value) * nudGrnPeriod.Value) * 127) + 127
                gfx.DrawLine(penGrn, x, y, x + 1, y)
            Next
        End If

        If chkBluCycEnable.Checked Then
            Dim penBlu As New Pen(Color.Blue, 5)
            Dim y As Integer
            For x As Integer = 0 To Me.Width Step (Me.Width / MAXPIXELS)
                y = Int(Math.Sin((x * degrad + nudBluPhase.Value) * nudBluPeriod.Value) * 127) + 127
                gfx.DrawLine(penBlu, x, y, x + 1, y)
            Next
        End If

        RenderCycles()

    End Sub



    Private Sub RenderCycles()

        Dim degrad = (Math.PI / 180)

        'largest phase is 360 x larges period + phase, and we want to cycle to largest/longest

        'Dim redmax = (3 * 360 * nudRedPeriod.Value + nudRedPhase.Value)
        'Dim grnmax = 360 * nudGrnPeriod.Value + nudGrnPhase.Value
        'Dim blumax = 360 * nudBluPeriod.Value + nudBluPhase.Value
        'Dim cyclemax = redmax
        'If grnmax > cyclemax Then
        '    cyclemax = grnmax
        'End If
        'If blumax > cyclemax Then
        '    cyclemax = blumax
        'End If
        Dim cyclemax = MAXFRAMES - 1
        Dim fixturelimit = (FIXTURESIZE * MAXPIXELS) - 1

        For z = 0 To cyclemax Step 1

            If chkRedCycEnable.Checked Then

                Dim y As Integer
                For x As Integer = 0 To fixturelimit Step FIXTURESIZE
                    y = Int(Math.Sin((x * degrad + nudRedPhase.Value + z) * nudRedPeriod.Value) * 127) + 127
                    output(z, x + RGBFIXTUREOFFSET) = y
                Next
            End If

            If chkGrnCycEnable.Checked Then

                Dim y As Integer
                For x As Integer = 0 To fixturelimit Step FIXTURESIZE
                    y = Int(Math.Sin((x * degrad + nudGrnPhase.Value + z) * nudGrnPeriod.Value) * 127) + 127
                    output(z, x + RGBFIXTUREOFFSET + 1) = y
                Next
            End If

            If chkBluCycEnable.Checked Then

                Dim y As Integer
                For x As Integer = 0 To fixturelimit Step FIXTURESIZE
                    y = Int(Math.Sin((x * degrad + nudBluPhase.Value + z) * nudBluPeriod.Value) * 127) + 127
                    output(z, x + RGBFIXTUREOFFSET + 2) = y
                Next
            End If

            For x As Integer = 0 To fixturelimit Step FIXTURESIZE

                output(z, x + 6) = Int(txtEffectChannel.Text)
                output(z, x) = Int(picBaseCol.BackColor.R)
                output(z, x + 1) = Int(picBaseCol.BackColor.G)
                output(z, x + 2) = Int(picBaseCol.BackColor.B)

            Next
            output(z + 1, RGBFIXTUREOFFSET) = -10      'marking out of output, overwritten by next loop if there is a next loop
        Next

        '

    End Sub

    Private Sub btnWriteCycle_Click(sender As Object, e As EventArgs) Handles btnWriteCycle.Click
        WriteOutputToFile()

    End Sub

    Private Sub nudCycleLength_ValueChanged(sender As Object, e As EventArgs) Handles nudFixtures.ValueChanged
        MAXPIXELS = Int(nudFixtures.Value)
    End Sub

    Private Sub barEffect_Scroll(sender As Object, e As EventArgs) Handles barEffect.Scroll
        txtEffectChannel.Text = Me.barEffect.Value
    End Sub

    Private Sub picBaseCol_Click(sender As Object, e As EventArgs) Handles picBaseCol.Click

        If cdPicker.ShowDialog() = DialogResult.OK Then
            Me.picBaseCol.BackColor = cdPicker.Color
        End If
    End Sub
End Class
