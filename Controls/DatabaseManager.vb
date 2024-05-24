Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Input

Public Class DatabaseManager
    Private Connect As New SqlConnection()

    Public Sub CreateNew(email As String, password As String)
        Dim isSuccess As Boolean = AddNewUser(email, password, "", -1, "eng", 2, 1, "xx", 1)

        If isSuccess Then
            MessageBox.Show("User added successfully.")
        Else
            MessageBox.Show("Failed to add user.")
        End If
    End Sub

    Function AddNewUser(email As String, password As String, eventlog As String, setScheduled As Integer, setLanguage As String, setStartup As Integer, firewall As Integer, dateOfLastScan As String, isSafe As Integer) As Boolean

        Dim connectionString As String = "Data Source=DESKTOP-38LHHIG\SQLEXPRESS;Initial Catalog=logindb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
        Dim query As String = "INSERT INTO LuDefenderDatabase (email, password, eventlog, setScheduled, setLanguage, setStartup, firewall, dateOfLastScan, isSafe) VALUES (@email, @password, @eventlog, @setScheduled, @setLanguage, @setStartup, @firewall, @dateOfLastScan, @isSafe)"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@eventlog", eventlog)
                    command.Parameters.AddWithValue("@setScheduled", setScheduled)
                    command.Parameters.AddWithValue("@setLanguage", setLanguage)
                    command.Parameters.AddWithValue("@setStartup", setStartup)
                    command.Parameters.AddWithValue("@firewall", firewall)
                    command.Parameters.AddWithValue("@dateOfLastScan", dateOfLastScan)
                    command.Parameters.AddWithValue("@isSafe", isSafe)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using

            Catch ex As SqlException
                MessageBox.Show("A SqlException occurred: " & ex.Message)
                Return False
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message)
                Return False
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Function

    Function UpdateUser(email As String, password As String, eventlog As String, setScheduled As Integer, setLanguage As String, setStartup As Integer, firewall As Integer, dateOfLastScan As String, isSafe As Integer) As Boolean

        Dim connectionString As String = "Data Source=DESKTOP-38LHHIG\SQLEXPRESS;Initial Catalog=logindb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
        Dim query As String = "UPDATE LuDefenderDatabase SET eventlog = @eventlog, setScheduled = @setScheduled, setLanguage = @setLanguage, setStartup = @setStartup, firewall = @firewall, dateOfLastScan = @dateOfLastScan, isSafe = @isSafe WHERE email = @email AND password = @password"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@eventlog", eventlog)
                    command.Parameters.AddWithValue("@setScheduled", setScheduled)
                    command.Parameters.AddWithValue("@setLanguage", setLanguage)
                    command.Parameters.AddWithValue("@setStartup", setStartup)
                    command.Parameters.AddWithValue("@firewall", firewall)
                    command.Parameters.AddWithValue("@dateOfLastScan", dateOfLastScan)
                    command.Parameters.AddWithValue("@isSafe", isSafe)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the insert was successful
                    Return rowsAffected > 0
                End Using

            Catch ex As SqlException
                ' Handle SQL exceptions
                MessageBox.Show("A SqlException occurred: " & ex.Message)
                Return False
            Catch ex As Exception
                ' Handle general exceptions
                MessageBox.Show("An unexpected error occurred: " & ex.Message)
                Return False
            Finally
                ' Ensure the connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Function

    Public Sub Login(email As String, password As String)
        Dim userInfo As Dictionary(Of String, String) = GetUserInfo(email, password)

        If userInfo IsNot Nothing Then
            MessageBox.Show("Login successful.")
            MessageBox.Show("eventlog: " & userInfo("eventlog"))
            MessageBox.Show("setScheduled: " & userInfo("setScheduled"))
            MessageBox.Show("setLanguage: " & userInfo("setLanguage"))
            MessageBox.Show("setStartup: " & userInfo("setStartup"))
            MessageBox.Show("firewall: " & userInfo("firewall"))
            MessageBox.Show("dateOfLastScan: " & userInfo("dateOfLastScan"))
            MessageBox.Show("isSafe: " & userInfo("isSafe"))

        Else
            MessageBox.Show("Login failed. Invalid email or password.")
        End If
    End Sub

    Function GetUserInfo(email As String, password As String) As Dictionary(Of String, String)
        Dim connectionString As String = "Data Source=DESKTOP-38LHHIG\SQLEXPRESS;Initial Catalog=logindb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
        Dim query As String = "SELECT eventlog, setScheduled, setLanguage, setStartup, firewall, dateOfLastScan, isSafe FROM LuDefenderDatabase WHERE email = @email AND password = @password"

        Dim userInfo As New Dictionary(Of String, String)()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            userInfo("eventlog") = reader("eventlog").ToString()
                            userInfo("setScheduled") = reader("setScheduled").ToString()
                            userInfo("setLanguage") = reader("setLanguage").ToString()
                            userInfo("setStartup") = reader("setStartup").ToString()
                            userInfo("firewall") = reader("firewall").ToString()
                            userInfo("dateOfLastScan") = reader("dateOfLastScan").ToString()
                            userInfo("isSafe") = reader("isSafe").ToString()
                            Return userInfo
                        Else

                            Return Nothing
                        End If
                    End Using
                End Using

            Catch ex As SqlException
                MessageBox.Show("A SqlException occurred: " & ex.Message)
                Return Nothing
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message)
                Return Nothing
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Function



End Class

