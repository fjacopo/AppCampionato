using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampionatoApp
{
    internal class DataBase
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "appcampionato";
        static readonly string password = "appcampionato";
        static readonly string database = "financial";
        public static string stringa_connessione = "server=' " + server + "'; user= '" + user + "';database='"+database+ "';password='" + password + "'";
        public MySqlConnection mySqlConnection = new MySqlConnection(stringa_connessione);
        public bool connect_database()    //connessione al database
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool close_database()    //chiusura del database
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
