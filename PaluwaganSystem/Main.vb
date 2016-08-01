Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Public Class Main

    Dim ds As New DataSet
    Dim MysqlConn As MySqlConnection
    Dim dbDataSet As New DataTable
    Dim svYN As DialogResult
    Dim addYN As DialogResult
    Dim editYN As DialogResult
    Dim cancelYN As DialogResult
    Dim updateYN As DialogResult
    Dim deleteYN As DialogResult
    Dim doneYN As DialogResult
    Dim query As String

    Private Sub rgv_paluwaganmain_ViewRowFormatting(sender As Object, e As UI.RowFormattingEventArgs) Handles rgv_paluwaganmain.ViewRowFormatting
        e.RowElement.TextAlignment = ContentAlignment.MiddleCenter
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_paluwaganmain()
        compute_totalearnings()
        'test()
        rec_dtp_datecontributed.Text = DateTime.Now

    End Sub

    'Public Sub test()
    '    Dim firstDate, msg As String
    '    Dim secondDate As Date
    '    firstDate = InputBox("Enter a date")
    '    Try
    '        secondDate = CDate(firstDate)
    '        msg = "Days from today: " & DateDiff(DateInterval.Day, Now, secondDate)
    '        MsgBox(msg)
    '    Catch
    '        MsgBox("Not a valid date value.")
    '    End Try
    'End Sub

    Public Sub compute_totalearnings()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Try
            MysqlConn.Open()

            Dim holder As String

            query = "SELECT sum(amount) as 'temp' from paluwagan"


            comm = New MySqlCommand(query, MysqlConn)
            reader = comm.ExecuteReader

            While reader.Read
                holder = reader.GetString("temp")
            End While
            lbl_totalearnings.Text = holder



            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Public Sub load_paluwaganmain()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Try
            MysqlConn.Open()

            query = "Select DATE_FORMAT(date,'%M %d %Y') as 'Date', contributor as 'Contributor', amount as 'Amount',week as 'Week',day as 'Day' from paluwagan order by day desc"

            comm = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = comm
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_paluwaganmain.DataSource = bsource
            rgv_paluwaganmain.ReadOnly = True
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "ROPA Management", MessageBoxButtons.OK, RadMessageIcon.Error)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Dim READER As MySqlDataReader
        addYN = RadMessageBox.Show(Me, "Are you sure you want to save this record?", "Paluwagan System Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If addYN = MsgBoxResult.Yes Then
            If (rec_cb_amount.Text = "") Or (rec_cb_contributor.Text = "") Then
                RadMessageBox.Show(Me, "Please complete the form", "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                Try
                    MysqlConn.Open()

                    query = "INSERT INTO paluwagan (date,contributor,amount,week,day) VALUES ('" & Format(CDate(rec_dtp_datecontributed.Value), "yyyy-MM-dd") & "','" & rec_cb_contributor.Text & "','" & rec_cb_amount.Text & "','" & rec_week.Text & "','" & rec_day.Text & "')  "
                    comm = New MySqlCommand(query, MysqlConn)
                    READER = comm.ExecuteReader
                    rec_dtp_datecontributed.Text = DateTime.Now
                    RadMessageBox.Show(Me, "Paluwagan Saved!", "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                    MysqlConn.Close()

                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    MysqlConn.Dispose()

                End Try
            End If
        End If

        rec_dtp_datecontributed.Value = DateTime.Now

        load_paluwaganmain()
        compute_totalearnings()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        updateYN = RadMessageBox.Show(Me, "Are you sure you want to update this record?", "Paluwagan System Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If updateYN = MsgBoxResult.Yes Then
            If (rec_cb_amount.Text = "") Or (rec_cb_contributor.Text = "") Or (rec_day.Text = "") Or (rec_dtp_datecontributed.Text = "") Or (rec_week.Text = "") Then
                RadMessageBox.Show(Me, "Please fill all fields", "Paluwagan Management System", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                Try
                    MysqlConn.Open()
                    query = "UPDATE paluwagan SET date='" & Format(CDate(rec_dtp_datecontributed.Value), "yyyy-MM-dd") & "',contributor='" & rec_cb_contributor.Text & "',week='" & rec_week.Text & "',amount='" & rec_cb_amount.Text & "',day='" & rec_day.Text & "' where contributor='" & rec_cb_contributor.Text & "' and date='" & Format(CDate(rec_dtp_datecontributed.Value), "yyyy-MM-dd") & "'"
                    comm = New MySqlCommand(query, MysqlConn)
                    reader = comm.ExecuteReader
                    rec_dtp_datecontributed.Text = DateTime.Now
                    RadMessageBox.Show(Me, "Paluwagan Updated!", "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                    MysqlConn.Close()
                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Error)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If
        End If

        load_paluwaganmain()
        compute_totalearnings()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        deleteYN = RadMessageBox.Show(Me, "Are you sure you want to delete this record?", "Paluwagan System Management", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If deleteYN = MsgBoxResult.Yes Then
            Try
                MysqlConn.Open()
                query = "DELETE FROM paluwagan where date='" & Format(CDate(rec_dtp_datecontributed.Value), "yyyy-MM-dd") & "' and contributor='" & rec_cb_contributor.Text & "'"
                comm = New MySqlCommand(query, MysqlConn)
                reader = comm.ExecuteReader

                rec_cb_amount.Text = ""
                rec_cb_contributor.Text = ""
                rec_day.Text = ""
                rec_dtp_datecontributed.Text = DateTime.Now
                rec_week.Text = ""

                RadMessageBox.Show(Me, "Record Deleted!", "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Info)
                MysqlConn.Close()
            Catch ex As Exception
                RadMessageBox.Show(Me, ex.Message, "Paluwagan System Management", MessageBoxButtons.OK, RadMessageIcon.Error)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
        load_paluwaganmain()
        compute_totalearnings()
    End Sub

    Private Sub rgv_paluwaganmain_CellDoubleClick(sender As Object, e As UI.GridViewCellEventArgs) Handles rgv_paluwaganmain.CellDoubleClick
        If e.RowIndex >= 0 Then
           Dim row As Telerik.WinControls.UI.GridViewRowInfo

            row = Me.rgv_paluwaganmain.Rows(e.RowIndex)

            rec_cb_amount.Text = row.Cells("Amount").Value.ToString
            rec_cb_contributor.Text = row.Cells("Contributor").Value.ToString
            rec_day.Text = row.Cells("Day").Value.ToString
            rec_dtp_datecontributed.Text = row.Cells("Date").Value.ToString
            rec_week.Text = row.Cells("Week").Value.ToString

        End If
    End Sub


End Class
