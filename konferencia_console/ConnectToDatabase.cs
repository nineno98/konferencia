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
        private string sqlStatement;
        MySqlConnection dbconn;
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



            return konferenciak;
        }
    }
}
