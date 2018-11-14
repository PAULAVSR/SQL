Public Class Form2
    Public Property Server() As String
        Get
            Return con_server
        End Get
        Set(ByVal value As String)
            con_server = value
        End Set
    End Property

    Public Property DB() As String
        Get
            Return con_db
        End Get
        Set(ByVal value As String)
            con_db = value
        End Set
    End Property
    Dim zaehler As Integer = 1
    Dim upperbound As UInteger = 1
    Dim con_server As String = Me.con_server
    Dim con_db As String = Me.con_db

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        com_bx_veranstname.Text = ""
        com_bx_veranstname.Items.Clear()
        txt_bx_startdate.Clear()
        txt_bx_enddate.Clear()
        txt_bx_veranstinfo.Clear()
        com_bx_auftraggeber.Items.Clear()
        com_bx_auftraggeber.Text = ""
        com_bx_auftraggebername.Text = ""
        com_bx_auftraggebername.Items.Clear()
        com_bx_showveranstnr.Items.Clear()
        com_bx_showactnummer.Items.Clear()
        com_bx_showactnummer.Text = ""
        txt_bx_showactnamentitel.Text = ""
        txt_bx_showactvname.Text = ""
        txt_bx_showactname.Text = ""
        txt_bx_showactfirma.Text = ""
        com_bx_showactkategorieid.Items.Clear()
        com_bx_showactkategorieid.Text = ""
        com_bx_shoactkategoriename.Items.Clear()
        com_bx_shoactkategoriename.Text = ""
        com_bx_veranststandortid.Items.Clear()
        com_bx_veranststandortid.Text = ""
        com_bx_veranststandortname.Items.Clear()
        com_bx_veranststandortname.Text = ""
        com_bx_veranstortid.Items.Clear()
        com_bx_veranstortid.Text = ""
        com_bx_veranstaltungsortname.Items.Clear()
        com_bx_veranstaltungsortname.Text = ""
        txt_bx_veranstortinfo.Text = ""
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"

        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vd_veranst_ID from Veranstaltungen_Daten"
        Dim ds As New DataSet


        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim arr As New List(Of Integer)
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_veranstnr.Items.Add(dr("vd_veranst_ID").ToString)
                arr.Add(dr("vd_veranst_ID").ToString)
            Next
            zaehler = arr.Max + 1
            com_bx_veranstnr.Items.Add(zaehler)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        com_bx_veranstnr.SelectedText = zaehler.ToString()

        sql = "Select vs_showact_ID, vs_titel, vs_vorname, vs_name, vs_firma, vds_veranst_ID from Veranstaltungen_Showacts inner join Veranstaltungen_Daten_Showacts on vs_showact_ID = vds_showact_ID"

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand


            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable

            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            Dim arrlist As New List(Of Integer)
            For Each dr In dt.Rows

                'com_bx_showactnummer.Items.Add(dr("vs_showact_ID").ToString)
                'com_bx_titel.Items.Add(dr("vs_titel").ToString)
                'com_bx_showactvname.Items.Add(dr("vs_vorname").ToString)
                'com_bx_showactname.Items.Add(dr("vs_name").ToString)
                'com_bx_showactfirma.Items.Add(dr("vs_firma").ToString)
                'com_bx_showveranstnr.Items.Add(dr("vds_veranst_ID").ToString)
                arrlist.Add(dr("vds_veranst_ID").ToString)
            Next

            Dim upperbound As UInteger = arrlist.Max
            com_bx_showveranstnr.Items.Add(zaehler.ToString)
            com_bx_showveranstnr.Text = zaehler.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        Sys.Text = Environment.MachineName

    End Sub

    Private Sub com_bx_veranstnr_SelectedValueChanged(sender As Object, e As EventArgs) Handles com_bx_veranstnr.SelectedValueChanged

        com_bx_veranstname.Text = ""
        com_bx_veranstname.Items.Clear()
        txt_bx_startdate.Clear()
        txt_bx_enddate.Clear()
        txt_bx_veranstinfo.Clear()
        com_bx_auftraggeber.Items.Clear()
        com_bx_auftraggeber.Text = ""
        com_bx_auftraggebername.Text = ""
        com_bx_auftraggebername.Items.Clear()
        com_bx_showveranstnr.Items.Clear()
        com_bx_showactnummer.Items.Clear()
        com_bx_showactnummer.Text = ""
        txt_bx_showactnamentitel.Text = ""
        txt_bx_showactvname.Text = ""
        txt_bx_showactname.Text = ""
        txt_bx_showactfirma.Text = ""
        com_bx_showactkategorieid.Items.Clear()
        com_bx_showactkategorieid.Text = ""
        com_bx_shoactkategoriename.Items.Clear()
        com_bx_shoactkategoriename.Text = ""
        com_bx_veranststandortid.Items.Clear()
        com_bx_veranststandortid.Text = ""
        com_bx_veranststandortname.Items.Clear()
        com_bx_veranststandortname.Text = ""
        com_bx_veranstortid.Items.Clear()
        com_bx_veranstortid.Text = ""
        com_bx_veranstaltungsortname.Items.Clear()
        com_bx_veranstaltungsortname.Text = ""
        txt_bx_veranstortinfo.Text = ""


        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim sql As String = "SELECT vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis from Veranstaltungen_Daten where vd_veranst_ID = " & veranstnr & ""
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_veranstname.Text = dr("vd_veranst_name").ToString
                txt_bx_veranstinfo.Text = dr("vd_veranst_info").ToString
                txt_bx_startdate.Text = dr("vd_veranst_von")
                txt_bx_enddate.Text = dr("vd_veranst_bis")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "SELECT vd_veranst_auftraggeber,vaa_auftraggeber_name from Veranstaltungen_Daten inner join Veranstaltungen_Auftraggeber on vd_veranst_auftraggeber = vaa_auftraggeber_ID where vd_veranst_ID = " & veranstnr & ""


        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_auftraggeber.Text = dr("vd_veranst_auftraggeber")
                com_bx_auftraggebername.Text = dr("vaa_auftraggeber_name")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "SELECT vds_showact_ID from Veranstaltungen_Daten_Showacts where vds_veranst_ID = " & veranstnr & ""
        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_showactnummer.Items.Add(dr("vds_showact_ID").ToString)
            Next
            com_bx_showveranstnr.Items.Add(com_bx_veranstnr.SelectedItem.ToString)
            com_bx_showveranstnr.Text = com_bx_veranstnr.SelectedItem.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "SELECT vd_veranst_ort_ID, vo_standort_ID, vo_ort_name, vo_ort_info, vos_standort_name from (Veranstaltungen_Daten inner join Veranstaltungen_Ort on vd_veranst_ort_ID = vo_ort_ID) inner join Veranstaltungen_Ort_Standort on vo_standort_ID = vos_standort_ID where vd_veranst_ID = " & veranstnr & ""
        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)

            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_veranststandortid.Items.Add(dr("vo_standort_ID").ToString)
                com_bx_veranststandortid.Text = dr("vo_standort_ID").ToString
                com_bx_veranststandortname.Items.Add(dr("vos_standort_name").ToString)
                com_bx_veranststandortname.Text = dr("vos_standort_name").ToString
                com_bx_veranstortid.Items.Add(dr("vd_veranst_ort_ID").ToString)
                com_bx_veranstortid.Text = dr("vd_veranst_ort_ID").ToString
                com_bx_veranstaltungsortname.Items.Add(dr("vo_ort_name").ToString)
                com_bx_veranstaltungsortname.Text = dr("vo_ort_name").ToString
                txt_bx_veranstortinfo.Text = dr("vo_ort_info").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try


        '////Catch if number not equal to database member


        If com_bx_veranstnr.Text = zaehler.ToString Then

            sql = "SELECT vaa_auftraggeber_ID,vaa_auftraggeber_name from Veranstaltungen_Auftraggeber"


            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow
                For Each dr In dt.Rows
                    com_bx_auftraggeber.Items.Add(dr("vaa_auftraggeber_ID").ToString)
                    com_bx_auftraggebername.Items.Add(dr("vaa_auftraggeber_name").ToString)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try


            sql = "SELECT vsk_kategorie_ID, vsk_kategorie_name from Veranstaltungen_Showact_Kategorie"

            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Dim arrlist As New List(Of UInteger)
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow
                For Each dr In dt.Rows
                    com_bx_showactkategorieid.Items.Add(dr("vsk_kategorie_ID").ToString)
                    com_bx_shoactkategoriename.Items.Add(dr("vsk_kategorie_name").ToString)

                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try

            sql = "Select vs_showact_ID from Veranstaltungen_Showacts "
            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Dim arrlist As New List(Of UInteger)
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow
                For Each dr In dt.Rows
                    com_bx_showactnummer.Items.Add(dr("vs_showact_ID").ToString)
                    arrlist.Add(dr("vs_showact_ID"))
                Next
                upperbound = arrlist.Max
                upperbound += 1
                com_bx_showactnummer.Items.Add(upperbound)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try

            sql = "SELECT  vos_standort_ID,vos_standort_name from Veranstaltungen_Ort_Standort"
            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()


                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow
                For Each dr In dt.Rows
                    com_bx_veranststandortid.Items.Add(dr("vos_standort_ID").ToString)

                    com_bx_veranststandortname.Items.Add(dr("vos_standort_name").ToString)



                    'txt_bx_veranstortinfo.Text = dr("vo_ort_info").ToString
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try

            sql = "Select  vo_ort_ID, vo_ort_name from Veranstaltungen_Ort"
            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()


                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow

                For Each dr In dt.Rows
                    com_bx_veranstortid.Items.Add(dr("vo_ort_ID").ToString)
                    com_bx_veranstaltungsortname.Items.Add(dr("vo_ort_name").ToString)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try


        End If

    End Sub
    Private Sub com_bx_showactnummer_SelectedValueChanged(sender As Object, e As EventArgs) Handles com_bx_showactnummer.SelectedValueChanged

        txt_bx_showactnamentitel.Text = ""
        txt_bx_showactvname.Text = ""
        txt_bx_showactname.Text = ""
        txt_bx_showactfirma.Text = ""
        com_bx_showactkategorieid.Items.Clear()
        com_bx_showactkategorieid.Text = ""
        com_bx_shoactkategoriename.Items.Clear()
        com_bx_shoactkategoriename.Text = ""



        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim shownr As String = com_bx_showactnummer.SelectedItem
        Dim sql As String = "SELECT vs_titel,vs_vorname,vs_name,vs_firma,vs_kategorie_ID, vsk_kategorie_name from Veranstaltungen_Showacts, Veranstaltungen_Daten_Showacts, Veranstaltungen_Showact_Kategorie where vs_showact_ID = " & shownr & " and vds_veranst_ID = " & veranstnr & " and vs_kategorie_ID = vsk_kategorie_ID"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                txt_bx_showactnamentitel.Text = dr("vs_titel").ToString
                txt_bx_showactvname.Text = dr("vs_vorname").ToString
                txt_bx_showactname.Text = dr("vs_name").ToString
                txt_bx_showactfirma.Text = dr("vs_firma").ToString
                com_bx_showactkategorieid.Items.Add(dr("vs_kategorie_ID").ToString)
                com_bx_showactkategorieid.Text = dr("vs_kategorie_ID").ToString
                com_bx_shoactkategoriename.Items.Add(dr("vsk_kategorie_name").ToString)
                com_bx_shoactkategoriename.Text = dr("vsk_kategorie_name").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        '//// Case If new dataset

        If com_bx_showveranstnr.Text = zaehler.ToString Then
            sql = "SELECT vs_titel,vs_vorname,vs_name,vs_firma,vs_kategorie_ID, vsk_kategorie_name from Veranstaltungen_Showacts, Veranstaltungen_Daten_Showacts, Veranstaltungen_Showact_Kategorie where vs_showact_ID = " & shownr & " and vs_kategorie_ID = vsk_kategorie_ID"
            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)

                Dim dr As DataRow
                For Each dr In dt.Rows
                    txt_bx_showactnamentitel.Text = dr("vs_titel").ToString
                    txt_bx_showactvname.Text = dr("vs_vorname").ToString
                    txt_bx_showactname.Text = dr("vs_name").ToString
                    txt_bx_showactfirma.Text = dr("vs_firma").ToString
                    com_bx_showactkategorieid.Items.Add(dr("vs_kategorie_ID").ToString)
                    com_bx_showactkategorieid.Text = dr("vs_kategorie_ID").ToString
                    com_bx_shoactkategoriename.Items.Add(dr("vsk_kategorie_name").ToString)
                    com_bx_shoactkategoriename.Text = dr("vsk_kategorie_name").ToString
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_hinzufügen.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim shownr As String = com_bx_showactnummer.SelectedItem
        Dim sql As String
        If com_bx_veranstnr.Text = zaehler Then
            'Case that all inserted exists
            Try
                sql = "Insert into Veranstaltungen_Daten 
                       Values (" & com_bx_veranstnr.Text & ", '" & com_bx_veranstname.Text & "', '" & txt_bx_veranstinfo.Text & "', '" & txt_bx_startdate.Text & "', '" & txt_bx_enddate.Text & "', " & com_bx_veranstortid.Text & " , " & com_bx_auftraggeber.Text & ")"
                MsgBox(sql)
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try

            'Try
            '    sql = "Insert into Veranstaltungen_Ort
            '           Values ( " & com_bx_veranstortid.Text & ", " & com_bx_veranststandortid.Text & ", '" & com_bx_veranstaltungsortname.Text & "', '" & txt_bx_veranstortinfo.Text & "')"

            '    con.Open()
            '    Dim cmd As SqlClient.SqlCommand
            '    cmd = con.CreateCommand
            '    cmd.CommandType = CommandType.Text
            '    cmd.CommandText = sql
            '    cmd.ExecuteNonQuery()

            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'Finally
            '    If con.State <> ConnectionState.Closed Then con.Close()
            'End Try
            MsgBox(upperbound.ToString & " , " & com_bx_showactnummer.Text)
            If com_bx_showveranstnr.Text = zaehler And com_bx_showactnummer.Text = upperbound.ToString Then
                Try
                    sql = "Insert into Veranstaltungen_Showacts
                        Values (" & com_bx_showactnummer.Text & ", '" & txt_bx_showactnamentitel.Text & "', '" & txt_bx_showactvname.Text & "', '" & txt_bx_showactname.Text & "', '" & txt_bx_showactfirma.Text & "', " & com_bx_showactkategorieid.Text & ")"
                    MsgBox(sql)
                    con.Open()
                    Dim cmd As SqlClient.SqlCommand = con.CreateCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If con.State <> ConnectionState.Closed Then con.Close()
                End Try

            End If

            If com_bx_showactnummer.Text <> "" Then
                sql = "Insert into Veranstaltungen_Daten_Showacts
                   Values (" & com_bx_showveranstnr.Text & ", " & com_bx_showactnummer.Text & ")"
                MsgBox(sql)
                Try
                    con.Open()
                    Dim cmd2 As SqlClient.SqlCommand = con.CreateCommand
                    cmd2.CommandType = CommandType.Text
                    cmd2.CommandText = sql
                    cmd2.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If con.State <> ConnectionState.Closed Then con.Close()
                End Try
            End If
            zaehler += 1
            com_bx_veranstnr.Items.Add(zaehler)
        Else : MsgBox("Diese Veranstaltugsnummer existiert bereits in der Datenbank wählen Sie eine neue.")

        End If
    End Sub

    Private Sub com_bx_veranstortid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_bx_veranstortid.SelectedIndexChanged
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim shownr As String = com_bx_showactnummer.SelectedItem
        Dim sql As String = "SELECT vo_ort_name, vo_ort_info from Veranstaltungen_Ort where vo_ort_ID = " & com_bx_veranstortid.Text
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_veranstaltungsortname.Items.Add(dr("vo_ort_name").ToString)
                com_bx_veranstaltungsortname.Text = dr("vo_ort_name").ToString
                txt_bx_veranstortinfo.Text = dr("vo_ort_info")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub btn_add_showactkategorie_Click(sender As Object, e As EventArgs) Handles btn_add_showactkategorie.Click
        com_bx_shoactkategoriename.Text = ""
        Dim Kategorien As New List(Of UInteger)

        For Each element In com_bx_showactkategorieid.Items
            Kategorien.Add(element)
        Next
        Dim bound As Integer = Kategorien.Max + 1
        com_bx_showactkategorieid.Items.Add(bound)
        com_bx_showactkategorieid.Text = bound
        Button4.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim shownr As String = com_bx_showactnummer.SelectedItem
        Dim sql As String

        'Case that all inserted exists
        Try
            sql = "Insert into Veranstaltungen_Showact_Kategorie 
                   Values (" & com_bx_showactkategorieid.Text & ", '" & com_bx_shoactkategoriename.Text & "')"
            MsgBox(sql)
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub com_bx_showactkategorieid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_bx_showactkategorieid.SelectedIndexChanged
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim veranstnr As String = com_bx_veranstnr.Text
        Dim shownr As String = com_bx_showactnummer.SelectedItem
        Dim sql As String = "SELECT vsk_kategorie_name from Veranstaltungen_Showact_Kategorie where vsk_kategorie_ID = " & com_bx_showactkategorieid.Text
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_shoactkategoriename.Items.Add(dr("vsk_kategorie_name").ToString)
                com_bx_shoactkategoriename.Text = dr("vsk_kategorie_name").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub com_bx_veranststandortid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_bx_veranststandortid.SelectedIndexChanged
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vos_standort_name from Veranstaltungen_Ort_Standort where vos_standort_ID = " & com_bx_veranststandortid.Text
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_veranststandortname.Items.Add(dr("vos_standort_name").ToString)
                com_bx_veranststandortname.Text = dr("vos_standort_name").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub btn_add_auftraggeber_Click(sender As Object, e As EventArgs) Handles btn_add_auftraggeber.Click
        com_bx_auftraggebername.Text = ""
        Dim Auftraggeber As New List(Of UInteger)

        For Each element In com_bx_auftraggeber.Items
            Auftraggeber.Add(element)
        Next
        Dim bound As Integer = Auftraggeber.Max + 1
        com_bx_auftraggeber.Items.Add(bound)
        com_bx_auftraggeber.Text = bound
        Button5.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String

        'Case that all inserted exists
        Try
            sql = "Insert into Veranstaltungen_Auftraggeber 
                   Values (" & com_bx_auftraggeber.Text & ", '" & com_bx_auftraggebername.Text & "')"
            MsgBox(sql)
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_löschen.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String


        Try
            sql = "Delete Veranstaltungen_Daten_Showacts 
                   where vds_veranst_ID = " & com_bx_veranstnr.Text

            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        Try
            sql = "Delete Veranstaltungen_Daten 
                   where vd_veranst_ID = " & com_bx_veranstnr.Text

            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        MsgBox("Die Veranstaltungsdetails wurden erfolgreich gelöscht!", Title:="Löschanfrage...")
        com_bx_veranstnr.Text = ""
        Call Form2_Load(sender, e)
    End Sub

    Private Sub btn_ändern_Click(sender As Object, e As EventArgs) Handles btn_ändern.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String
        Dim sicherung As Integer = com_bx_veranstnr.Text

        Try
            sql = "Update Veranstaltungen_Daten
                   Set vd_veranst_ID = " & com_bx_veranstnr.Text & " ,vd_veranst_name = '" & com_bx_veranstname.Text & "' ,vd_veranst_info = '" & txt_bx_veranstinfo.Text & "' ,vd_veranst_von = '" & txt_bx_startdate.Text & "' ,vd_veranst_bis = '" & txt_bx_enddate.Text & "' ,vd_veranst_ort_ID = " & com_bx_veranstortid.Text & ",vd_veranst_auftraggeber = " & com_bx_auftraggeber.Text & " where vd_veranst_ID = " & com_bx_veranstnr.Text

            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        com_bx_veranstnr.SelectedItem = sicherung
    End Sub

    Private Sub com_bx_auftraggeber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_bx_auftraggeber.SelectedIndexChanged
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vaa_auftraggeber_name from Veranstaltungen_Auftraggeber where vaa_auftraggeber_ID = " & com_bx_auftraggeber.Text
        Dim ds As New DataSet

        Try
            con.Open()
            Dim cmd As SqlClient.SqlCommand
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                com_bx_auftraggebername.Items.Add(dr("vaa_auftraggeber_name").ToString)
                com_bx_auftraggebername.Text = dr("vaa_auftraggeber_name").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
    End Sub

    Private Sub com_bx_showactnummer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_bx_showactnummer.SelectedIndexChanged
        If com_bx_showveranstnr.Text = zaehler Then
            Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
            Dim con As New SqlClient.SqlConnection(constring)
            Dim veranstnr As String = com_bx_veranstnr.Text
            Dim shownr As String = com_bx_showactnummer.SelectedItem
            Dim sql As String = "SELECT vsk_kategorie_name, vsk_kategorie_ID from Veranstaltungen_Showact_Kategorie"
            Dim ds As New DataSet

            Try
                con.Open()
                Dim cmd As SqlClient.SqlCommand
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Dim dr As DataRow
                For Each dr In dt.Rows
                    com_bx_shoactkategoriename.Items.Add(dr("vsk_kategorie_name").ToString)
                    com_bx_showactkategorieid.Items.Add(dr("vsk_kategorie_ID").ToString)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State <> ConnectionState.Closed Then con.Close()
            End Try
        End If
    End Sub
End Class