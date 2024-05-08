using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace konferencia_GUI
{
    internal class ConnectToDatabase
    {
        private string sqlStatement;
        MySqlConnection dbconn;
        MySqlCommand command;
        MySqlDataReader reader;
        List<Konferencia> konferenciak;
        public ConnectToDatabase()
        {
            konferenciak = new List<Konferencia>();
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
            try
            {
                dbconn.Open();

                sqlStatement = "SELECT eloadasid, cim, sorok, szekek FROM eloadasok;";
                command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Eloadoterem terem = new Eloadoterem(reader.GetInt32(2), reader.GetInt32(3));
                    Konferencia konferencia = new Konferencia(reader.GetInt32(0), reader.GetString(1), terem);
                    konferenciak.Add(konferencia);
                }
                dbconn.Close();
                GetVotesForKonferencia();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return konferenciak;
        }

        private void GetVotesForKonferencia()
        {
            try
            {
                dbconn.Open();

                foreach (var item in konferenciak)
                {
                    //Console.WriteLine("ID: "+item.Eloadas_id_);
                    sqlStatement = $"SELECT sor, szek, ertekeles FROM ertekelesek " +
                        $"WHERE eloadasid = {item.Eloadas_id_} ORDER BY sor, szek;";
                    command = new MySqlCommand();
                    command.Connection = dbconn;
                    command.CommandText = sqlStatement;
                   // Console.WriteLine("->"+item.Eloadoterem_.Sor_ + " "+item.Eloadoterem_.Hely_);
                    reader = command.ExecuteReader();
                    while (reader.Read()) 
                    {
                        int sor = reader.GetInt32(0) - 1;
                        int hely = reader.GetInt32(1) - 1;
                        
                        //Console.WriteLine(sor + " " +hely);
                        item.Eloadoterem_.Ertekelesek[sor, hely] = reader.GetInt32(2);
                    }
                    reader.Close();
                    command.Dispose();
                }

                dbconn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
