<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fmr_Startseite
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
        Me.CmdNeuesRezept = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.LstViewAllRezepte = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNameRezept = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderRezeptArt = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderKalorien = New System.Windows.Forms.ColumnHeader()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip_Level1_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdNeuesRezept
        '
        Me.CmdNeuesRezept.Location = New System.Drawing.Point(12, 389)
        Me.CmdNeuesRezept.Name = "CmdNeuesRezept"
        Me.CmdNeuesRezept.Size = New System.Drawing.Size(125, 49)
        Me.CmdNeuesRezept.TabIndex = 0
        Me.CmdNeuesRezept.Text = "Neues Rezept"
        Me.CmdNeuesRezept.UseVisualStyleBackColor = True
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(663, 389)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(125, 49)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Beenden"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'LstViewAllRezepte
        '
        Me.LstViewAllRezepte.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNameRezept, Me.ColumnHeaderRezeptArt, Me.ColumnHeaderKalorien})
        Me.LstViewAllRezepte.Location = New System.Drawing.Point(12, 49)
        Me.LstViewAllRezepte.Name = "LstViewAllRezepte"
        Me.LstViewAllRezepte.Size = New System.Drawing.Size(776, 251)
        Me.LstViewAllRezepte.TabIndex = 2
        Me.LstViewAllRezepte.UseCompatibleStateImageBehavior = False
        Me.LstViewAllRezepte.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNameRezept
        '
        Me.ColumnHeaderNameRezept.Text = "Rezeptname"
        '
        'ColumnHeaderRezeptArt
        '
        Me.ColumnHeaderRezeptArt.Text = "Art"
        '
        'ColumnHeaderKalorien
        '
        Me.ColumnHeaderKalorien.Text = "Kalorien"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_Level1_1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip_Level1_1
        '
        Me.MenuStrip_Level1_1.Name = "MenuStrip_Level1_1"
        Me.MenuStrip_Level1_1.Size = New System.Drawing.Size(59, 24)
        Me.MenuStrip_Level1_1.Text = "Datei"
        '
        'Fmr_Startseite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LstViewAllRezepte)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdNeuesRezept)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fmr_Startseite"
        Me.Text = "Rezeptbuch"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdNeuesRezept As Button
    Friend WithEvents CmdExit As Button
    Friend WithEvents LstViewAllRezepte As ListView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip_Level1_1 As ToolStripMenuItem
    Friend WithEvents ColumnHeaderNameRezept As ColumnHeader
    Friend WithEvents ColumnHeaderRezeptArt As ColumnHeader
    Friend WithEvents ColumnHeaderKalorien As ColumnHeader
End Class
