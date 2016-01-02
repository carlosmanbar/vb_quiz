<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ltTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlPoints = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ltDifficulty = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lQuestion = New System.Windows.Forms.Label()
        Me.btAnswer1 = New System.Windows.Forms.Button()
        Me.btAnswer2 = New System.Windows.Forms.Button()
        Me.btAnswer3 = New System.Windows.Forms.Button()
        Me.btAnswer4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ltTime, Me.tlPoints, Me.ltDifficulty})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 337)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(284, 24)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ltTime
        '
        Me.ltTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ltTime.Name = "ltTime"
        Me.ltTime.Size = New System.Drawing.Size(50, 19)
        Me.ltTime.Text = "Time: 1"
        '
        'tlPoints
        '
        Me.tlPoints.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tlPoints.Name = "tlPoints"
        Me.tlPoints.Size = New System.Drawing.Size(68, 19)
        Me.tlPoints.Text = "Points: 100"
        '
        'ltDifficulty
        '
        Me.ltDifficulty.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ltDifficulty.Name = "ltDifficulty"
        Me.ltDifficulty.Size = New System.Drawing.Size(88, 19)
        Me.ltDifficulty.Text = "Difficulty: Easy"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NovoToolStripMenuItem.Text = "&New game"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AjudaToolStripMenuItem.Text = "&About"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SairToolStripMenuItem.Text = "&Exit"
        '
        'lQuestion
        '
        Me.lQuestion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQuestion.Location = New System.Drawing.Point(12, 37)
        Me.lQuestion.Name = "lQuestion"
        Me.lQuestion.Size = New System.Drawing.Size(260, 74)
        Me.lQuestion.TabIndex = 2
        Me.lQuestion.Text = "Pergunta qualquer coisa se for grande demais ou ainda maior, tipo mesmo grande da" &
    "rá para mais quatro linhas"
        Me.lQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lQuestion.Visible = False
        '
        'btAnswer1
        '
        Me.btAnswer1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnswer1.Location = New System.Drawing.Point(12, 130)
        Me.btAnswer1.Name = "btAnswer1"
        Me.btAnswer1.Size = New System.Drawing.Size(260, 44)
        Me.btAnswer1.TabIndex = 3
        Me.btAnswer1.Text = "Resposta fixe que pode conter duas linhas"
        Me.btAnswer1.UseVisualStyleBackColor = True
        Me.btAnswer1.Visible = False
        '
        'btAnswer2
        '
        Me.btAnswer2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnswer2.Location = New System.Drawing.Point(12, 180)
        Me.btAnswer2.Name = "btAnswer2"
        Me.btAnswer2.Size = New System.Drawing.Size(260, 44)
        Me.btAnswer2.TabIndex = 4
        Me.btAnswer2.Text = "Resposta fixe que pode conter duas linhas"
        Me.btAnswer2.UseVisualStyleBackColor = True
        Me.btAnswer2.Visible = False
        '
        'btAnswer3
        '
        Me.btAnswer3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnswer3.Location = New System.Drawing.Point(12, 230)
        Me.btAnswer3.Name = "btAnswer3"
        Me.btAnswer3.Size = New System.Drawing.Size(260, 44)
        Me.btAnswer3.TabIndex = 5
        Me.btAnswer3.Text = "Resposta fixe que pode conter duas linhas"
        Me.btAnswer3.UseVisualStyleBackColor = True
        Me.btAnswer3.Visible = False
        '
        'btAnswer4
        '
        Me.btAnswer4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnswer4.Location = New System.Drawing.Point(12, 280)
        Me.btAnswer4.Name = "btAnswer4"
        Me.btAnswer4.Size = New System.Drawing.Size(260, 44)
        Me.btAnswer4.TabIndex = 6
        Me.btAnswer4.Text = "Resposta fixe que pode conter duas linhas"
        Me.btAnswer4.UseVisualStyleBackColor = True
        Me.btAnswer4.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cQuiz.My.Resources.Resources.backwelcome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btAnswer4)
        Me.Controls.Add(Me.btAnswer3)
        Me.Controls.Add(Me.btAnswer2)
        Me.Controls.Add(Me.btAnswer1)
        Me.Controls.Add(Me.lQuestion)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cQuiz"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ltTime As ToolStripStatusLabel
    Friend WithEvents tlPoints As ToolStripStatusLabel
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ltDifficulty As ToolStripStatusLabel
    Friend WithEvents lQuestion As Label
    Friend WithEvents btAnswer1 As Button
    Friend WithEvents btAnswer2 As Button
    Friend WithEvents btAnswer3 As Button
    Friend WithEvents btAnswer4 As Button
    Friend WithEvents Timer1 As Timer
End Class
