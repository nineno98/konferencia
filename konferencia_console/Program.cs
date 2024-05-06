using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Konferencia> konferenciak = new List<Konferencia>();
            ConnectToDatabase connectToDatabase = new ConnectToDatabase();
            konferenciak = connectToDatabase.SelectKonferenciak();
            foreach (var item in konferenciak)
            {
                Console.WriteLine(item.Eloadascime_ + "\n" + item.Eloadoterem_);
            }

            Console.ReadKey();
        }
    }
}
