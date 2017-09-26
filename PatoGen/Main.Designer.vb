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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cdPicker = New System.Windows.Forms.ColorDialog()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabGradient = New System.Windows.Forms.TabPage()
        Me.barEffect = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEffectChannel = New System.Windows.Forms.TextBox()
        Me.txtSaveFileName = New System.Windows.Forms.TextBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.picGradientPreview = New System.Windows.Forms.PictureBox()
        Me.picGradientColor2 = New System.Windows.Forms.PictureBox()
        Me.picGradientColor1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dlgSceneFileSave = New System.Windows.Forms.SaveFileDialog()
        Me.tabMain.SuspendLayout()
        Me.tabGradient.SuspendLayout()
        CType(Me.barEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGradientPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGradientColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGradientColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabGradient)
        Me.tabMain.Controls.Add(Me.TabPage2)
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        '
        'tabGradient
        '
        Me.tabGradient.Controls.Add(Me.barEffect)
        Me.tabGradient.Controls.Add(Me.Label1)
        Me.tabGradient.Controls.Add(Me.txtEffectChannel)
        Me.tabGradient.Controls.Add(Me.txtSaveFileName)
        Me.tabGradient.Controls.Add(Me.btnWrite)
        Me.tabGradient.Controls.Add(Me.picGradientPreview)
        Me.tabGradient.Controls.Add(Me.picGradientColor2)
        Me.tabGradient.Controls.Add(Me.picGradientColor1)
        resources.ApplyResources(Me.tabGradient, "tabGradient")
        Me.tabGradient.Name = "tabGradient"
        Me.tabGradient.UseVisualStyleBackColor = True
        '
        'barEffect
        '
        resources.ApplyResources(Me.barEffect, "barEffect")
        Me.barEffect.Maximum = 255
        Me.barEffect.Name = "barEffect"
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
        'txtSaveFileName
        '
        Me.txtSaveFileName.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Me.txtSaveFileName, "txtSaveFileName")
        Me.txtSaveFileName.Name = "txtSaveFileName"
        '
        'btnWrite
        '
        resources.ApplyResources(Me.btnWrite, "btnWrite")
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'picGradientPreview
        '
        resources.ApplyResources(Me.picGradientPreview, "picGradientPreview")
        Me.picGradientPreview.Name = "picGradientPreview"
        Me.picGradientPreview.TabStop = False
        '
        'picGradientColor2
        '
        Me.picGradientColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picGradientColor2, "picGradientColor2")
        Me.picGradientColor2.Name = "picGradientColor2"
        Me.picGradientColor2.TabStop = False
        '
        'picGradientColor1
        '
        Me.picGradientColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picGradientColor1, "picGradientColor1")
        Me.picGradientColor1.Name = "picGradientColor1"
        Me.picGradientColor1.TabStop = False
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dlgSceneFileSave
        '
        Me.dlgSceneFileSave.CheckFileExists = True
        Me.dlgSceneFileSave.CreatePrompt = True
        resources.ApplyResources(Me.dlgSceneFileSave, "dlgSceneFileSave")
        Me.dlgSceneFileSave.ValidateNames = False
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmMain"
        Me.tabMain.ResumeLayout(False)
        Me.tabGradient.ResumeLayout(False)
        Me.tabGradient.PerformLayout()
        CType(Me.barEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGradientPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGradientColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGradientColor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cdPicker As ColorDialog
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabGradient As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents picGradientPreview As PictureBox
    Friend WithEvents picGradientColor2 As PictureBox
    Friend WithEvents picGradientColor1 As PictureBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents dlgSceneFileSave As SaveFileDialog
    Friend WithEvents txtSaveFileName As TextBox
    Friend WithEvents barEffect As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEffectChannel As TextBox
End Class
