﻿Imports MySql.Data.MySqlClient
Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;userid=root;password=root;database=paluwagan_system"
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public activeuserfname As String
    Public activeuserlname As String
    Public username As String
    Public studno As String
    Public lc As Login
End Module
