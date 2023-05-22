namespace CampionatoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.risultati_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datatextbox = new System.Windows.Forms.TextBox();
            this.casatextbox = new System.Windows.Forms.TextBox();
            this.ospitetextbox = new System.Windows.Forms.TextBox();
            this.risultatotextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datalabel = new System.Windows.Forms.Label();
            this.casalabel = new System.Windows.Forms.Label();
            this.ospitelabel = new System.Windows.Forms.Label();
            this.risultatolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(33, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(737, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // risultati_button
            // 
            this.risultati_button.Location = new System.Drawing.Point(33, 457);
            this.risultati_button.Name = "risultati_button";
            this.risultati_button.Size = new System.Drawing.Size(220, 80);
            this.risultati_button.TabIndex = 1;
            this.risultati_button.Text = "VISUALIZZA RISULTATI";
            this.risultati_button.UseVisualStyleBackColor = true;
            this.risultati_button.Click += new System.EventHandler(this.risultati_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(259, 474);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 47);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "AGGIUNGI";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.risultatolabel);
            this.panel1.Controls.Add(this.ospitelabel);
            this.panel1.Controls.Add(this.casalabel);
            this.panel1.Controls.Add(this.datalabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.risultatotextbox);
            this.panel1.Controls.Add(this.ospitetextbox);
            this.panel1.Controls.Add(this.casatextbox);
            this.panel1.Controls.Add(this.datatextbox);
            this.panel1.Location = new System.Drawing.Point(805, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 388);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datatextbox
            // 
            this.datatextbox.Location = new System.Drawing.Point(26, 43);
            this.datatextbox.Name = "datatextbox";
            this.datatextbox.Size = new System.Drawing.Size(220, 22);
            this.datatextbox.TabIndex = 0;
            // 
            // casatextbox
            // 
            this.casatextbox.Location = new System.Drawing.Point(26, 109);
            this.casatextbox.Name = "casatextbox";
            this.casatextbox.Size = new System.Drawing.Size(220, 22);
            this.casatextbox.TabIndex = 1;
            // 
            // ospitetextbox
            // 
            this.ospitetextbox.Location = new System.Drawing.Point(26, 183);
            this.ospitetextbox.Name = "ospitetextbox";
            this.ospitetextbox.Size = new System.Drawing.Size(220, 22);
            this.ospitetextbox.TabIndex = 2;
            // 
            // risultatotextbox
            // 
            this.risultatotextbox.Location = new System.Drawing.Point(26, 261);
            this.risultatotextbox.Name = "risultatotextbox";
            this.risultatotextbox.Size = new System.Drawing.Size(220, 22);
            this.risultatotextbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(87, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGGIUNGI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.ForeColor = System.Drawing.Color.White;
            this.datalabel.Location = new System.Drawing.Point(70, 14);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(125, 16);
            this.datalabel.TabIndex = 5;
            this.datalabel.Text = "Data (gg/mm/aaaa)";
            // 
            // casalabel
            // 
            this.casalabel.AutoSize = true;
            this.casalabel.ForeColor = System.Drawing.Color.White;
            this.casalabel.Location = new System.Drawing.Point(73, 87);
            this.casalabel.Name = "casalabel";
            this.casalabel.Size = new System.Drawing.Size(106, 16);
            this.casalabel.TabIndex = 6;
            this.casalabel.Text = "Squadra di casa";
            // 
            // ospitelabel
            // 
            this.ospitelabel.AutoSize = true;
            this.ospitelabel.ForeColor = System.Drawing.Color.White;
            this.ospitelabel.Location = new System.Drawing.Point(73, 164);
            this.ospitelabel.Name = "ospitelabel";
            this.ospitelabel.Size = new System.Drawing.Size(99, 16);
            this.ospitelabel.TabIndex = 7;
            this.ospitelabel.Text = "Squadra ospite";
            // 
            // risultatolabel
            // 
            this.risultatolabel.AutoSize = true;
            this.risultatolabel.ForeColor = System.Drawing.Color.White;
            this.risultatolabel.Location = new System.Drawing.Point(97, 232);
            this.risultatolabel.Name = "risultatolabel";
            this.risultatolabel.Size = new System.Drawing.Size(59, 16);
            this.risultatolabel.TabIndex = 8;
            this.risultatolabel.Text = "Risultato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 554);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.risultati_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Campionato";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button risultati_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox risultatotextbox;
        private System.Windows.Forms.TextBox ospitetextbox;
        private System.Windows.Forms.TextBox casatextbox;
        private System.Windows.Forms.TextBox datatextbox;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Label casalabel;
        private System.Windows.Forms.Label risultatolabel;
        private System.Windows.Forms.Label ospitelabel;
    }
}

