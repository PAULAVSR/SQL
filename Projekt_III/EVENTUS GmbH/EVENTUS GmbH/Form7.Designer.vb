<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.dgv_ergebnis_query = New System.Windows.Forms.DataGridView()
        Me.btn_abfrage_start = New System.Windows.Forms.Button()
        Me.rtb_sql = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_query_12 = New System.Windows.Forms.Button()
        Me.btn_query_11 = New System.Windows.Forms.Button()
        Me.btn_query_10 = New System.Windows.Forms.Button()
        Me.btn_query_9 = New System.Windows.Forms.Button()
        Me.btn_query_8 = New System.Windows.Forms.Button()
        Me.btn_query_7 = New System.Windows.Forms.Button()
        Me.btn_query_6 = New System.Windows.Forms.Button()
        Me.btn_query_5 = New System.Windows.Forms.Button()
        Me.btn_query_4 = New System.Windows.Forms.Button()
        Me.btn_query_3 = New System.Windows.Forms.Button()
        Me.btn_query_2 = New System.Windows.Forms.Button()
        Me.btn_query_1 = New System.Windows.Forms.Button()
        CType(Me.dgv_ergebnis_query, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_ergebnis_query
        '
        Me.dgv_ergebnis_query.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_ergebnis_query.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_ergebnis_query.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgv_ergebnis_query.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ergebnis_query.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ergebnis_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_ergebnis_query.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_ergebnis_query.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgv_ergebnis_query.Location = New System.Drawing.Point(39, 207)
        Me.dgv_ergebnis_query.Name = "dgv_ergebnis_query"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ergebnis_query.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_ergebnis_query.RowTemplate.Height = 40
        Me.dgv_ergebnis_query.Size = New System.Drawing.Size(2008, 926)
        Me.dgv_ergebnis_query.TabIndex = 40
        '
        'btn_abfrage_start
        '
        Me.btn_abfrage_start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_abfrage_start.Location = New System.Drawing.Point(2608, 963)
        Me.btn_abfrage_start.Name = "btn_abfrage_start"
        Me.btn_abfrage_start.Size = New System.Drawing.Size(270, 84)
        Me.btn_abfrage_start.TabIndex = 39
        Me.btn_abfrage_start.Text = "Abfrage starten"
        Me.btn_abfrage_start.UseVisualStyleBackColor = False
        Me.btn_abfrage_start.Visible = False
        '
        'rtb_sql
        '
        Me.rtb_sql.Location = New System.Drawing.Point(2224, 207)
        Me.rtb_sql.Name = "rtb_sql"
        Me.rtb_sql.Size = New System.Drawing.Size(905, 709)
        Me.rtb_sql.TabIndex = 38
        Me.rtb_sql.Text = ""
        Me.rtb_sql.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(2224, 963)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 84)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "eigene Abfrage"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_query_12
        '
        Me.btn_query_12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_12.Location = New System.Drawing.Point(2224, 1546)
        Me.btn_query_12.Name = "btn_query_12"
        Me.btn_query_12.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_12.TabIndex = 36
        Me.btn_query_12.Text = "Liste aller Dienstleister inkl. Veranstaltungen"
        Me.btn_query_12.UseVisualStyleBackColor = False
        '
        'btn_query_11
        '
        Me.btn_query_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_11.Location = New System.Drawing.Point(2224, 1367)
        Me.btn_query_11.Name = "btn_query_11"
        Me.btn_query_11.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_11.TabIndex = 35
        Me.btn_query_11.Text = "Konzerte ohne Reservierungen"
        Me.btn_query_11.UseVisualStyleBackColor = False
        '
        'btn_query_10
        '
        Me.btn_query_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_10.Location = New System.Drawing.Point(2224, 1181)
        Me.btn_query_10.Name = "btn_query_10"
        Me.btn_query_10.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_10.TabIndex = 34
        Me.btn_query_10.Text = "Veranstaltung mit Gewinnmaximun"
        Me.btn_query_10.UseVisualStyleBackColor = False
        '
        'btn_query_9
        '
        Me.btn_query_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_9.Location = New System.Drawing.Point(1546, 1546)
        Me.btn_query_9.Name = "btn_query_9"
        Me.btn_query_9.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_9.TabIndex = 33
        Me.btn_query_9.Text = "zuständiger Mitarbeiter für VIP-Gäste"
        Me.btn_query_9.UseVisualStyleBackColor = False
        '
        'btn_query_8
        '
        Me.btn_query_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_8.Location = New System.Drawing.Point(1546, 1367)
        Me.btn_query_8.Name = "btn_query_8"
        Me.btn_query_8.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_8.TabIndex = 32
        Me.btn_query_8.Text = "durchschnittliche Besucherzahl Veranstaltungen"
        Me.btn_query_8.UseVisualStyleBackColor = False
        '
        'btn_query_7
        '
        Me.btn_query_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_7.Location = New System.Drawing.Point(1546, 1181)
        Me.btn_query_7.Name = "btn_query_7"
        Me.btn_query_7.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_7.TabIndex = 31
        Me.btn_query_7.Text = "bester Kunde (Umsatzvolumen)"
        Me.btn_query_7.UseVisualStyleBackColor = False
        '
        'btn_query_6
        '
        Me.btn_query_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_6.Location = New System.Drawing.Point(859, 1547)
        Me.btn_query_6.Name = "btn_query_6"
        Me.btn_query_6.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_6.TabIndex = 30
        Me.btn_query_6.Text = "Liste Reservierungen für nächstes Event"
        Me.btn_query_6.UseVisualStyleBackColor = False
        '
        'btn_query_5
        '
        Me.btn_query_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_5.Location = New System.Drawing.Point(859, 1366)
        Me.btn_query_5.Name = "btn_query_5"
        Me.btn_query_5.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_5.TabIndex = 29
        Me.btn_query_5.Text = "Anzahl Showacts pro Veranstaltung"
        Me.btn_query_5.UseVisualStyleBackColor = False
        '
        'btn_query_4
        '
        Me.btn_query_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_4.Location = New System.Drawing.Point(859, 1180)
        Me.btn_query_4.Name = "btn_query_4"
        Me.btn_query_4.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_4.TabIndex = 28
        Me.btn_query_4.Text = "Sponsor mit höchstem Sponsoringvolumen"
        Me.btn_query_4.UseVisualStyleBackColor = False
        '
        'btn_query_3
        '
        Me.btn_query_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_3.Location = New System.Drawing.Point(179, 1546)
        Me.btn_query_3.Name = "btn_query_3"
        Me.btn_query_3.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_3.TabIndex = 27
        Me.btn_query_3.Text = "Alle Vollzeitmitarbeiter"
        Me.btn_query_3.UseVisualStyleBackColor = False
        '
        'btn_query_2
        '
        Me.btn_query_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_2.Location = New System.Drawing.Point(179, 1367)
        Me.btn_query_2.Name = "btn_query_2"
        Me.btn_query_2.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_2.TabIndex = 26
        Me.btn_query_2.Text = "Sponsoren die mehr als 2-mal gespendet haben"
        Me.btn_query_2.UseVisualStyleBackColor = False
        '
        'btn_query_1
        '
        Me.btn_query_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btn_query_1.Location = New System.Drawing.Point(179, 1181)
        Me.btn_query_1.Name = "btn_query_1"
        Me.btn_query_1.Size = New System.Drawing.Size(585, 97)
        Me.btn_query_1.TabIndex = 25
        Me.btn_query_1.Text = "Liste aller vergangenen Events"
        Me.btn_query_1.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(3168, 1712)
        Me.Controls.Add(Me.dgv_ergebnis_query)
        Me.Controls.Add(Me.btn_abfrage_start)
        Me.Controls.Add(Me.rtb_sql)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_query_12)
        Me.Controls.Add(Me.btn_query_11)
        Me.Controls.Add(Me.btn_query_10)
        Me.Controls.Add(Me.btn_query_9)
        Me.Controls.Add(Me.btn_query_8)
        Me.Controls.Add(Me.btn_query_7)
        Me.Controls.Add(Me.btn_query_6)
        Me.Controls.Add(Me.btn_query_5)
        Me.Controls.Add(Me.btn_query_4)
        Me.Controls.Add(Me.btn_query_3)
        Me.Controls.Add(Me.btn_query_2)
        Me.Controls.Add(Me.btn_query_1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Standard-und Benutzerabfragen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_ergebnis_query, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_ergebnis_query As DataGridView
    Friend WithEvents btn_abfrage_start As Button
    Friend WithEvents rtb_sql As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_query_12 As Button
    Friend WithEvents btn_query_11 As Button
    Friend WithEvents btn_query_10 As Button
    Friend WithEvents btn_query_9 As Button
    Friend WithEvents btn_query_8 As Button
    Friend WithEvents btn_query_7 As Button
    Friend WithEvents btn_query_6 As Button
    Friend WithEvents btn_query_5 As Button
    Friend WithEvents btn_query_4 As Button
    Friend WithEvents btn_query_3 As Button
    Friend WithEvents btn_query_2 As Button
    Friend WithEvents btn_query_1 As Button
End Class
