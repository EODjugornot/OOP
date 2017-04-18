<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        Me.Copyright = New System.Windows.Forms.Label()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.barLoading = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Ubuntu", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Copyright.Location = New System.Drawing.Point(240, 277)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(240, 40)
        Me.Copyright.TabIndex = 0
        Me.Copyright.Text = "Copyright Info"
        '
        'AppTitle
        '
        Me.AppTitle.AutoSize = True
        Me.AppTitle.BackColor = System.Drawing.Color.Transparent
        Me.AppTitle.Font = New System.Drawing.Font("Ubuntu", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AppTitle.Location = New System.Drawing.Point(239, 225)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(343, 52)
        Me.AppTitle.TabIndex = 1
        Me.AppTitle.Text = "Application Title"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProgress.Location = New System.Drawing.Point(286, 378)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(59, 21)
        Me.lblProgress.TabIndex = 3
        Me.lblProgress.Text = "Label1"
        '
        'barLoading
        '
        Me.barLoading.ForeColor = System.Drawing.Color.DarkOrange
        Me.barLoading.Location = New System.Drawing.Point(12, 345)
        Me.barLoading.Name = "barLoading"
        Me.barLoading.Size = New System.Drawing.Size(576, 23)
        Me.barLoading.Step = 1
        Me.barLoading.TabIndex = 2
        '
        'splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.barLoading)
        Me.Controls.Add(Me.AppTitle)
        Me.Controls.Add(Me.Copyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.Name = "splashscreen"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splashscreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Copyright As Label
    Friend WithEvents AppTitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblProgress As Label
    Friend WithEvents barLoading As ProgressBar
End Class
