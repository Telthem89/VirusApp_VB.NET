<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpashScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressLoader = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblProCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(184, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ZIMPLATS ANTIVIRUS"
        '
        'ProgressLoader
        '
        Me.ProgressLoader.Location = New System.Drawing.Point(1, 463)
        Me.ProgressLoader.Name = "ProgressLoader"
        Me.ProgressLoader.Size = New System.Drawing.Size(693, 10)
        Me.ProgressLoader.TabIndex = 1
        Me.ProgressLoader.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(115, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 50)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please wait...."
        '
        'splashTimer
        '
        '
        'lblProCount
        '
        Me.lblProCount.AutoSize = True
        Me.lblProCount.BackColor = System.Drawing.Color.Transparent
        Me.lblProCount.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProCount.ForeColor = System.Drawing.Color.White
        Me.lblProCount.Location = New System.Drawing.Point(402, 385)
        Me.lblProCount.Name = "lblProCount"
        Me.lblProCount.Size = New System.Drawing.Size(45, 50)
        Me.lblProCount.TabIndex = 3
        Me.lblProCount.Text = "0"
        '
        'SpashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.zimplantsAntiruspro.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 470)
        Me.Controls.Add(Me.lblProCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressLoader)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SpashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressLoader As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents splashTimer As Timer
    Friend WithEvents lblProCount As Label
End Class
