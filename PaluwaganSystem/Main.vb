Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Public Class Main

    Dim ds As New DataSet
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim svYN As DialogResult
    Dim addYN As DialogResult
    Dim editYN As DialogResult
    Dim cancelYN As DialogResult
    Dim updateYN As DialogResult
    Dim deleteYN As DialogResult
    Dim doneYN As DialogResult

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_paluwaganmain()
        compute_totalearnings()
        test()
    End Sub

    Public Sub test()
        Dim firstDate, msg As String
        Dim secondDate As Date
        firstDate = InputBox("Enter a date")
        Try
            secondDate = CDate(firstDate)
            msg = "Days from today: " & DateDiff(DateInterval.Day, Now, secondDate)
            MsgBox(msg)
        Catch
            MsgBox("Not a valid date value.")
        End Try
    End Sub

    Public Sub compute_totalearnings()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        Try
            MysqlConn.Open()
            Dim query As String
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
            Dim query As String
            query = "Select DATE_FORMAT(date,'%M %d %Y') as 'Date', contributor as 'Contributor', amount as 'Amount',week as 'Week' from paluwagan"

            COMMAND = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = COMMAND
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
                    Dim query As String
                    query = "INSERT INTO paluwagan (date,contributor,amount,week) VALUES ('" & Format(CDate(rec_dtp_datecontributed.Value), "yyyy-MM-dd") & "','" & rec_cb_contributor.Text & "','" & rec_cb_amount.Text & "','" & rec_week.Text & "')  "
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader

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

End Class
