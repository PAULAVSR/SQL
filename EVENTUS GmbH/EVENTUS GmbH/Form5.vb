Public Class Mitarbeiterübersicht
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
    Private Sub TabPage1_MouseEnter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT mad_mitarbeiter_ID,mad_mitarbeiter_vname,mad_mitarbeiter_nname,mad_position_ID,mad_mitarbeiter_stunden,mad_mitarbeiter_von,mad_mitarbeiter_bis,mad_mitarbeiter_jahresgehalt,mad_mitarbeiter_monatsgehalt from Mitarbeiter_Daten where mad_mitarbeiter_ID = 3000001"
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
                com_bx_ma_ID.Items.Add(dr("mad_mitarbeiter_ID").ToString)
                com_bx_ma_ID.Text = dr("mad_mitarbeiter_ID").ToString
                com_bx_ma_vname.Items.Add(dr("mad_mitarbeiter_vname"))
                com_bx_ma_vname.Text = dr("mad_mitarbeiter_vname")
                com_bx_nname.Items.Add(dr("mad_mitarbeiter_nname"))
                com_bx_nname.Text = dr("mad_mitarbeiter_nname")
                com_bx_ma_pos_ID.Items.Add(dr("mad_position_ID").ToString)
                com_bx_ma_pos_ID.Text = dr("mad_position_ID").ToString
                com_bx_ma_arbeitszeit.Items.Add(dr("mad_mitarbeiter_stunden").ToString)
                com_bx_ma_arbeitszeit.Text = dr("mad_mitarbeiter_stunden").ToString
                com_bx_ma_startdate.Items.Add(dr("mad_mitarbeiter_von"))
                com_bx_ma_startdate.Text = dr("mad_mitarbeiter_von")
                com_bx_ma_enddate.Items.Add(dr("mad_mitarbeiter_bis"))
                com_bx_ma_enddate.Text = dr("mad_mitarbeiter_bis")
                com_bx_ma_jahresg.Items.Add(dr("mad_mitarbeiter_jahresgehalt"))
                com_bx_ma_jahresg.Text = dr("mad_mitarbeiter_jahresgehalt")
                com_bx_ma_monats.Items.Add(dr("mad_mitarbeiter_monatsgehalt"))
                com_bx_ma_monats.Text = dr("mad_mitarbeiter_monatsgehalt")
            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "Select map_position_name from Mitarbeiter_Positionen where map_position_ID = " & com_bx_ma_pos_ID.Text
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
                com_bx_ma_pos_name.Items.Add(dr("map_position_name").ToString)
                com_bx_ma_pos_name.Text = dr("map_position_name").ToString
            Next
            com_bx_ma_monats.Text.Cast(Of Double)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "Select mav_veranst_ID AS Veranstaltung_ID, vd_veranst_name AS Veranstaltung from Mitarbeiter_Veranstaltungen inner join Veranstaltungen_Daten on mav_veranst_ID = vd_veranst_ID where mav_mitarbeiter_ID = " & com_bx_ma_ID.Text

        Try
            con.Open()
            Dim dataadapter As New SqlClient.SqlDataAdapter(sql, con)
            dataadapter.Fill(ds, "Veranst_Abgleich")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()

            dgv_ma_veranstaltungem.DataSource = ds
            dgv_ma_veranstaltungem.DataMember = "Veranst_Abgleich"
        End Try

        Dim hilfe As Date = CDate(com_bx_ma_startdate.Text)
        Dim Wert As New TimeSpan
        Wert = Today.Date - hilfe.Date
        Label2.Text = Wert.TotalDays.ToString & " Tage im Unternehmen"

        Dim n As Integer = dgv_ma_veranstaltungem.RowCount - 1
        Label3.Text = n.ToString & " Veranstaltungen bisher betreut als " & com_bx_ma_pos_name.Text
    End Sub

    Private Sub Mitarbeiterübersicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""

        Dim constring As String = "Server = " & con_server & ";database = " & con_db & ";Integrated Security = SSPI"
        Dim con As New SqlClient.SqlConnection(constring)
        Dim sql As String = "SELECT Count(mad_mitarbeiter_ID) as D from Mitarbeiter_Daten"
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
                Label19.Text = dr("D").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try

        sql = "Select Count(mad_mitarbeiter_ID) as D from Mitarbeiter_Daten inner join Mitarbeiter_Positionen on mad_position_ID = map_position_ID where map_position_ID = 3100004 or map_position_ID = 3100001"
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
                Label20.Text = dr("D").ToString
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State <> ConnectionState.Closed Then con.Close()
        End Try
        Label21.Text = Label19.Text - Label20.Text
    End Sub


End Class