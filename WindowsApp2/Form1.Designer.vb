<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fwall
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
        Dim Gwall As System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Ewall = New System.Windows.Forms.PictureBox()
        Me.win = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.Bwall = New System.Windows.Forms.PictureBox()
        Me.Cwall = New System.Windows.Forms.PictureBox()
        Me.Awall = New System.Windows.Forms.PictureBox()
        Me.Dwall = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Kwall = New System.Windows.Forms.PictureBox()
        Gwall = New System.Windows.Forms.PictureBox()
        CType(Gwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ewall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Awall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dwall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kwall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gwall
        '
        Gwall.BackColor = System.Drawing.SystemColors.Info
        Gwall.Location = New System.Drawing.Point(107, 114)
        Gwall.Name = "Gwall"
        Gwall.Size = New System.Drawing.Size(309, 17)
        Gwall.TabIndex = 10
        Gwall.TabStop = False
        AddHandler Gwall.Click, AddressOf Me.Gwall_Click
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'Ewall
        '
        Me.Ewall.BackColor = System.Drawing.SystemColors.Info
        Me.Ewall.Location = New System.Drawing.Point(540, 181)
        Me.Ewall.Name = "Ewall"
        Me.Ewall.Size = New System.Drawing.Size(248, 24)
        Me.Ewall.TabIndex = 9
        Me.Ewall.TabStop = False
        '
        'win
        '
        Me.win.Location = New System.Drawing.Point(685, 12)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(100, 50)
        Me.win.TabIndex = 8
        Me.win.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.Image = Global.WindowsApp2.My.Resources.Resources.download__4__removebg_preview
        Me.Bullet.Location = New System.Drawing.Point(59, 320)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(10, 12)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 7
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.SystemColors.Info
        Me.Wall.Location = New System.Drawing.Point(12, 290)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(251, 24)
        Me.Wall.TabIndex = 6
        Me.Wall.TabStop = False
        '
        'Bwall
        '
        Me.Bwall.BackColor = System.Drawing.SystemColors.Desktop
        Me.Bwall.Location = New System.Drawing.Point(791, -1)
        Me.Bwall.Name = "Bwall"
        Me.Bwall.Size = New System.Drawing.Size(10, 451)
        Me.Bwall.TabIndex = 5
        Me.Bwall.TabStop = False
        '
        'Cwall
        '
        Me.Cwall.BackColor = System.Drawing.SystemColors.Desktop
        Me.Cwall.Location = New System.Drawing.Point(0, 440)
        Me.Cwall.Name = "Cwall"
        Me.Cwall.Size = New System.Drawing.Size(801, 10)
        Me.Cwall.TabIndex = 4
        Me.Cwall.TabStop = False
        '
        'Awall
        '
        Me.Awall.BackColor = System.Drawing.SystemColors.Desktop
        Me.Awall.Location = New System.Drawing.Point(0, -1)
        Me.Awall.Name = "Awall"
        Me.Awall.Size = New System.Drawing.Size(801, 10)
        Me.Awall.TabIndex = 3
        Me.Awall.TabStop = False
        '
        'Dwall
        '
        Me.Dwall.BackColor = System.Drawing.SystemColors.Desktop
        Me.Dwall.Location = New System.Drawing.Point(0, -1)
        Me.Dwall.Name = "Dwall"
        Me.Dwall.Size = New System.Drawing.Size(10, 451)
        Me.Dwall.TabIndex = 2
        Me.Dwall.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.download__3__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(753, 402)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.images3
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(28, 338)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Kwall
        '
        Me.Kwall.BackColor = System.Drawing.SystemColors.Info
        Me.Kwall.Location = New System.Drawing.Point(540, 136)
        Me.Kwall.Name = "Kwall"
        Me.Kwall.Size = New System.Drawing.Size(38, 69)
        Me.Kwall.TabIndex = 11
        Me.Kwall.TabStop = False
        '
        'Fwall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Kwall)
        Me.Controls.Add(Gwall)
        Me.Controls.Add(Me.Ewall)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.Bwall)
        Me.Controls.Add(Me.Cwall)
        Me.Controls.Add(Me.Awall)
        Me.Controls.Add(Me.Dwall)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Fwall"
        Me.Text = "Form"
        CType(Gwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ewall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Awall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dwall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kwall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Dwall As PictureBox
    Friend WithEvents Awall As PictureBox
    Friend WithEvents Cwall As PictureBox
    Friend WithEvents Bwall As PictureBox
    Friend WithEvents Wall As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents win As PictureBox
    Friend WithEvents Ewall As PictureBox
    Friend WithEvents Kwall As PictureBox
End Class
