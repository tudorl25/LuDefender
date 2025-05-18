Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Input

Public Class DatabaseManager
    Private Connect As New SqlConnection()

    Public Sub CreateNew(email As String, password As String)
        Dim eng As String
        Dim nr As Integer
        Dim nr2 As Integer
        If My.Settings.englishEnabled Then
            eng = "eng"
        Else
            eng = "ro"
        End If

        If My.Settings.fireWallActive Then
            nr = 1
        Else
            nr = 0
        End If

        If My.Settings.isSafe Then
            nr2 = 1
        Else
            nr2 = 0
        End If

        Dim isSuccess As Boolean = AddNewUser(email, password, My.Settings.eventLog, My.Settings.scheduledScanMode, eng, My.Settings.startupMode, nr, My.Settings.dateOfLastScan, nr2)


        If isSuccess Then
                MessageBox.Show("User added successfully.")
            Else
                MessageBox.Show("Failed to add user.")
            End If
    End Sub

    Function AddNewUser(email As String, password As String, eventlog As String, setScheduled As Integer, setLanguage As String, setStartup As Integer, firewall As Integer, dateOfLastScan As String, isSafe As Integer) As Boolean


        'dim connectionstring as string = "data source=desktop-38lhhig\sqlexpress;initial catalog=logindb;integrated security=true;encrypt=true;trustservercertificate=true;"
        'dim query as string = "insert into ludefenderdatabase (email, password, eventlog, setscheduled, setlanguage, setstartup, firewall, dateoflastscan, issafe) values (@email, @password, @eventlog, @setscheduled, @setlanguage, @setstartup, @firewall, @dateoflastscan, @issafe)"

        'using connection as new sqlconnection(connectionstring)
        '    try
        '        connection.open()

        '        using command as new sqlcommand(query, connection)

        '            command.parameters.addwithvalue("@email", email)
        '            command.parameters.addwithvalue("@password", password)
        '            command.parameters.addwithvalue("@eventlog", eventlog)
        '            command.parameters.addwithvalue("@setscheduled", setscheduled)
        '            command.parameters.addwithvalue("@setlanguage", setlanguage)
        '            command.parameters.addwithvalue("@setstartup", setstartup)
        '            command.parameters.addwithvalue("@firewall", firewall)
        '            command.parameters.addwithvalue("@dateoflastscan", dateoflastscan)
        '            command.parameters.addwithvalue("@issafe", issafe)

        '            dim rowsaffected as integer = command.executenonquery()
        '            return rowsaffected > 0
        '        end using

        '    catch ex as sqlexception
        '        messagebox.show("a sqlexception occurred: " & ex.message)
        '        return false
        '    catch ex as exception
        '        messagebox.show("an unexpected error occurred: " & ex.message)
        '        return false
        '    finally
        '        if connection.state = connectionstate.open then
        '            connection.close()
        '        end if
        '    end try
        'end using
    End Function

    Public Sub Update(email As String, password As String)
        'Dim eng As String
        'Dim nr As Integer
        'Dim nr2 As Integer
        'If My.Settings.englishEnabled Then
        '    eng = "eng"
        'Else
        '    eng = "ro"
        'End If

        'If My.Settings.fireWallActive Then
        '    nr = 1
        'Else
        '    nr = 0
        'End If

        'If My.Settings.isSafe Then
        '    nr2 = 1
        'Else
        '    nr2 = 0
        'End If
        'UpdateUser(email, password, My.Settings.eventLog, My.Settings.scheduledScanMode, eng, My.Settings.startupMode, nr, My.Settings.dateOfLastScan, nr2)
    End Sub

    Function UpdateUser(email As String, password As String, eventlog As String, setScheduled As Integer, setLanguage As String, setStartup As Integer, firewall As Integer, dateOfLastScan As String, isSafe As Integer) As Boolean

        'Dim connectionString As String = "Data Source=DESKTOP-38LHHIG\SQLEXPRESS;Initial Catalog=logindb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
        'Dim query As String = "UPDATE LuDefenderDatabase SET eventlog = @eventlog, setScheduled = @setScheduled, setLanguage = @setLanguage, setStartup = @setStartup, firewall = @firewall, dateOfLastScan = @dateOfLastScan, isSafe = @isSafe WHERE email = @email AND password = @password"

        'Using connection As New SqlConnection(connectionString)
        '    Try
        '        connection.Open()

        '        Using command As New SqlCommand(query, connection)
        '            ' Add parameters to prevent SQL injection
        '            command.Parameters.AddWithValue("@email", email)
        '            command.Parameters.AddWithValue("@password", password)
        '            command.Parameters.AddWithValue("@eventlog", eventlog)
        '            command.Parameters.AddWithValue("@setScheduled", setScheduled)
        '            command.Parameters.AddWithValue("@setLanguage", setLanguage)
        '            command.Parameters.AddWithValue("@setStartup", setStartup)
        '            command.Parameters.AddWithValue("@firewall", firewall)
        '            command.Parameters.AddWithValue("@dateOfLastScan", dateOfLastScan)
        '            command.Parameters.AddWithValue("@isSafe", isSafe)

        '            ' Execute the query
        '            Dim rowsAffected As Integer = command.ExecuteNonQuery()

        '            ' Check if the insert was successful
        '            Return rowsAffected > 0
        '        End Using

        '    Catch ex As SqlException
        '        ' Handle SQL exceptions
        '        MessageBox.Show("A SqlException occurred: " & ex.Message)
        '        Return False
        '    Catch ex As Exception
        '        ' Handle general exceptions
        '        MessageBox.Show("An unexpected error occurred: " & ex.Message)
        '        Return False
        '    Finally
        '        ' Ensure the connection is closed
        '        If connection.State = ConnectionState.Open Then
        '            connection.Close()
        '        End If
        '    End Try
        'End Using
    End Function

    Public Sub Login(email As String, password As String)
        'Dim userInfo As Dictionary(Of String, String) = GetUserInfo(email, password)

        'If userInfo IsNot Nothing Then
        '    MessageBox.Show("Login successful.")
        '    My.Settings.eventLog = userInfo("eventlog")
        '    My.Settings.RO_eventLog = userInfo("eventlog")
        '    My.Settings.scheduledScanMode = Convert.ToInt32(userInfo("setScheduled"))
        '    If userInfo("setLanguage") = "eng" Then
        '        My.Settings.englishEnabled = True
        '    Else
        '        My.Settings.englishEnabled = False
        '    End If

        '    My.Settings.startupMode = Convert.ToInt32(userInfo("setStartup"))
        '    If userInfo("firewall") = "1" Then
        '        My.Settings.fireWallActive = True
        '    Else
        '        My.Settings.englishEnabled = False
        '    End If
        '    My.Settings.dateOfLastScan = userInfo("dateOfLastScan")
        '    If userInfo("isSafe") = "1" Then
        '        My.Settings.isSafe = True
        '    Else
        '        My.Settings.isSafe = False
        '    End If
        '    My.Settings.Save()
        'Else
        '    MessageBox.Show("Login failed. Invalid email or password.")
        'End If
    End Sub

    Function GetUserInfo(email As String, password As String) As Dictionary(Of String, String)
        'Dim connectionString As String = "Data Source=DESKTOP-38LHHIG\SQLEXPRESS;Initial Catalog=logindb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
        'Dim query As String = "SELECT eventlog, setScheduled, setLanguage, setStartup, firewall, dateOfLastScan, isSafe FROM LuDefenderDatabase WHERE email = @email AND password = @password"

        'Dim userInfo As New Dictionary(Of String, String)()

        'Using connection As New SqlConnection(connectionString)
        '    Try
        '        connection.Open()
        '        Using command As New SqlCommand(query, connection)
        '            command.Parameters.AddWithValue("@email", email)
        '            command.Parameters.AddWithValue("@password", password)

        '            Using reader As SqlDataReader = command.ExecuteReader()
        '                If reader.Read() Then
        '                    userInfo("eventlog") = reader("eventlog").ToString()
        '                    userInfo("setScheduled") = reader("setScheduled").ToString()
        '                    userInfo("setLanguage") = reader("setLanguage").ToString()
        '                    userInfo("setStartup") = reader("setStartup").ToString()
        '                    userInfo("firewall") = reader("firewall").ToString()
        '                    userInfo("dateOfLastScan") = reader("dateOfLastScan").ToString()
        '                    userInfo("isSafe") = reader("isSafe").ToString()
        '                    Return userInfo
        '                Else

        '                    Return Nothing
        '                End If
        '            End Using
        '        End Using

        '    Catch ex As SqlException
        '        MessageBox.Show("A SqlException occurred: " & ex.Message)
        '        Return Nothing
        '    Catch ex As Exception
        '        MessageBox.Show("An unexpected error occurred: " & ex.Message)
        '        Return Nothing
        '    Finally
        '        If connection.State = ConnectionState.Open Then
        '            connection.Close()
        '        End If
        '    End Try
        'End Using
    End Function



End Class

