Public Class Form7
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

    Dim con_server As String = Me.con_server
    Dim con_db As String = Me.con_db

    Private Sub btn_query_1_Click(sender As Object, e As EventArgs) Handles btn_query_1.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vd_veranst_name AS Veranstaltung, vd_veranst_von AS Anfangstermin, vd_veranst_bis AS Endtermin
                             FROM Veranstaltungen_Daten
                             WHERE GETDATE() > Veranstaltungen_Daten.vd_veranst_von And GETDATE() > Veranstaltungen_Daten.vd_veranst_bis"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_1")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_1"
        dgv_ergebnis_query.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

    End Sub

    Private Sub btn_query_2_Click(sender As Object, e As EventArgs) Handles btn_query_2.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vsn_sponsoren_name as Sponsor, Count(vsp_sponsoren_ID) As #Spenden
	                         From Veranstaltungen_Sponsoren_namen INNER Join Veranstaltungen_Sponsoren On vsn_sponsoren_ID = vsp_sponsoren_ID
	                         Group By vsn_sponsoren_name, vsp_sponsoren_ID
                             HAVING Count(vsp_sponsoren_ID) > 2"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_2"
    End Sub

    Private Sub btn_query_3_Click(sender As Object, e As EventArgs) Handles btn_query_3.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT mad_mitarbeiter_ID AS Personalnummer, mad_mitarbeiter_vname AS Vorname, mad_mitarbeiter_nname AS Nachname
                             FROM Mitarbeiter_Daten
                             WHERE mad_mitarbeiter_stunden LIKE '[0-9][0-9]h' AND mad_mitarbeiter_stunden > '39h'"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_3")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_3"
    End Sub

    Private Sub btn_query_4_Click(sender As Object, e As EventArgs) Handles btn_query_4.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT Sponsor, MAX(Sponsoringvolumen) AS Sponsoringvolumen
                             FROM Sponsoringvolumentabelle
                             WHERE Sponsoringvolumen = (SELECT MAX(Sponsoringvolumen) FROM Sponsoringvolumentabelle)
                             GROUP BY Sponsor"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_4")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_4"
    End Sub

    Private Sub btn_query_5_Click(sender As Object, e As EventArgs) Handles btn_query_5.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vd_veranst_ID AS Veranstaltungsnummer,vd_veranst_name AS Veranstaltung, COUNT(vds_showact_ID) AS #Showacts
                             FROM Veranstaltungen_Daten_Showacts INNER JOIN Veranstaltungen_Daten  ON vds_veranst_ID = vd_veranst_ID
                             GROUP BY vd_veranst_name, vd_veranst_ID 
                             ORDER BY COUNT(vds_showact_ID) ASC"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_5")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_5"
    End Sub

    Private Sub btn_query_6_Click(sender As Object, e As EventArgs) Handles btn_query_6.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT gav_gaeste_ID AS Gästenummer , gad_gaeste_vname AS Vorname,gad_gaeste_nname AS Name,vd_veranst_von AS Veranstaltungsbeginn, vd_veranst_bis AS Veranstaltungsende,vd_veranst_name AS Veranstaltungsname
                             FROM (Gaeste_Aussteller_Veranstaltungen gav 
                                inner join Gaeste_Aussteller_Daten gad ON gav.gav_gaeste_ID = gad.gad_gaeste_ID) 
                                inner join Veranstaltungen_Daten vd ON gav.gav_veranst_ID = vd.vd_veranst_ID
                             WHERE gav_veranst_ID = 	(	SELECT Veranstaltungsnummer
							                                FROM nächste_Veranstaltung
							                                WHERE  Veranstaltungsbeginn = (SELECT MIN(Veranstaltungsbeginn) FROM nächste_Veranstaltung))"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_6")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_6"
    End Sub

    Private Sub btn_query_7_Click(sender As Object, e As EventArgs) Handles btn_query_7.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vaa_auftraggeber_name AS Kunde
                             FROM Veranstaltungen_Auftraggeber INNER JOIN Einnahmen ON vaa_auftraggeber_ID = Auftraggeber_E
                             WHERE Summe_E = (SELECT MAX(Summe_E) FROM Einnahmen)"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_7")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_7"
    End Sub

    Private Sub btn_query_8_Click(sender As Object, e As EventArgs) Handles btn_query_8.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT AVG(Besucheranzahl) AS durchschnittliche_Besucheranzahl
                             FROM Besucheranzahl"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_8")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_8"
    End Sub

    Private Sub btn_query_9_Click(sender As Object, e As EventArgs) Handles btn_query_9.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT DISTINCT  mad_mitarbeiter_ID AS Mitarbeiternummmer,mad_mitarbeiter_vname AS Vorname, mad_mitarbeiter_nname AS Nachname
                             FROM (Mitarbeiter_Daten md 
	                            INNER JOIN Mitarbeiter_Veranstaltungen mv 
	                            ON md.mad_mitarbeiter_ID = mv.mav_mitarbeiter_ID)
	                            INNER JOIN Gaeste_Aussteller_Veranstaltungen gav
	                            ON mv.mav_veranst_ID = gav.gav_veranst_ID
	                            INNER JOIN Gaeste_Aussteller_Daten gad
	                            ON gav.gav_gaeste_ID = gad.gad_gaeste_ID
                             WHERE gad.gad_gaeste_vip = 'Ja'"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_9")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_9"
    End Sub

    Private Sub btn_query_10_Click(sender As Object, e As EventArgs) Handles btn_query_10.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vag.vaa_auftraggeber_name AS Kunde
                             FROM (Einnahmen e inner join Ausgaben a ON e.Auftraggeber_E = a.Auftraggeber)inner join Veranstaltungen_Auftraggeber vag ON e.Auftraggeber_E= vag.vaa_auftraggeber_ID
                             WHERE Summe_E - Summe = (SELECT MAX(Summe_E - Summe) FROM Einnahmen e inner join Ausgaben a ON e.Auftraggeber_E = a.Auftraggeber)"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_10")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_10"
    End Sub

    Private Sub btn_query_11_Click(sender As Object, e As EventArgs) Handles btn_query_11.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT vd_veranst_ID AS VeranstaltungsID, vd_veranst_name AS Veranstaltung
                             FROM Veranstaltungen_Daten
                             WHERE vd_veranst_name like '%konzert%' Or vd_veranst_info like '%konzert%' And vd_veranst_ID not in (SELECT vds_veranst_ID FROM Veranstaltungen_Daten_Showacts )"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_11")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_11"
    End Sub

    Private Sub btn_query_12_Click(sender As Object, e As EventArgs) Handles btn_query_12.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT lfdd_lieferanten_name AS Lieferant_Dienstleister, vd_veranst_name AS Veranstaltung
                             FROM (Lieferanten_Dienstleister_Daten FULL JOIN Lieferanten_Veranstaltungen ON lfdd_lieferanten_ID = lv_lieferanten_ID) LEFT OUTER JOIN Veranstaltungen_Daten ON lv_veranst_ID = vd_veranst_ID"
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_12")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_12"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rtb_sql.Visible = True
        btn_abfrage_start.Visible = True
        rtb_sql.Text = "SELECT" & vbCrLf & "FROM"

    End Sub

    Private Sub btn_abfrage_start_Click(sender As Object, e As EventArgs) Handles btn_abfrage_start.Click
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = rtb_sql.Text
        Dim ds As New DataSet

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Query_user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        con.Dispose()
        dgv_ergebnis_query.DataSource = ds
        dgv_ergebnis_query.DataMember = "Query_user"
    End Sub


End Class