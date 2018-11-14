<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.dgv_ma_veranstaltungem = New System.Windows.Forms.DataGridView()
        Me.com_bx_ma_pos_name = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_monats = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_jahresg = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_enddate = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_startdate = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_arbeitszeit = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_pos_ID = New System.Windows.Forms.ComboBox()
        Me.com_bx_nname = New System.Windows.Forms.ComboBox()
        Me.com_bx_ma_vname = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Monatsgehalt = New System.Windows.Forms.Label()
        Me.lbl_Jahresgehalt = New System.Windows.Forms.Label()
        Me.lbl_Austtrittsdatum = New System.Windows.Forms.Label()
        Me.lbl_Eintrittsdatum = New System.Windows.Forms.Label()
        Me.lbl_Arbeitszeit = New System.Windows.Forms.Label()
        Me.lbl_Nachname = New System.Windows.Forms.Label()
        Me.lbl_Vorname = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.co_bx_ma_ID = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_Positio_ID = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ma_veranstaltungem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_ma_veranstaltungem
        '
        Me.dgv_ma_veranstaltungem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ma_veranstaltungem.Location = New System.Drawing.Point(478, 1282)
        Me.dgv_ma_veranstaltungem.Name = "dgv_ma_veranstaltungem"
        Me.dgv_ma_veranstaltungem.RowTemplate.Height = 40
        Me.dgv_ma_veranstaltungem.Size = New System.Drawing.Size(946, 209)
        Me.dgv_ma_veranstaltungem.TabIndex = 22
        '
        'com_bx_ma_pos_name
        '
        Me.com_bx_ma_pos_name.FormattingEnabled = True
        Me.com_bx_ma_pos_name.Location = New System.Drawing.Point(804, 530)
        Me.com_bx_ma_pos_name.Name = "com_bx_ma_pos_name"
        Me.com_bx_ma_pos_name.Size = New System.Drawing.Size(424, 45)
        Me.com_bx_ma_pos_name.TabIndex = 21
        '
        'com_bx_ma_monats
        '
        Me.com_bx_ma_monats.FormattingEnabled = True
        Me.com_bx_ma_monats.Location = New System.Drawing.Point(478, 1146)
        Me.com_bx_ma_monats.Name = "com_bx_ma_monats"
        Me.com_bx_ma_monats.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_monats.TabIndex = 19
        '
        'com_bx_ma_jahresg
        '
        Me.com_bx_ma_jahresg.FormattingEnabled = True
        Me.com_bx_ma_jahresg.Location = New System.Drawing.Point(478, 1027)
        Me.com_bx_ma_jahresg.Name = "com_bx_ma_jahresg"
        Me.com_bx_ma_jahresg.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_jahresg.TabIndex = 18
        '
        'com_bx_ma_enddate
        '
        Me.com_bx_ma_enddate.FormattingEnabled = True
        Me.com_bx_ma_enddate.Location = New System.Drawing.Point(478, 901)
        Me.com_bx_ma_enddate.Name = "com_bx_ma_enddate"
        Me.com_bx_ma_enddate.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_enddate.TabIndex = 17
        '
        'com_bx_ma_startdate
        '
        Me.com_bx_ma_startdate.FormattingEnabled = True
        Me.com_bx_ma_startdate.Location = New System.Drawing.Point(478, 777)
        Me.com_bx_ma_startdate.Name = "com_bx_ma_startdate"
        Me.com_bx_ma_startdate.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_startdate.TabIndex = 16
        '
        'com_bx_ma_arbeitszeit
        '
        Me.com_bx_ma_arbeitszeit.FormattingEnabled = True
        Me.com_bx_ma_arbeitszeit.Location = New System.Drawing.Point(478, 656)
        Me.com_bx_ma_arbeitszeit.Name = "com_bx_ma_arbeitszeit"
        Me.com_bx_ma_arbeitszeit.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_arbeitszeit.TabIndex = 15
        '
        'com_bx_ma_pos_ID
        '
        Me.com_bx_ma_pos_ID.FormattingEnabled = True
        Me.com_bx_ma_pos_ID.Location = New System.Drawing.Point(478, 529)
        Me.com_bx_ma_pos_ID.Name = "com_bx_ma_pos_ID"
        Me.com_bx_ma_pos_ID.Size = New System.Drawing.Size(256, 45)
        Me.com_bx_ma_pos_ID.TabIndex = 14
        '
        'com_bx_nname
        '
        Me.com_bx_nname.FormattingEnabled = True
        Me.com_bx_nname.Location = New System.Drawing.Point(478, 408)
        Me.com_bx_nname.Name = "com_bx_nname"
        Me.com_bx_nname.Size = New System.Drawing.Size(424, 45)
        Me.com_bx_nname.TabIndex = 13
        '
        'com_bx_ma_vname
        '
        Me.com_bx_ma_vname.FormattingEnabled = True
        Me.com_bx_ma_vname.Location = New System.Drawing.Point(478, 285)
        Me.com_bx_ma_vname.Name = "com_bx_ma_vname"
        Me.com_bx_ma_vname.Size = New System.Drawing.Size(424, 45)
        Me.com_bx_ma_vname.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 1269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 54)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Veranstaltungen:"
        '
        'lbl_Monatsgehalt
        '
        Me.lbl_Monatsgehalt.AutoSize = True
        Me.lbl_Monatsgehalt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Monatsgehalt.Location = New System.Drawing.Point(71, 1137)
        Me.lbl_Monatsgehalt.Name = "lbl_Monatsgehalt"
        Me.lbl_Monatsgehalt.Size = New System.Drawing.Size(277, 54)
        Me.lbl_Monatsgehalt.TabIndex = 10
        Me.lbl_Monatsgehalt.Text = "Monatsgehalt:"
        '
        'lbl_Jahresgehalt
        '
        Me.lbl_Jahresgehalt.AutoSize = True
        Me.lbl_Jahresgehalt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Jahresgehalt.Location = New System.Drawing.Point(71, 1018)
        Me.lbl_Jahresgehalt.Name = "lbl_Jahresgehalt"
        Me.lbl_Jahresgehalt.Size = New System.Drawing.Size(253, 54)
        Me.lbl_Jahresgehalt.TabIndex = 9
        Me.lbl_Jahresgehalt.Text = "Jahresgehalt:"
        '
        'lbl_Austtrittsdatum
        '
        Me.lbl_Austtrittsdatum.AutoSize = True
        Me.lbl_Austtrittsdatum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Austtrittsdatum.Location = New System.Drawing.Point(71, 892)
        Me.lbl_Austtrittsdatum.Name = "lbl_Austtrittsdatum"
        Me.lbl_Austtrittsdatum.Size = New System.Drawing.Size(296, 54)
        Me.lbl_Austtrittsdatum.TabIndex = 8
        Me.lbl_Austtrittsdatum.Text = "Austrittsdatum:"
        '
        'lbl_Eintrittsdatum
        '
        Me.lbl_Eintrittsdatum.AutoSize = True
        Me.lbl_Eintrittsdatum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Eintrittsdatum.Location = New System.Drawing.Point(71, 768)
        Me.lbl_Eintrittsdatum.Name = "lbl_Eintrittsdatum"
        Me.lbl_Eintrittsdatum.Size = New System.Drawing.Size(283, 54)
        Me.lbl_Eintrittsdatum.TabIndex = 7
        Me.lbl_Eintrittsdatum.Text = "Eintrittsdatum:"
        '
        'lbl_Arbeitszeit
        '
        Me.lbl_Arbeitszeit.AutoSize = True
        Me.lbl_Arbeitszeit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Arbeitszeit.Location = New System.Drawing.Point(71, 647)
        Me.lbl_Arbeitszeit.Name = "lbl_Arbeitszeit"
        Me.lbl_Arbeitszeit.Size = New System.Drawing.Size(221, 54)
        Me.lbl_Arbeitszeit.TabIndex = 6
        Me.lbl_Arbeitszeit.Text = "Arbeitszeit:"
        '
        'lbl_Nachname
        '
        Me.lbl_Nachname.AutoSize = True
        Me.lbl_Nachname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nachname.Location = New System.Drawing.Point(71, 399)
        Me.lbl_Nachname.Name = "lbl_Nachname"
        Me.lbl_Nachname.Size = New System.Drawing.Size(221, 54)
        Me.lbl_Nachname.TabIndex = 4
        Me.lbl_Nachname.Text = "Nachname:"
        '
        'lbl_Vorname
        '
        Me.lbl_Vorname.AutoSize = True
        Me.lbl_Vorname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Vorname.Location = New System.Drawing.Point(71, 276)
        Me.lbl_Vorname.Name = "lbl_Vorname"
        Me.lbl_Vorname.Size = New System.Drawing.Size(189, 54)
        Me.lbl_Vorname.TabIndex = 3
        Me.lbl_Vorname.Text = "Vorname:"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(71, 153)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(280, 54)
        Me.ID.TabIndex = 2
        Me.ID.Text = "Mitarbeiter ID:"
        '
        'co_bx_ma_ID
        '
        Me.co_bx_ma_ID.FormattingEnabled = True
        Me.co_bx_ma_ID.Location = New System.Drawing.Point(478, 162)
        Me.co_bx_ma_ID.Name = "co_bx_ma_ID"
        Me.co_bx_ma_ID.Size = New System.Drawing.Size(256, 45)
        Me.co_bx_ma_ID.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2129, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 926)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.dgv_ma_veranstaltungem)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_pos_name)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_monats)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_jahresg)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_enddate)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_startdate)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_arbeitszeit)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_pos_ID)
        Me.TabPage1.Controls.Add(Me.com_bx_nname)
        Me.TabPage1.Controls.Add(Me.com_bx_ma_vname)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lbl_Monatsgehalt)
        Me.TabPage1.Controls.Add(Me.lbl_Jahresgehalt)
        Me.TabPage1.Controls.Add(Me.lbl_Austtrittsdatum)
        Me.TabPage1.Controls.Add(Me.lbl_Eintrittsdatum)
        Me.TabPage1.Controls.Add(Me.lbl_Arbeitszeit)
        Me.TabPage1.Controls.Add(Me.lbl_Positio_ID)
        Me.TabPage1.Controls.Add(Me.lbl_Nachname)
        Me.TabPage1.Controls.Add(Me.lbl_Vorname)
        Me.TabPage1.Controls.Add(Me.ID)
        Me.TabPage1.Controls.Add(Me.co_bx_ma_ID)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(10, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daniela Hoffmann"
        '
        'lbl_Positio_ID
        '
        Me.lbl_Positio_ID.AutoSize = True
        Me.lbl_Positio_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Positio_ID.Location = New System.Drawing.Point(71, 520)
        Me.lbl_Positio_ID.Name = "lbl_Positio_ID"
        Me.lbl_Positio_ID.Size = New System.Drawing.Size(223, 54)
        Me.lbl_Positio_ID.TabIndex = 5
        Me.lbl_Positio_ID.Text = "Position ID:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Location = New System.Drawing.Point(10, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Danilo Hoffmann"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Location = New System.Drawing.Point(10, 48)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gustav Richter"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Location = New System.Drawing.Point(10, 48)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Janina Hagenreiter"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage5.Location = New System.Drawing.Point(10, 48)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Mareike Adam"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage6.Location = New System.Drawing.Point(10, 48)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Nadine Reimer"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage7.Location = New System.Drawing.Point(10, 48)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Paula Schmidt"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage8.Location = New System.Drawing.Point(10, 48)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Peggy Richter"
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage9.Location = New System.Drawing.Point(10, 48)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(2996, 1530)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Volker Reinhardt"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Location = New System.Drawing.Point(78, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(3016, 1588)
        Me.TabControl1.TabIndex = 1
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(3172, 1716)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ma_veranstaltungem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents dgv_ma_veranstaltungem As DataGridView
    Friend WithEvents com_bx_ma_pos_name As ComboBox
    Friend WithEvents com_bx_ma_monats As ComboBox
    Friend WithEvents com_bx_ma_jahresg As ComboBox
    Friend WithEvents com_bx_ma_enddate As ComboBox
    Friend WithEvents com_bx_ma_startdate As ComboBox
    Friend WithEvents com_bx_ma_arbeitszeit As ComboBox
    Friend WithEvents com_bx_ma_pos_ID As ComboBox
    Friend WithEvents com_bx_nname As ComboBox
    Friend WithEvents com_bx_ma_vname As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Monatsgehalt As Label
    Friend WithEvents lbl_Jahresgehalt As Label
    Friend WithEvents lbl_Austtrittsdatum As Label
    Friend WithEvents lbl_Eintrittsdatum As Label
    Friend WithEvents lbl_Arbeitszeit As Label
    Friend WithEvents lbl_Nachname As Label
    Friend WithEvents lbl_Vorname As Label
    Friend WithEvents ID As Label
    Friend WithEvents co_bx_ma_ID As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl_Positio_ID As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabControl1 As TabControl
End Class
