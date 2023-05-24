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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.risultati_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.risultatolabel = new System.Windows.Forms.Label();
            this.ospitelabel = new System.Windows.Forms.Label();
            this.casalabel = new System.Windows.Forms.Label();
            this.datalabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.risultatotextbox = new System.Windows.Forms.TextBox();
            this.ospitetextbox = new System.Windows.Forms.TextBox();
            this.casatextbox = new System.Windows.Forms.TextBox();
            this.datatextbox = new System.Windows.Forms.TextBox();
            this.elimina_button = new System.Windows.Forms.Button();
            this.titololabel = new System.Windows.Forms.Label();
            this.risultatiListBox = new System.Windows.Forms.ListBox();
            this.closelistboxbutton = new System.Windows.Forms.Button();
            this.getsquadra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(33, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(737, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // risultati_button
            // 
            this.risultati_button.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultati_button.Location = new System.Drawing.Point(33, 571);
            this.risultati_button.Name = "risultati_button";
            this.risultati_button.Size = new System.Drawing.Size(220, 80);
            this.risultati_button.TabIndex = 1;
            this.risultati_button.Text = "VISUALIZZA RISULTATI";
            this.risultati_button.UseVisualStyleBackColor = true;
            this.risultati_button.Click += new System.EventHandler(this.risultati_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(259, 588);
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.risultatolabel);
            this.panel1.Controls.Add(this.ospitelabel);
            this.panel1.Controls.Add(this.casalabel);
            this.panel1.Controls.Add(this.datalabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.risultatotextbox);
            this.panel1.Controls.Add(this.ospitetextbox);
            this.panel1.Controls.Add(this.casatextbox);
            this.panel1.Controls.Add(this.datatextbox);
            this.panel1.Location = new System.Drawing.Point(897, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 485);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(253, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // risultatolabel
            // 
            this.risultatolabel.AutoSize = true;
            this.risultatolabel.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultatolabel.ForeColor = System.Drawing.Color.White;
            this.risultatolabel.Location = new System.Drawing.Point(136, 312);
            this.risultatolabel.Name = "risultatolabel";
            this.risultatolabel.Size = new System.Drawing.Size(64, 18);
            this.risultatolabel.TabIndex = 8;
            this.risultatolabel.Text = "Risultato";
            // 
            // ospitelabel
            // 
            this.ospitelabel.AutoSize = true;
            this.ospitelabel.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ospitelabel.ForeColor = System.Drawing.Color.White;
            this.ospitelabel.Location = new System.Drawing.Point(93, 218);
            this.ospitelabel.Name = "ospitelabel";
            this.ospitelabel.Size = new System.Drawing.Size(107, 18);
            this.ospitelabel.TabIndex = 7;
            this.ospitelabel.Text = "Squadra ospite";
            // 
            // casalabel
            // 
            this.casalabel.AutoSize = true;
            this.casalabel.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casalabel.ForeColor = System.Drawing.Color.White;
            this.casalabel.Location = new System.Drawing.Point(93, 130);
            this.casalabel.Name = "casalabel";
            this.casalabel.Size = new System.Drawing.Size(114, 18);
            this.casalabel.TabIndex = 6;
            this.casalabel.Text = "Squadra di casa";
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalabel.ForeColor = System.Drawing.Color.White;
            this.datalabel.Location = new System.Drawing.Point(87, 52);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(138, 18);
            this.datalabel.TabIndex = 5;
            this.datalabel.Text = "Data (gg/mm/aaaa)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGGIUNGI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // risultatotextbox
            // 
            this.risultatotextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.risultatotextbox.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultatotextbox.Location = new System.Drawing.Point(56, 347);
            this.risultatotextbox.Name = "risultatotextbox";
            this.risultatotextbox.Size = new System.Drawing.Size(220, 25);
            this.risultatotextbox.TabIndex = 3;
            // 
            // ospitetextbox
            // 
            this.ospitetextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ospitetextbox.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ospitetextbox.Location = new System.Drawing.Point(56, 255);
            this.ospitetextbox.Name = "ospitetextbox";
            this.ospitetextbox.Size = new System.Drawing.Size(220, 25);
            this.ospitetextbox.TabIndex = 2;
            // 
            // casatextbox
            // 
            this.casatextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.casatextbox.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casatextbox.Location = new System.Drawing.Point(56, 163);
            this.casatextbox.Name = "casatextbox";
            this.casatextbox.Size = new System.Drawing.Size(220, 25);
            this.casatextbox.TabIndex = 1;
            // 
            // datatextbox
            // 
            this.datatextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.datatextbox.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatextbox.Location = new System.Drawing.Point(56, 89);
            this.datatextbox.Name = "datatextbox";
            this.datatextbox.Size = new System.Drawing.Size(220, 25);
            this.datatextbox.TabIndex = 0;
            // 
            // elimina_button
            // 
            this.elimina_button.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimina_button.Location = new System.Drawing.Point(376, 588);
            this.elimina_button.Name = "elimina_button";
            this.elimina_button.Size = new System.Drawing.Size(111, 47);
            this.elimina_button.TabIndex = 4;
            this.elimina_button.Text = "ELIMINA";
            this.elimina_button.UseVisualStyleBackColor = true;
            this.elimina_button.Click += new System.EventHandler(this.elimina_button_Click);
            // 
            // titololabel
            // 
            this.titololabel.AutoSize = true;
            this.titololabel.BackColor = System.Drawing.Color.Transparent;
            this.titololabel.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titololabel.ForeColor = System.Drawing.Color.White;
            this.titololabel.Location = new System.Drawing.Point(441, 9);
            this.titololabel.Name = "titololabel";
            this.titololabel.Size = new System.Drawing.Size(370, 54);
            this.titololabel.TabIndex = 5;
            this.titololabel.Text = "CAMPIONATO";
            // 
            // risultatiListBox
            // 
            this.risultatiListBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.risultatiListBox.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultatiListBox.ForeColor = System.Drawing.Color.White;
            this.risultatiListBox.FormattingEnabled = true;
            this.risultatiListBox.ItemHeight = 20;
            this.risultatiListBox.Location = new System.Drawing.Point(101, 93);
            this.risultatiListBox.Name = "risultatiListBox";
            this.risultatiListBox.Size = new System.Drawing.Size(611, 444);
            this.risultatiListBox.TabIndex = 7;
            this.risultatiListBox.SelectedIndexChanged += new System.EventHandler(this.risultatiListBox_SelectedIndexChanged);
            // 
            // closelistboxbutton
            // 
            this.closelistboxbutton.BackColor = System.Drawing.Color.Red;
            this.closelistboxbutton.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelistboxbutton.Location = new System.Drawing.Point(639, 104);
            this.closelistboxbutton.Name = "closelistboxbutton";
            this.closelistboxbutton.Size = new System.Drawing.Size(55, 30);
            this.closelistboxbutton.TabIndex = 8;
            this.closelistboxbutton.Text = "X";
            this.closelistboxbutton.UseVisualStyleBackColor = false;
            this.closelistboxbutton.Click += new System.EventHandler(this.closelistboxbutton_Click);
            // 
            // getsquadra
            // 
            this.getsquadra.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getsquadra.Location = new System.Drawing.Point(493, 588);
            this.getsquadra.Name = "getsquadra";
            this.getsquadra.Size = new System.Drawing.Size(208, 47);
            this.getsquadra.TabIndex = 9;
            this.getsquadra.Text = "OTTIENI DATI SQUADRA";
            this.getsquadra.UseVisualStyleBackColor = true;
            this.getsquadra.Click += new System.EventHandler(this.getsquadra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.getsquadra);
            this.Controls.Add(this.closelistboxbutton);
            this.Controls.Add(this.risultatiListBox);
            this.Controls.Add(this.titololabel);
            this.Controls.Add(this.elimina_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.risultati_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Campionato";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button elimina_button;
        private System.Windows.Forms.Label titololabel;
        private System.Windows.Forms.ListBox risultatiListBox;
        private System.Windows.Forms.Button closelistboxbutton;
        private System.Windows.Forms.Button getsquadra;
    }
}

