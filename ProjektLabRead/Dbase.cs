﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace WinDruckauftrag
{
    class Dbase
    {
        string dbName;
        string uid;
        string passw;
        string connectionstr;
        MySqlConnection connection;
        MySqlCommand command;

        public Dbase(string dbName, string uid, string passw)
        {
            this.dbName = dbName;
            this.uid = uid;
            this.passw = passw;
            connectionstr = "SERVER   = localhost;" +
                            "DATABASE = " + dbName +
                            ";UID     = " + uid +
                            ";PWD     = " + passw + ";";
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection = new MySqlConnection(connectionstr);
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection = null;
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank "
                    + dbName + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw (ex);
            }
        }

        /// <summary>
        /// gibt den Namen der Datenbank zurück.
        /// </summary>
        public string DatabaseName { get => dbName; }

        /// <summary>
        /// gibt die Namen der Datenspalten (evtl. mit ihren Datentypen als String-Liste zurück
        /// </summary>
        /// <param name="table">Name der Tabelle, dessen Spaltennamen ermittelt werden sollen</param>
        /// <returns>Liste der Spaltennamen und evtl. ihrer Datentypen </returns>
        public List<string> ColumnNames(string table)
        {
            string selectText = "SELECT * FROM " + table;
            List<string> columnCaption = new List<string>();
            try
            {
                connection.Open();
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(selectText, connection);
                DataTable dataTbl = new DataTable();
                sqlDataAdap.Fill(dataTbl);
                connection.Close();
                // dataTbl Spaltennamen und Datentypen in eine String-Liste
                var dataColumns = dataTbl.Columns;

                for (int i = 0; i < dataColumns.Count; i++)
                {
                    //columnCaption.Add(string.Format("{0} ({1})", dataColumns[i].ColumnName, dataColumns[i].DataType));
                    columnCaption.Add(dataColumns[i].ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen der Spaltennamen\n" + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return columnCaption;
        }

        /// <summary>
        /// gibt die Daten einer Tabelle als Liste von String-Arrays zurück.
        /// Jeder Listeneintrag liefert einen Datensatz der Tabelle als String-Array.
        /// Jedes String-Array enthält die Daten der jeweiligen Spalten der Tabelle.
        /// </summary>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <returns>Liste der Datenzeilen mit Spaltendaten im String-Array</returns>
        public List<string[]> CommandSelectAsListFrom(string table)
        {
            List<string[]> rowList = new List<string[]>();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM " + table;
                MySqlDataReader reader = command.ExecuteReader();
                string[] row;
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int column = 0; column < reader.FieldCount; column++)
                    {
                        row[column] = reader[column].ToString();
                    }
                    rowList.Add(row);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' List\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowList;
        }


        /// <summary>
        /// gibt die Daten einer Tabelle als Liste von String-Arrays zurück.
        /// Jeder Listeneintrag liefert einen Datensatz der Tabelle als String-Array.
        /// Jedes String-Array enthält die Daten der jeweiligen Spalten der Tabelle.
        /// </summary>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <param name="condition">Bedingung für das Selektieren</param>
        /// <returns>Liste der Datenzeilen mit Spaltendaten im String-Array</returns>
        public List<string[]> CommandSelectAsListFrom(string table, string condition)
        {
            List<string[]> rowList = new List<string[]>();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM " + table + " " + condition;
                MySqlDataReader reader = command.ExecuteReader();
                string[] row;
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int column = 0; column < reader.FieldCount; column++)
                    {
                        row[column] = reader[column].ToString();
                    }
                    rowList.Add(row);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' List\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowList;
        }


        /// <summary>
        /// gibt die Daten einer Spalte einer Tabelle als Liste von String-Arrays zurück.
        /// Jeder Listeneintrag liefert einen Datensatz der Tabelle als String-Array.
        /// Jedes String-Array enthält die Daten der Spalte der Tabelle.
        /// </summary>
        /// <param name="column">Name der Spalte, deren Daten ermittelt werden sollen</param>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <param name="condition">Bedingung für das Selektieren</param>
        /// <returns>Liste der Datenzeilen mit Spaltendaten im String-Array</returns>
        public List<string[]> CommandSelectAsListFrom(string column, string table, string condition)
        {
            List<string[]> rowList = new List<string[]>();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT " + column + " FROM " + table + " " + condition;
                MySqlDataReader reader = command.ExecuteReader();
                string[] row;
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int col = 0; col < reader.FieldCount; col++)
                    {
                        row[col] = reader[col].ToString();
                    }
                    rowList.Add(row);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' List\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowList;
        }


        /// <summary>
        /// gibt die Daten einer Tabelle als DataTable zurück.
        /// </summary>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <returns>DataTable der Tabelle</returns>
        public DataTable CommandSelectAsDataTableFrom(string table)
        {
            DataTable dataTbl = new DataTable();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM " + table;
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command.CommandText, connection);
                sqlDataAdap.Fill(dataTbl);
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' Table\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTbl;
        }


        /// <summary>
        /// gibt die Daten einer Tabelle als DataTable zurück.
        /// </summary>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <param name="condition"> Bedingung, Strings eingeschlossen in Hochkommata</param>
        /// <returns>DataTable der Tabelle</returns>
        public DataTable CommandSelectAsDataTableFrom(string table, string condition)
        {
            DataTable dataTbl = new DataTable();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM " + table + " " + condition;
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command.CommandText, connection);
                sqlDataAdap.Fill(dataTbl);
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' Table\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTbl;
        }

        /// <summary>
        /// gibt die Daten einer Tabelle als DataTable zurück.
        /// </summary>
        /// <param name="column">Spalten der Tabelle, die Ermittelt werden sollen</param>
        /// <param name="table">Name der Tabelle, dessen Spalten ermittelt werden sollen</param>
        /// <param name="condition"> Bedingung, Strings eingeschlossen in Hochkommata</param>
        /// <returns>DataTable der Tabelle</returns>
        public DataTable CommandSelectAsDataTableFrom(string column,string table, string condition)
        {
            DataTable dataTbl = new DataTable();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT "+ column +" FROM " + table + " " + condition;
                MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(command.CommandText, connection);
                sqlDataAdap.Fill(dataTbl);
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Fehler bei 'Select' Table\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTbl;
        }

        /// <summary>
        /// fügt Daten in eine Tabelle ein.
        /// </summary>
        /// <param name="table"> Name der Tabelle, in die eingefügt werden soll</param>
        /// <param name="columnNames"> Spaltennamen, getrennt mit ','</param>
        /// <param name="values"> Werte, getrennt mit ',', Strings eingeschlossen in Hochkommata</param>
        public void CommandInsertInto(string table, string columnNames, string values)
        {
            try
            {
                connection.Close();
                connection.Open();
                string myInsertQuery = "INSERT INTO " + table + " (" + columnNames + ") VALUES (" + values + ")";
                MySqlCommand commandInsert = new MySqlCommand(myInsertQuery, connection);
                commandInsert.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei 'Insert into'\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CommandDelete(string table, string condition)
        {
            try
            {
                connection.Close();
                connection.Open();
                string mydeleteQuery = "DELETE FROM " + table + " " + condition;
                MySqlCommand commanddelete = new MySqlCommand(mydeleteQuery, connection);
                commanddelete.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei 'Delete From'\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// fügt Daten in eine Tabelle ein.
        /// </summary>
        /// <param name="table"> Name der Tabelle, in die eingefügt werden soll</param>
        /// <param name="condition"> Bedingung, Strings eingeschlossen in Hochkommata</param>
       

        public void CommandInsertInto(string table, string[] columnNames, string[] values)
        {
            try
            {
                connection.Close();
                connection.Open();
                string myInsertQuery = "INSERT INTO " + table
                    + " (" + coStr(columnNames) + ") VALUES ("
                    + coStrqT(values) + ")";
                MySqlCommand commandInsert = new MySqlCommand(myInsertQuery, connection);
                commandInsert.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei 'Insert into'\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// modifiziert Daten in einer Tabelle.
        /// </summary>
        /// <param name="table"> Name der Tabelle, in der modifilziert werden soll</param>
        /// <param name="set"> Spaltenname = Wert</param>
        /// <param name="condition"> Bedingung, Strings eingeschlossen in Hochkommata</param>
        public void CommandUpdate(string table, string set, string condition)
        {
            try
            {
                connection.Close();
                connection.Open();
                string myUpdateQuery = "UPDATE " + table + " SET " + set + " " + condition;
                MySqlCommand commandUpdate = new MySqlCommand(myUpdateQuery, connection);
                commandUpdate.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei 'Update'\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public override string ToString()
        {
            return "Datenbank '" + dbName + "' von User '" + uid + "'";
        }

        /// <summary>
        /// <c>qT</c> 'quotet Text' setzt den Parameter-Text in Hochkommata
        /// </summary>
        /// <param name="content"> Text, der in Hochkommata gesetzt werden soll</param>
        /// <returns> Text in Hochkommata</returns>
        private string qT(string content)       // quoted Text
        {
            content = content.Trim();
            if (content[0].ToString() != "'")
            {
                content = "'" + content + "'";
            }
            return content;
        }

        /// <summary>
        /// <c>coStr</c> verkettet Strings eines String-Arrays zu einem String.
        /// Die Array-Elemente werden darin durch Kommata getrennt.
        /// </summary>
        /// <param name="arr"> String-Array</param>
        /// <returns>verketteter String</returns>
        private string coStr(string[] arr)
        {
            string temp = string.Empty;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    temp += arr[i] + ",";
                }
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        /// <summary>
        /// <c>coStrqT</c> verkettet Strings aus einem Array,
        /// die dabei in Hochkommata eingeschlossen und durch Kommata getrennt werden.
        /// </summary>
        /// <param name="arr">String-Array</param>
        /// <returns>verketteter String</returns>
        private string coStrqT(string[] arr)
        {
            string temp = string.Empty;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    temp += qT(arr[i]) + ",";
                }
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        ~Dbase()
        {
            if (command != null)
            {
                command.Dispose();
            }
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}
