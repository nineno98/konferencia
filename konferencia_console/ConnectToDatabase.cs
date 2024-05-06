using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace konferencia_console
{
    internal class ConnectToDatabase
    {
        private string sqlStatement, sqlStatement2;
        MySqlConnection dbconn;
        MySqlCommand command;
        MySqlDataReader reader, reader2;
        public ConnectToDatabase()
        {
            kapcsolat();
        }

        private void kapcsolat()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "konferencia";
            sb.UserID = "root";
            sb.Password = "";

            dbconn = new MySqlConnection(sb.ToString());
        }

        public List<Konferencia> SelectKonferenciak()
        {
            List<Konferencia> konferenciak = new List<Konferencia>();
            try
            {
                dbconn.Open();

                sqlStatement = "SELECT eloadasid, cim, sorok, szekek FROM eloadasok;";
                command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                int id, sor, szek;
                string cim;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    cim = reader.GetString(1);
                    sor = reader.GetInt32(2);
                    szek = reader.GetInt32(3);
                    sqlStatement2 = $"SELECT sor, szek, ertekeles FROM ertekelesek " +
                        $"WHERE eloadasid = {id} ORDER BY sor, szek;";
                    Eloadoterem terem = new Eloadoterem(sor, szek);
                    MySqlCommand command2 = new MySqlCommand();
                    command2.Connection = dbconn;
                    command2.CommandText = sqlStatement2;
                    reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        terem.Ertekelesek[reader2.GetInt32(0), reader2.GetInt32(1)] = reader2.GetInt32(2);
                    }
                    Konferencia konferencia = new Konferencia(id, cim, terem);

                }


                dbconn.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            return konferenciak;
        }
    }
}
