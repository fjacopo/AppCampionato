
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCampionato;
using MySql.Data.MySqlClient;

namespace CampionatoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            caricadati();
          
        }
        public void caricadati()
        {
            var database = new DataBase();
            if (database.connect_database())
            {
                string a = "SELECT * FROM risulati";
                MySqlCommand mysqlCommand = new MySqlCommand(a);
                mysqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mysqlCommand;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;

                database.close_database();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

            private void risultati_button_Click(object sender, EventArgs e)
            {
                MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM risultati");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connect;
                connect.Open();
                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dr);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Nessun dato trovato.");
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            

        }
        private void add_button_Click(object sender, EventArgs e)
        {
            panel1.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
