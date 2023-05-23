
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
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
                MessageBox.Show("Database error","Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Nessun dato trovato." ,"Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 risultati_button.Text= "RICARICA";
            

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

        string connectionString = "SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato";
        private void button1_Click(object sender, EventArgs e)
        {
            

            //se la stringa in quella textbox è vuota lancia errore
            if (string.IsNullOrWhiteSpace(datatextbox.Text) || string.IsNullOrWhiteSpace(casatextbox.Text) ||
              string.IsNullOrWhiteSpace(ospitetextbox.Text) || string.IsNullOrWhiteSpace(risultatotextbox.Text))
            {
                MessageBox.Show("Compila tutti i campi ", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string risultato = risultatotextbox.Text;
            string[] numeri = risultato.Split('-');
            if (numeri.Length != 2 || !int.TryParse(numeri[0], out int numero1) || !int.TryParse(numeri[1], out int numero2))
            {
                MessageBox.Show("Il formato del risultato non è valido. Utilizza il formato 'numero1 - numero2'.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica il formato della data
            if (!DateTime.TryParseExact(datatextbox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show("Il formato della data non è valido. Utilizza il formato gg/mm/aaaa.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string squadra_casa = casatextbox.Text;
            string squadra_ospite = ospitetextbox.Text;



            //aggiungi dati alla grid view collegata al database
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM risultati");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
          
                try
                {
                    connect.Open();

                    // Inserisci i dati nel database
                    string query = "INSERT * INTO risultati (Data, SquadraCasa, SquadraOspite, Risultato) VALUES (@Data, @SquadraCasa, @SquadraOspite, @Risultato)";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Data", data);
                    command.Parameters.AddWithValue("@SquadraCasa", squadra_casa);
                    command.Parameters.AddWithValue("@SquadraOspite", squadra_ospite);
                    command.Parameters.AddWithValue("@Risultato", risultato);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dati aggiunti con successo.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch 
                {
                    MessageBox.Show("Si è verificato un errore durante l'aggiunta dei dati " , "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            panel1.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            datatextbox.Text = "";
            casatextbox.Text = "";
            ospitetextbox.Text = "";
            risultatotextbox.Text = "";

        }

        private void elimina_button_Click(object sender, EventArgs e)
        {
             // Verifica se è stata selezionata una riga
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // ottengo l'indice della riga che seleziono
                int riga = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(riga);
                
            }
            else
            {
                MessageBox.Show("Seleziona una riga da eliminare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


