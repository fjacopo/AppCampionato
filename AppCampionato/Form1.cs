﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
          
          
        }
        
            private void risultati_button_Click(object sender, EventArgs e)
            {
                dataGridView1.Show();
                risultatiListBox.Hide();
                closelistboxbutton.Hide();

                MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM risultati");
                cmd.CommandType = CommandType.Text; //la query deve essere testuale
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
                        MessageBox.Show("Nessun dato trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {    //verifico se la connessione al server è aperta, in tal caso la chiudo e così facendo rilascio i dati della query
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
            risultatiListBox.Hide();
            closelistboxbutton.Hide();
            risultati_button.PerformClick();
            
            
        }

        
        private void button1_Click(object sender, EventArgs e) //aggiungi
        {

            //creo connect che è la connessione al database con i dati della stringa di connessione

            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");

            try
            {
                connect.Open();

                // Verifica che tutte le textbox siano compilate
                if (  string.IsNullOrWhiteSpace(datatextbox.Text) || string.IsNullOrWhiteSpace(casatextbox.Text) ||
                    string.IsNullOrWhiteSpace(ospitetextbox.Text) || string.IsNullOrWhiteSpace(risultatotextbox.Text))
                {
                    MessageBox.Show("Compila tutti i campi prima di aggiungere i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //controllo se la data è scritta correttamente
                if (!DateTime.TryParseExact(datatextbox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                {
                    MessageBox.Show("Il formato della data non è valido. Utilizza il formato gg/mm/aaaa.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // controllo che il risultato sia scritto correttamente
                string risultato = risultatotextbox.Text;

                string[] numeri = risultato.Split('-');
                if (numeri.Length != 2 || !int.TryParse(numeri[0], out int numero1) || !int.TryParse(numeri[1], out int numero2))
                {
                    MessageBox.Show("Il formato del risultato non è valido. Utilizza il formato 'numero1 - numero2'", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                string squadra_casa = casatextbox.Text;
                string squadra_ospite = ospitetextbox.Text;

                // creo la query con all'interno i dati scritti nelle textbox
                string query = "INSERT INTO risultati (data, squadra_casa, squadra_ospiti, risultato) VALUES (@data, @squadra_casa, @squadra_ospiti, @risultato)";
                
                MySqlCommand cmd = new MySqlCommand(query, connect);//cmd contiene i dati della query

                //aggiungo i dati della query al database nella colonna corretta 
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@squadra_casa", squadra_casa);
                cmd.Parameters.AddWithValue("@squadra_ospiti", squadra_ospite);
                cmd.Parameters.AddWithValue("@risultato", risultato);
                cmd.ExecuteNonQuery();

               
            }
            catch 
            {
                MessageBox.Show("Si è verificato un errore durante l'aggiunta dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            panel1.Hide();
            risultati_button.PerformClick();
           

            datatextbox.Text = "";
            casatextbox.Text = "";
            ospitetextbox.Text = "";
            risultatotextbox.Text = "";

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
           
            if (dataGridView1.SelectedRows.Count > 0) //le righe devono essere più di 0
            {
             
                //ottengo l'indice della riga 
                int riga = dataGridView1.SelectedRows[0].Index;

                //prende l'id della riga selezionata e lo mette in int
                int id = Convert.ToInt32(dataGridView1.Rows[riga].Cells["ID"].Value); 

               
                MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");

                try
                {
                    connect.Open();

                    //elimino la riga guardando l' id
                    string query = "DELETE FROM risultati WHERE ID = @id"; 

                    MySqlCommand cmd = new MySqlCommand(query, connect);

                    cmd.Parameters.AddWithValue("@id", id); //aggiungo il valore dell' id a cmd che è collegato alla query

                    cmd.ExecuteNonQuery();//esegue la query ma non restituisce risultati

                    
                    dataGridView1.Rows.RemoveAt(riga);

                   
                }
                catch
                {
                    MessageBox.Show("Si è verificato un errore durante l'eliminazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleziona una riga da eliminare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void closelistboxbutton_Click(object sender, EventArgs e)
        {
            risultatiListBox.Hide();
            closelistboxbutton.Hide();
            dataGridView1.Show();
        }

        private void getsquadra_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                string squadraSelezionata = dataGridView1.SelectedRows[0].Cells["squadra_casa"].Value.ToString();

                MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=appcampionato; password=appcampionato; database=campionato");
                try
                {
                    connect.Open();

                    string query = "SELECT * FROM risultati WHERE squadra_casa = @squadra OR squadra_ospiti = @squadra";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@squadra", squadraSelezionata);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        risultatiListBox.Items.Clear();

                        // Aggiungi i risultati al ListBox
                        while (reader.Read())
                        {
                            DateTime data = Convert.ToDateTime(reader["data"]);
                            string squadraCasa = reader["squadra_casa"].ToString();
                            string squadraOspite = reader["squadra_ospiti"].ToString();
                            string risultato = reader["risultato"].ToString();

                            string dataformattata = data.ToString("dd/MM/yyyy");  // Formatta la data 
                            string stringacompleta = $"{dataformattata}   {squadraCasa} vs {squadraOspite}: {risultato}";

                            risultatiListBox.Items.Add(stringacompleta);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Errore durante l'estrazione dei risultati della squadra.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

                risultatiListBox.Show();
                closelistboxbutton.Show();
                dataGridView1.Hide();
            
            }
                else
                {
                    MessageBox.Show("Seleziona una riga contenente la squadra desiderata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            


        }

        private void risultatiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}





