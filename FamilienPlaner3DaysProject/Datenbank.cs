using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilienPlaner3DaysProject
{
    public class Datenbank
    {
        static private MySqlConnection conn = null;
        static public void Open()
        {
            conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=Planer;");
            conn.Open();
        }

        static public MySqlCommand CreateCommand()
        {
            return conn.CreateCommand();
        }
        static public void Close()
        {
            conn.Close();
            conn = null;
        }
    }
}
