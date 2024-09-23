namespace CatturaSchermo
{
    partial class frmCattura
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
            this.components = new System.ComponentModel.Container();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tbxPrefisso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCartella = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSX_X = new System.Windows.Forms.NumericUpDown();
            this.nudSX_Y = new System.Windows.Forms.NumericUpDown();
            this.nudDX_Y = new System.Windows.Forms.NumericUpDown();
            this.nudDX_X = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCoord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxProcesso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxProcessoTitolo = new System.Windows.Forms.TextBox();
            this.nudContatore = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTasto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDX_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDX_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContatore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(16, 384);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(110, 44);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "Cattura e scrolla";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPrefisso
            // 
            this.tbxPrefisso.Location = new System.Drawing.Point(16, 266);
            this.tbxPrefisso.Name = "tbxPrefisso";
            this.tbxPrefisso.Size = new System.Drawing.Size(110, 20);
            this.tbxPrefisso.TabIndex = 1;
            this.tbxPrefisso.Text = "screenshot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prefisso file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cartella";
            // 
            // tbxCartella
            // 
            this.tbxCartella.Location = new System.Drawing.Point(16, 227);
            this.tbxCartella.Name = "tbxCartella";
            this.tbxCartella.Size = new System.Drawing.Size(110, 20);
            this.tbxCartella.TabIndex = 3;
            this.tbxCartella.Text = "D:\\Temp\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punto alto sx";
            // 
            // nudSX_X
            // 
            this.nudSX_X.Location = new System.Drawing.Point(16, 37);
            this.nudSX_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSX_X.Name = "nudSX_X";
            this.nudSX_X.Size = new System.Drawing.Size(52, 20);
            this.nudSX_X.TabIndex = 6;
            this.nudSX_X.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            // 
            // nudSX_Y
            // 
            this.nudSX_Y.Location = new System.Drawing.Point(74, 37);
            this.nudSX_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSX_Y.Name = "nudSX_Y";
            this.nudSX_Y.Size = new System.Drawing.Size(52, 20);
            this.nudSX_Y.TabIndex = 7;
            this.nudSX_Y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudDX_Y
            // 
            this.nudDX_Y.Location = new System.Drawing.Point(74, 76);
            this.nudDX_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDX_Y.Name = "nudDX_Y";
            this.nudDX_Y.Size = new System.Drawing.Size(52, 20);
            this.nudDX_Y.TabIndex = 10;
            this.nudDX_Y.Value = new decimal(new int[] {
            964,
            0,
            0,
            0});
            // 
            // nudDX_X
            // 
            this.nudDX_X.Location = new System.Drawing.Point(16, 76);
            this.nudDX_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDX_X.Name = "nudDX_X";
            this.nudDX_X.Size = new System.Drawing.Size(52, 20);
            this.nudDX_X.TabIndex = 9;
            this.nudDX_X.Value = new decimal(new int[] {
            1712,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Punto basso dx";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(70, 108);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(57, 22);
            this.btnLista.TabIndex = 11;
            this.btnLista.Text = "Processi";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCoord
            // 
            this.btnCoord.Location = new System.Drawing.Point(81, 12);
            this.btnCoord.Name = "btnCoord";
            this.btnCoord.Size = new System.Drawing.Size(45, 22);
            this.btnCoord.TabIndex = 12;
            this.btnCoord.Text = "Selez.";
            this.btnCoord.UseVisualStyleBackColor = true;
            this.btnCoord.Click += new System.EventHandler(this.btnCoord_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Processo";
            // 
            // tbxProcesso
            // 
            this.tbxProcesso.Location = new System.Drawing.Point(16, 133);
            this.tbxProcesso.Name = "tbxProcesso";
            this.tbxProcesso.Size = new System.Drawing.Size(110, 20);
            this.tbxProcesso.TabIndex = 15;
            this.tbxProcesso.Text = "DigitalEditions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Processo titolo";
            // 
            // tbxProcessoTitolo
            // 
            this.tbxProcessoTitolo.Location = new System.Drawing.Point(16, 172);
            this.tbxProcessoTitolo.Name = "tbxProcessoTitolo";
            this.tbxProcessoTitolo.Size = new System.Drawing.Size(110, 20);
            this.tbxProcessoTitolo.TabIndex = 13;
            this.tbxProcessoTitolo.Text = "Adobe Digital Editions";
            // 
            // nudContatore
            // 
            this.nudContatore.Location = new System.Drawing.Point(16, 315);
            this.nudContatore.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudContatore.Name = "nudContatore";
            this.nudContatore.Size = new System.Drawing.Size(110, 20);
            this.nudContatore.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contatore";
            // 
            // btnApri
            // 
            this.btnApri.Location = new System.Drawing.Point(81, 202);
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(46, 22);
            this.btnApri.TabIndex = 20;
            this.btnApri.Text = "Apri";
            this.btnApri.UseVisualStyleBackColor = true;
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Invia tasto";
            // 
            // tbxTasto
            // 
            this.tbxTasto.Location = new System.Drawing.Point(16, 354);
            this.tbxTasto.Name = "tbxTasto";
            this.tbxTasto.Size = new System.Drawing.Size(110, 20);
            this.tbxTasto.TabIndex = 21;
            this.tbxTasto.Text = "{PGDN}";
            // 
            // frmCattura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 440);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxTasto);
            this.Controls.Add(this.btnApri);
            this.Controls.Add(this.nudContatore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxProcesso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxProcessoTitolo);
            this.Controls.Add(this.btnCoord);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.nudDX_Y);
            this.Controls.Add(this.nudDX_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudSX_Y);
            this.Controls.Add(this.nudSX_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCartella);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrefisso);
            this.Controls.Add(this.btnSalva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCattura";
            this.Text = "Cattura";
            ((System.ComponentModel.ISupportInitialize)(this.nudSX_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDX_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDX_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContatore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox tbxPrefisso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCartella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSX_X;
        private System.Windows.Forms.NumericUpDown nudSX_Y;
        private System.Windows.Forms.NumericUpDown nudDX_Y;
        private System.Windows.Forms.NumericUpDown nudDX_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCoord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProcesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxProcessoTitolo;
        private System.Windows.Forms.NumericUpDown nudContatore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTasto;
    }
}

