using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionAbsences
{
    class Connexion
    {
        static MySqlConnection con = null;
        static MySqlCommand cmd = null;
        public static void Connect(string dbname, string server="localhost", string user="root", string password = "")
        {
            if(con == null)
            {
                con = new MySqlConnection("server = "+ server + "; user id ="+ user +"; database ="+ dbname);
                cmd = new MySqlCommand();
            }
            if(con.State.ToString() == "Closed")
            {
                con.Open();
                cmd.Connection = con;
            }
        }

        public static MySqlDataReader select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }
    }
}
