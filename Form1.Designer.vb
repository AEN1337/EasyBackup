<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.backup = New System.Windows.Forms.Button()
        Me.bckload = New System.Windows.Forms.Button()
        Me.folder = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'backup
        '
        Me.backup.Location = New System.Drawing.Point(407, 179)
        Me.backup.Name = "backup"
        Me.backup.Size = New System.Drawing.Size(165, 23)
        Me.backup.TabIndex = 0
        Me.backup.Text = "Backup"
        Me.backup.UseVisualStyleBackColor = True
        '
        'bckload
        '
        Me.bckload.Location = New System.Drawing.Point(211, 179)
        Me.bckload.Name = "bckload"
        Me.bckload.Size = New System.Drawing.Size(165, 23)
        Me.bckload.TabIndex = 1
        Me.bckload.Text = "Load"
        Me.bckload.UseVisualStyleBackColor = True
        '
        'folder
        '
        Me.folder.Location = New System.Drawing.Point(12, 179)
        Me.folder.Name = "folder"
        Me.folder.Size = New System.Drawing.Size(165, 23)
        Me.folder.TabIndex = 2
        Me.folder.Text = "Open folder"
        Me.folder.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(407, 13)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(165, 23)
        Me.settings.TabIndex = 3
        Me.settings.Text = "Settings"
        Me.settings.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 223)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(560, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lotusflower", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Easy Backup by AEN"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.folder)
        Me.Controls.Add(Me.bckload)
        Me.Controls.Add(Me.backup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EasyBackup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backup As System.Windows.Forms.Button
    Friend WithEvents bckload As System.Windows.Forms.Button
    Friend WithEvents folder As System.Windows.Forms.Button
    Friend WithEvents settings As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
