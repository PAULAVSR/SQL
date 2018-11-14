<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.grp_bx_veranstaltungen = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_hinzufügen = New System.Windows.Forms.Button()
        Me.btn_löschen = New System.Windows.Forms.Button()
        Me.btn_ändern = New System.Windows.Forms.Button()
        Me.btn_add_showactkategorie = New System.Windows.Forms.Button()
        Me.btn_add_auftraggeber = New System.Windows.Forms.Button()
        Me.grp_bx_veranstaltungsort = New System.Windows.Forms.GroupBox()
        Me.com_bx_veranstaltungsortname = New System.Windows.Forms.ComboBox()
        Me.com_bx_veranststandortname = New System.Windows.Forms.ComboBox()
        Me.txt_bx_veranstortinfo = New System.Windows.Forms.TextBox()
        Me.com_bx_veranstortid = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.com_bx_veranststandortid = New System.Windows.Forms.ComboBox()
        Me.pnl_veranstaltungsort = New System.Windows.Forms.Panel()
        Me.Veranstaltungen_Showacts = New System.Windows.Forms.GroupBox()
        Me.com_bx_shoactkategoriename = New System.Windows.Forms.ComboBox()
        Me.com_bx_showactkategorieid = New System.Windows.Forms.ComboBox()
        Me.txt_bx_showactfirma = New System.Windows.Forms.TextBox()
        Me.txt_bx_showactname = New System.Windows.Forms.TextBox()
        Me.txt_bx_showactvname = New System.Windows.Forms.TextBox()
        Me.txt_bx_showactnamentitel = New System.Windows.Forms.TextBox()
        Me.com_bx_showveranstnr = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.com_bx_showactnummer = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Veranstaltungen_Daten = New System.Windows.Forms.GroupBox()
        Me.com_bx_auftraggebername = New System.Windows.Forms.ComboBox()
        Me.txt_bx_enddate = New System.Windows.Forms.TextBox()
        Me.txt_bx_startdate = New System.Windows.Forms.TextBox()
        Me.com_bx_auftraggeber = New System.Windows.Forms.ComboBox()
        Me.txt_bx_veranstinfo = New System.Windows.Forms.TextBox()
        Me.com_bx_veranstname = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.com_bx_veranstnr = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Sys = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp_bx_veranstaltungen.SuspendLayout()
        Me.grp_bx_veranstaltungsort.SuspendLayout()
        Me.Veranstaltungen_Showacts.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Veranstaltungen_Daten.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_bx_veranstaltungen
        '
        Me.grp_bx_veranstaltungen.Controls.Add(Me.Button5)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.Button4)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.btn_hinzufügen)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.btn_löschen)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.btn_ändern)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.btn_add_showactkategorie)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.btn_add_auftraggeber)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.grp_bx_veranstaltungsort)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.Veranstaltungen_Showacts)
        Me.grp_bx_veranstaltungen.Controls.Add(Me.Veranstaltungen_Daten)
        Me.grp_bx_veranstaltungen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grp_bx_veranstaltungen.Location = New System.Drawing.Point(79, 49)
        Me.grp_bx_veranstaltungen.Name = "grp_bx_veranstaltungen"
        Me.grp_bx_veranstaltungen.Size = New System.Drawing.Size(3049, 1361)
        Me.grp_bx_veranstaltungen.TabIndex = 0
        Me.grp_bx_veranstaltungen.TabStop = False
        Me.grp_bx_veranstaltungen.Text = "Allgemeine Veranstaltungsdetails"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(1312, 526)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(454, 50)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Auftraggeber hinzufügen"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(1312, 1134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(454, 50)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Showactkategorie hinzufügen"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_hinzufügen
        '
        Me.btn_hinzufügen.Location = New System.Drawing.Point(2133, 871)
        Me.btn_hinzufügen.Name = "btn_hinzufügen"
        Me.btn_hinzufügen.Size = New System.Drawing.Size(403, 93)
        Me.btn_hinzufügen.TabIndex = 27
        Me.btn_hinzufügen.Text = "Hinzufügen"
        Me.btn_hinzufügen.UseVisualStyleBackColor = False
        '
        'btn_löschen
        '
        Me.btn_löschen.Location = New System.Drawing.Point(2133, 715)
        Me.btn_löschen.Name = "btn_löschen"
        Me.btn_löschen.Size = New System.Drawing.Size(403, 93)
        Me.btn_löschen.TabIndex = 26
        Me.btn_löschen.Text = "Löschen"
        Me.btn_löschen.UseVisualStyleBackColor = False
        '
        'btn_ändern
        '
        Me.btn_ändern.Location = New System.Drawing.Point(2133, 556)
        Me.btn_ändern.Name = "btn_ändern"
        Me.btn_ändern.Size = New System.Drawing.Size(403, 93)
        Me.btn_ändern.TabIndex = 25
        Me.btn_ändern.Text = "Ändern"
        Me.btn_ändern.UseVisualStyleBackColor = False
        '
        'btn_add_showactkategorie
        '
        Me.btn_add_showactkategorie.Location = New System.Drawing.Point(1312, 1065)
        Me.btn_add_showactkategorie.Name = "btn_add_showactkategorie"
        Me.btn_add_showactkategorie.Size = New System.Drawing.Size(454, 50)
        Me.btn_add_showactkategorie.TabIndex = 24
        Me.btn_add_showactkategorie.Text = "neue Showactkategorie"
        Me.btn_add_showactkategorie.UseVisualStyleBackColor = False
        '
        'btn_add_auftraggeber
        '
        Me.btn_add_auftraggeber.Location = New System.Drawing.Point(1312, 460)
        Me.btn_add_auftraggeber.Name = "btn_add_auftraggeber"
        Me.btn_add_auftraggeber.Size = New System.Drawing.Size(454, 50)
        Me.btn_add_auftraggeber.TabIndex = 23
        Me.btn_add_auftraggeber.Text = "neuer Auftraggeber"
        Me.btn_add_auftraggeber.UseVisualStyleBackColor = False
        '
        'grp_bx_veranstaltungsort
        '
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.com_bx_veranstaltungsortname)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.com_bx_veranststandortname)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.txt_bx_veranstortinfo)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.com_bx_veranstortid)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.Label16)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.Label17)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.Label18)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.com_bx_veranststandortid)
        Me.grp_bx_veranstaltungsort.Controls.Add(Me.pnl_veranstaltungsort)
        Me.grp_bx_veranstaltungsort.Location = New System.Drawing.Point(1805, 66)
        Me.grp_bx_veranstaltungsort.Name = "grp_bx_veranstaltungsort"
        Me.grp_bx_veranstaltungsort.Size = New System.Drawing.Size(1192, 333)
        Me.grp_bx_veranstaltungsort.TabIndex = 13
        Me.grp_bx_veranstaltungsort.TabStop = False
        '
        'com_bx_veranstaltungsortname
        '
        Me.com_bx_veranstaltungsortname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranstaltungsortname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranstaltungsortname.FormattingEnabled = True
        Me.com_bx_veranstaltungsortname.Location = New System.Drawing.Point(765, 157)
        Me.com_bx_veranstaltungsortname.Name = "com_bx_veranstaltungsortname"
        Me.com_bx_veranstaltungsortname.Size = New System.Drawing.Size(354, 39)
        Me.com_bx_veranstaltungsortname.TabIndex = 11
        '
        'com_bx_veranststandortname
        '
        Me.com_bx_veranststandortname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranststandortname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranststandortname.FormattingEnabled = True
        Me.com_bx_veranststandortname.Location = New System.Drawing.Point(765, 76)
        Me.com_bx_veranststandortname.Name = "com_bx_veranststandortname"
        Me.com_bx_veranststandortname.Size = New System.Drawing.Size(354, 39)
        Me.com_bx_veranststandortname.TabIndex = 10
        '
        'txt_bx_veranstortinfo
        '
        Me.txt_bx_veranstortinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_veranstortinfo.Location = New System.Drawing.Point(492, 231)
        Me.txt_bx_veranstortinfo.Name = "txt_bx_veranstortinfo"
        Me.txt_bx_veranstortinfo.Size = New System.Drawing.Size(627, 38)
        Me.txt_bx_veranstortinfo.TabIndex = 9
        '
        'com_bx_veranstortid
        '
        Me.com_bx_veranstortid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranstortid.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranstortid.FormattingEnabled = True
        Me.com_bx_veranstortid.Location = New System.Drawing.Point(492, 157)
        Me.com_bx_veranstortid.Name = "com_bx_veranstortid"
        Me.com_bx_veranstortid.Size = New System.Drawing.Size(214, 39)
        Me.com_bx_veranstortid.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(421, 32)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Veranstaltungsortinformationen:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(30, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 32)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Veranstaltungsort:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(317, 32)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Veranstaltungsstandort:"
        '
        'com_bx_veranststandortid
        '
        Me.com_bx_veranststandortid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranststandortid.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranststandortid.FormattingEnabled = True
        Me.com_bx_veranststandortid.Location = New System.Drawing.Point(492, 76)
        Me.com_bx_veranststandortid.Name = "com_bx_veranststandortid"
        Me.com_bx_veranststandortid.Size = New System.Drawing.Size(214, 39)
        Me.com_bx_veranststandortid.TabIndex = 0
        '
        'pnl_veranstaltungsort
        '
        Me.pnl_veranstaltungsort.Location = New System.Drawing.Point(21, 48)
        Me.pnl_veranstaltungsort.Name = "pnl_veranstaltungsort"
        Me.pnl_veranstaltungsort.Size = New System.Drawing.Size(438, 260)
        Me.pnl_veranstaltungsort.TabIndex = 7
        '
        'Veranstaltungen_Showacts
        '
        Me.Veranstaltungen_Showacts.Controls.Add(Me.com_bx_shoactkategoriename)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.com_bx_showactkategorieid)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.txt_bx_showactfirma)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.txt_bx_showactname)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.txt_bx_showactvname)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.txt_bx_showactnamentitel)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.com_bx_showveranstnr)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label7)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label8)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label9)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label10)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label11)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Label12)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.com_bx_showactnummer)
        Me.Veranstaltungen_Showacts.Controls.Add(Me.Panel2)
        Me.Veranstaltungen_Showacts.Location = New System.Drawing.Point(70, 617)
        Me.Veranstaltungen_Showacts.Name = "Veranstaltungen_Showacts"
        Me.Veranstaltungen_Showacts.Size = New System.Drawing.Size(1236, 676)
        Me.Veranstaltungen_Showacts.TabIndex = 13
        Me.Veranstaltungen_Showacts.TabStop = False
        '
        'com_bx_shoactkategoriename
        '
        Me.com_bx_shoactkategoriename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.com_bx_shoactkategoriename.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_shoactkategoriename.FormattingEnabled = True
        Me.com_bx_shoactkategoriename.Location = New System.Drawing.Point(661, 459)
        Me.com_bx_shoactkategoriename.Name = "com_bx_shoactkategoriename"
        Me.com_bx_shoactkategoriename.Size = New System.Drawing.Size(480, 39)
        Me.com_bx_shoactkategoriename.TabIndex = 21
        '
        'com_bx_showactkategorieid
        '
        Me.com_bx_showactkategorieid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_showactkategorieid.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_showactkategorieid.FormattingEnabled = True
        Me.com_bx_showactkategorieid.Location = New System.Drawing.Point(492, 459)
        Me.com_bx_showactkategorieid.Name = "com_bx_showactkategorieid"
        Me.com_bx_showactkategorieid.Size = New System.Drawing.Size(147, 39)
        Me.com_bx_showactkategorieid.TabIndex = 20
        '
        'txt_bx_showactfirma
        '
        Me.txt_bx_showactfirma.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_showactfirma.Location = New System.Drawing.Point(492, 388)
        Me.txt_bx_showactfirma.Name = "txt_bx_showactfirma"
        Me.txt_bx_showactfirma.Size = New System.Drawing.Size(476, 38)
        Me.txt_bx_showactfirma.TabIndex = 19
        '
        'txt_bx_showactname
        '
        Me.txt_bx_showactname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_showactname.Location = New System.Drawing.Point(492, 309)
        Me.txt_bx_showactname.Name = "txt_bx_showactname"
        Me.txt_bx_showactname.Size = New System.Drawing.Size(476, 38)
        Me.txt_bx_showactname.TabIndex = 18
        '
        'txt_bx_showactvname
        '
        Me.txt_bx_showactvname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_showactvname.Location = New System.Drawing.Point(492, 231)
        Me.txt_bx_showactvname.Name = "txt_bx_showactvname"
        Me.txt_bx_showactvname.Size = New System.Drawing.Size(476, 38)
        Me.txt_bx_showactvname.TabIndex = 17
        '
        'txt_bx_showactnamentitel
        '
        Me.txt_bx_showactnamentitel.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_showactnamentitel.Location = New System.Drawing.Point(492, 153)
        Me.txt_bx_showactnamentitel.Name = "txt_bx_showactnamentitel"
        Me.txt_bx_showactnamentitel.Size = New System.Drawing.Size(476, 38)
        Me.txt_bx_showactnamentitel.TabIndex = 16
        '
        'com_bx_showveranstnr
        '
        Me.com_bx_showveranstnr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_showveranstnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_showveranstnr.FormattingEnabled = True
        Me.com_bx_showveranstnr.Location = New System.Drawing.Point(492, 543)
        Me.com_bx_showveranstnr.Name = "com_bx_showveranstnr"
        Me.com_bx_showveranstnr.Size = New System.Drawing.Size(147, 39)
        Me.com_bx_showveranstnr.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Showactkategorie:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 32)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Firma:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 32)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 32)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Vorname:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 32)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Titel:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(235, 32)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Showactnummer:"
        '
        'com_bx_showactnummer
        '
        Me.com_bx_showactnummer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_showactnummer.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_showactnummer.FormattingEnabled = True
        Me.com_bx_showactnummer.Location = New System.Drawing.Point(492, 76)
        Me.com_bx_showactnummer.Name = "com_bx_showactnummer"
        Me.com_bx_showactnummer.Size = New System.Drawing.Size(147, 39)
        Me.com_bx_showactnummer.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(21, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 565)
        Me.Panel2.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 502)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(317, 32)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Veranstaltungsnummer:"
        '
        'Veranstaltungen_Daten
        '
        Me.Veranstaltungen_Daten.Controls.Add(Me.com_bx_auftraggebername)
        Me.Veranstaltungen_Daten.Controls.Add(Me.txt_bx_enddate)
        Me.Veranstaltungen_Daten.Controls.Add(Me.txt_bx_startdate)
        Me.Veranstaltungen_Daten.Controls.Add(Me.com_bx_auftraggeber)
        Me.Veranstaltungen_Daten.Controls.Add(Me.txt_bx_veranstinfo)
        Me.Veranstaltungen_Daten.Controls.Add(Me.com_bx_veranstname)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label6)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label5)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label4)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label3)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label2)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Label1)
        Me.Veranstaltungen_Daten.Controls.Add(Me.com_bx_veranstnr)
        Me.Veranstaltungen_Daten.Controls.Add(Me.Panel1)
        Me.Veranstaltungen_Daten.Font = New System.Drawing.Font("Segoe UI", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Veranstaltungen_Daten.Location = New System.Drawing.Point(70, 66)
        Me.Veranstaltungen_Daten.Name = "Veranstaltungen_Daten"
        Me.Veranstaltungen_Daten.Size = New System.Drawing.Size(1236, 520)
        Me.Veranstaltungen_Daten.TabIndex = 1
        Me.Veranstaltungen_Daten.TabStop = False
        '
        'com_bx_auftraggebername
        '
        Me.com_bx_auftraggebername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_auftraggebername.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_auftraggebername.FormattingEnabled = True
        Me.com_bx_auftraggebername.Location = New System.Drawing.Point(730, 459)
        Me.com_bx_auftraggebername.Name = "com_bx_auftraggebername"
        Me.com_bx_auftraggebername.Size = New System.Drawing.Size(480, 45)
        Me.com_bx_auftraggebername.TabIndex = 15
        '
        'txt_bx_enddate
        '
        Me.txt_bx_enddate.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_enddate.Location = New System.Drawing.Point(492, 388)
        Me.txt_bx_enddate.Name = "txt_bx_enddate"
        Me.txt_bx_enddate.Size = New System.Drawing.Size(316, 43)
        Me.txt_bx_enddate.TabIndex = 14
        '
        'txt_bx_startdate
        '
        Me.txt_bx_startdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txt_bx_startdate.Location = New System.Drawing.Point(492, 309)
        Me.txt_bx_startdate.Name = "txt_bx_startdate"
        Me.txt_bx_startdate.Size = New System.Drawing.Size(316, 43)
        Me.txt_bx_startdate.TabIndex = 13
        '
        'com_bx_auftraggeber
        '
        Me.com_bx_auftraggeber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_auftraggeber.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_auftraggeber.FormattingEnabled = True
        Me.com_bx_auftraggeber.Location = New System.Drawing.Point(492, 459)
        Me.com_bx_auftraggeber.Name = "com_bx_auftraggeber"
        Me.com_bx_auftraggeber.Size = New System.Drawing.Size(215, 45)
        Me.com_bx_auftraggeber.TabIndex = 12
        '
        'txt_bx_veranstinfo
        '
        Me.txt_bx_veranstinfo.Location = New System.Drawing.Point(492, 231)
        Me.txt_bx_veranstinfo.Name = "txt_bx_veranstinfo"
        Me.txt_bx_veranstinfo.Size = New System.Drawing.Size(476, 43)
        Me.txt_bx_veranstinfo.TabIndex = 9
        '
        'com_bx_veranstname
        '
        Me.com_bx_veranstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranstname.FormattingEnabled = True
        Me.com_bx_veranstname.Location = New System.Drawing.Point(492, 153)
        Me.com_bx_veranstname.Name = "com_bx_veranstname"
        Me.com_bx_veranstname.Size = New System.Drawing.Size(476, 45)
        Me.com_bx_veranstname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 38)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Auftraggeber:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 38)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enddatum:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Startdatum:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(379, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Veranstaltungsinformationen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Veranstaltungsname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Veranstaltungsnummer:"
        '
        'com_bx_veranstnr
        '
        Me.com_bx_veranstnr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_bx_veranstnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.com_bx_veranstnr.FormattingEnabled = True
        Me.com_bx_veranstnr.Location = New System.Drawing.Point(492, 76)
        Me.com_bx_veranstnr.Name = "com_bx_veranstnr"
        Me.com_bx_veranstnr.Size = New System.Drawing.Size(147, 45)
        Me.com_bx_veranstnr.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(21, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 461)
        Me.Panel1.TabIndex = 7
        '
        'Sys
        '
        Me.Sys.AutoSize = True
        Me.Sys.Location = New System.Drawing.Point(15, 34)
        Me.Sys.Name = "Sys"
        Me.Sys.Size = New System.Drawing.Size(118, 32)
        Me.Sys.TabIndex = 1
        Me.Sys.Text = "Label14"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 32)
        Me.Label14.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Sys)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 1485)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 76)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(3172, 1630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_bx_veranstaltungen)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Import für Veranstaltungsinformationen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_bx_veranstaltungen.ResumeLayout(False)
        Me.grp_bx_veranstaltungsort.ResumeLayout(False)
        Me.grp_bx_veranstaltungsort.PerformLayout()
        Me.Veranstaltungen_Showacts.ResumeLayout(False)
        Me.Veranstaltungen_Showacts.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Veranstaltungen_Daten.ResumeLayout(False)
        Me.Veranstaltungen_Daten.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_bx_veranstaltungen As GroupBox
    Friend WithEvents Veranstaltungen_Daten As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_bx_veranstnr As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents com_bx_auftraggeber As ComboBox
    Friend WithEvents txt_bx_veranstinfo As TextBox
    Friend WithEvents com_bx_veranstname As ComboBox
    Friend WithEvents Veranstaltungen_Showacts As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents com_bx_showactnummer As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grp_bx_veranstaltungsort As GroupBox
    Friend WithEvents txt_bx_veranstortinfo As TextBox
    Friend WithEvents com_bx_veranstortid As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents com_bx_veranststandortid As ComboBox
    Friend WithEvents pnl_veranstaltungsort As Panel
    Friend WithEvents txt_bx_enddate As TextBox
    Friend WithEvents txt_bx_startdate As TextBox
    Friend WithEvents com_bx_auftraggebername As ComboBox
    Friend WithEvents com_bx_showveranstnr As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_bx_showactfirma As TextBox
    Friend WithEvents txt_bx_showactname As TextBox
    Friend WithEvents txt_bx_showactvname As TextBox
    Friend WithEvents txt_bx_showactnamentitel As TextBox
    Friend WithEvents btn_add_showactkategorie As Button
    Friend WithEvents btn_add_auftraggeber As Button
    Friend WithEvents com_bx_shoactkategoriename As ComboBox
    Friend WithEvents com_bx_showactkategorieid As ComboBox
    Friend WithEvents com_bx_veranstaltungsortname As ComboBox
    Friend WithEvents com_bx_veranststandortname As ComboBox
    Friend WithEvents btn_hinzufügen As Button
    Friend WithEvents btn_löschen As Button
    Friend WithEvents btn_ändern As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Sys As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
