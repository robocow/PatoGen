<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cdPicker = New System.Windows.Forms.ColorDialog()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabGradient = New System.Windows.Forms.TabPage()
        Me.picGradientPreview = New System.Windows.Forms.PictureBox()
        Me.picGradientColor2 = New System.Windows.Forms.PictureBox()
        Me.picGradientColor1 = New System.Windows.Forms.PictureBox()
        Me.tabCycles = New System.Windows.Forms.TabPage()
        Me.picBaseCol = New System.Windows.Forms.PictureBox()
        Me.btnCyclePreview = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudBluPhase = New System.Windows.Forms.NumericUpDown()
        Me.nudGrnPhase = New System.Windows.Forms.NumericUpDown()
        Me.nudRedPhase = New System.Windows.Forms.NumericUpDown()
        Me.nudBluPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudGrnPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudRedPeriod = New System.Windows.Forms.NumericUpDown()
        Me.chkBluCycEnable = New System.Windows.Forms.CheckBox()
        Me.chkGrnCycEnable = New System.Windows.Forms.CheckBox()
        Me.chkRedCycEnable = New System.Windows.Forms.CheckBox()
        Me.picCyclePreview = New System.Windows.Forms.PictureBox()
        Me.dlgSceneFileSave = New System.Windows.Forms.SaveFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudFixtures = New System.Windows.Forms.NumericUpDown()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.txtSaveFileName = New System.Windows.Forms.TextBox()
        Me.btnWriteCycle = New System.Windows.Forms.Button()
        Me.barEffect = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEffectChannel = New System.Windows.Forms.TextBox()
        Me.tabMain.SuspendLayout()
        Me.tabGradient.SuspendLayout()
        CType(Me.picGradientPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGradientColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGradientColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCycles.SuspendLayout()
        CType(Me.picBaseCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBluPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGrnPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRedPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBluPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGrnPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRedPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCyclePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFixtures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabGradient)
        Me.tabMain.Controls.Add(Me.tabCycles)
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        '
        'tabGradient
        '
        Me.tabGradient.Controls.Add(Me.picGradientPreview)
        Me.tabGradient.Controls.Add(Me.picGradientColor2)
        Me.tabGradient.Controls.Add(Me.picGradientColor1)
        resources.ApplyResources(Me.tabGradient, "tabGradient")
        Me.tabGradient.Name = "tabGradient"
        Me.tabGradient.UseVisualStyleBackColor = True
        '
        'picGradientPreview
        '
        resources.ApplyResources(Me.picGradientPreview, "picGradientPreview")
        Me.picGradientPreview.Name = "picGradientPreview"
        Me.picGradientPreview.TabStop = False
        '
        'picGradientColor2
        '
        Me.picGradientColor2.BackColor = System.Drawing.Color.Black
        Me.picGradientColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picGradientColor2, "picGradientColor2")
        Me.picGradientColor2.Name = "picGradientColor2"
        Me.picGradientColor2.TabStop = False
        '
        'picGradientColor1
        '
        Me.picGradientColor1.BackColor = System.Drawing.Color.Black
        Me.picGradientColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picGradientColor1, "picGradientColor1")
        Me.picGradientColor1.Name = "picGradientColor1"
        Me.picGradientColor1.TabStop = False
        '
        'tabCycles
        '
        Me.tabCycles.Controls.Add(Me.picBaseCol)
        Me.tabCycles.Controls.Add(Me.btnCyclePreview)
        Me.tabCycles.Controls.Add(Me.Label5)
        Me.tabCycles.Controls.Add(Me.Label4)
        Me.tabCycles.Controls.Add(Me.Label3)
        Me.tabCycles.Controls.Add(Me.nudBluPhase)
        Me.tabCycles.Controls.Add(Me.nudGrnPhase)
        Me.tabCycles.Controls.Add(Me.nudRedPhase)
        Me.tabCycles.Controls.Add(Me.nudBluPeriod)
        Me.tabCycles.Controls.Add(Me.nudGrnPeriod)
        Me.tabCycles.Controls.Add(Me.nudRedPeriod)
        Me.tabCycles.Controls.Add(Me.chkBluCycEnable)
        Me.tabCycles.Controls.Add(Me.chkGrnCycEnable)
        Me.tabCycles.Controls.Add(Me.chkRedCycEnable)
        Me.tabCycles.Controls.Add(Me.picCyclePreview)
        resources.ApplyResources(Me.tabCycles, "tabCycles")
        Me.tabCycles.Name = "tabCycles"
        Me.tabCycles.UseVisualStyleBackColor = True
        '
        'picBaseCol
        '
        Me.picBaseCol.BackColor = System.Drawing.Color.Black
        Me.picBaseCol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picBaseCol, "picBaseCol")
        Me.picBaseCol.Name = "picBaseCol"
        Me.picBaseCol.TabStop = False
        '
        'btnCyclePreview
        '
        resources.ApplyResources(Me.btnCyclePreview, "btnCyclePreview")
        Me.btnCyclePreview.Name = "btnCyclePreview"
        Me.btnCyclePreview.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'nudBluPhase
        '
        resources.ApplyResources(Me.nudBluPhase, "nudBluPhase")
        Me.nudBluPhase.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudBluPhase.Name = "nudBluPhase"
        '
        'nudGrnPhase
        '
        resources.ApplyResources(Me.nudGrnPhase, "nudGrnPhase")
        Me.nudGrnPhase.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudGrnPhase.Name = "nudGrnPhase"
        '
        'nudRedPhase
        '
        resources.ApplyResources(Me.nudRedPhase, "nudRedPhase")
        Me.nudRedPhase.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudRedPhase.Name = "nudRedPhase"
        '
        'nudBluPeriod
        '
        Me.nudBluPeriod.DecimalPlaces = 3
        Me.nudBluPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.nudBluPeriod, "nudBluPeriod")
        Me.nudBluPeriod.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudBluPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudBluPeriod.Name = "nudBluPeriod"
        Me.nudBluPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGrnPeriod
        '
        Me.nudGrnPeriod.DecimalPlaces = 3
        Me.nudGrnPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.nudGrnPeriod, "nudGrnPeriod")
        Me.nudGrnPeriod.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudGrnPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudGrnPeriod.Name = "nudGrnPeriod"
        Me.nudGrnPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudRedPeriod
        '
        Me.nudRedPeriod.DecimalPlaces = 3
        Me.nudRedPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.nudRedPeriod, "nudRedPeriod")
        Me.nudRedPeriod.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudRedPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudRedPeriod.Name = "nudRedPeriod"
        Me.nudRedPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkBluCycEnable
        '
        resources.ApplyResources(Me.chkBluCycEnable, "chkBluCycEnable")
        Me.chkBluCycEnable.Name = "chkBluCycEnable"
        Me.chkBluCycEnable.UseVisualStyleBackColor = True
        '
        'chkGrnCycEnable
        '
        resources.ApplyResources(Me.chkGrnCycEnable, "chkGrnCycEnable")
        Me.chkGrnCycEnable.Name = "chkGrnCycEnable"
        Me.chkGrnCycEnable.UseVisualStyleBackColor = True
        '
        'chkRedCycEnable
        '
        resources.ApplyResources(Me.chkRedCycEnable, "chkRedCycEnable")
        Me.chkRedCycEnable.Name = "chkRedCycEnable"
        Me.chkRedCycEnable.UseVisualStyleBackColor = True
        '
        'picCyclePreview
        '
        Me.picCyclePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picCyclePreview, "picCyclePreview")
        Me.picCyclePreview.Name = "picCyclePreview"
        Me.picCyclePreview.TabStop = False
        '
        'dlgSceneFileSave
        '
        Me.dlgSceneFileSave.CheckFileExists = True
        Me.dlgSceneFileSave.CreatePrompt = True
        resources.ApplyResources(Me.dlgSceneFileSave, "dlgSceneFileSave")
        Me.dlgSceneFileSave.ValidateNames = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'nudFixtures
        '
        resources.ApplyResources(Me.nudFixtures, "nudFixtures")
        Me.nudFixtures.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFixtures.Name = "nudFixtures"
        Me.nudFixtures.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Timer
        '
        Me.Timer.Interval = 20
        '
        'txtSaveFileName
        '
        Me.txtSaveFileName.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Me.txtSaveFileName, "txtSaveFileName")
        Me.txtSaveFileName.Name = "txtSaveFileName"
        '
        'btnWriteCycle
        '
        resources.ApplyResources(Me.btnWriteCycle, "btnWriteCycle")
        Me.btnWriteCycle.Name = "btnWriteCycle"
        Me.btnWriteCycle.UseVisualStyleBackColor = True
        '
        'barEffect
        '
        resources.ApplyResources(Me.barEffect, "barEffect")
        Me.barEffect.Maximum = 255
        Me.barEffect.Name = "barEffect"
        Me.barEffect.Value = 200
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtEffectChannel
        '
        resources.ApplyResources(Me.txtEffectChannel, "txtEffectChannel")
        Me.txtEffectChannel.Name = "txtEffectChannel"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.barEffect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEffectChannel)
        Me.Controls.Add(Me.txtSaveFileName)
        Me.Controls.Add(Me.btnWriteCycle)
        Me.Controls.Add(Me.nudFixtures)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmMain"
        Me.tabMain.ResumeLayout(False)
        Me.tabGradient.ResumeLayout(False)
        CType(Me.picGradientPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGradientColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGradientColor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCycles.ResumeLayout(False)
        Me.tabCycles.PerformLayout()
        CType(Me.picBaseCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBluPhase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGrnPhase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRedPhase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBluPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGrnPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRedPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCyclePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFixtures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barEffect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cdPicker As ColorDialog
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabGradient As TabPage
    Friend WithEvents tabCycles As TabPage
    Friend WithEvents picGradientPreview As PictureBox
    Friend WithEvents picGradientColor2 As PictureBox
    Friend WithEvents picGradientColor1 As PictureBox
    Friend WithEvents dlgSceneFileSave As SaveFileDialog
    Friend WithEvents picCyclePreview As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudFixtures As NumericUpDown
    Friend WithEvents chkBluCycEnable As CheckBox
    Friend WithEvents chkGrnCycEnable As CheckBox
    Friend WithEvents chkRedCycEnable As CheckBox
    Friend WithEvents nudBluPeriod As NumericUpDown
    Friend WithEvents nudGrnPeriod As NumericUpDown
    Friend WithEvents nudRedPeriod As NumericUpDown
    Friend WithEvents Timer As Timer
    Friend WithEvents nudBluPhase As NumericUpDown
    Friend WithEvents nudGrnPhase As NumericUpDown
    Friend WithEvents nudRedPhase As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCyclePreview As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaveFileName As TextBox
    Friend WithEvents btnWriteCycle As Button
    Friend WithEvents barEffect As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEffectChannel As TextBox
    Friend WithEvents picBaseCol As PictureBox
End Class
