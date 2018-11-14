<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EVENTUS_GmbH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EVENTUS_GmbH))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.com_bx_Server = New System.Windows.Forms.ComboBox()
        Me.com_bx_database = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1249, 212)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EVENTUS GmbH"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(114, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(467, 109)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Standard- und Benutzerabfragen"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(644, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(467, 109)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Datenbankelemente hinzufügen"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(1196, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(467, 109)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Mitarbeiterdatenbank"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'com_bx_Server
        '
        Me.com_bx_Server.AutoCompleteCustomSource.AddRange(New String() {"Server wählen....", "PAULSPC"})
        Me.com_bx_Server.FormattingEnabled = True
        Me.com_bx_Server.Location = New System.Drawing.Point(39, 50)
        Me.com_bx_Server.Name = "com_bx_Server"
        Me.com_bx_Server.Size = New System.Drawing.Size(504, 39)
        Me.com_bx_Server.TabIndex = 4
        '
        'com_bx_database
        '
        Me.com_bx_database.FormattingEnabled = True
        Me.com_bx_database.Location = New System.Drawing.Point(39, 129)
        Me.com_bx_database.Name = "com_bx_database"
        Me.com_bx_database.Size = New System.Drawing.Size(504, 39)
        Me.com_bx_database.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(62, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(456, 58)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Verbindungsparameter festlegen"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.com_bx_Server)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.com_bx_database)
        Me.GroupBox1.Location = New System.Drawing.Point(594, 613)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 277)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verbindungsparameter"
        '
        'EVENTUS_GmbH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1968, 912)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 1000)
        Me.MinimumSize = New System.Drawing.Size(2000, 1000)
        Me.Name = "EVENTUS_GmbH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "EVENTUS GmbH"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents com_bx_Server As ComboBox
    Friend WithEvents com_bx_database As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
