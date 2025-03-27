namespace Uefa_league
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
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnInvio = new System.Windows.Forms.Button();
            this.selAwayGol = new System.Windows.Forms.NumericUpDown();
            this.selHomeGol = new System.Windows.Forms.NumericUpDown();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtHomeName = new System.Windows.Forms.TextBox();
            this.txtAwayName = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoSquadramaxgol = new System.Windows.Forms.RadioButton();
            this.rdoTotgoal = new System.Windows.Forms.RadioButton();
            this.rdoPartitamaxgoal = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selAwayGol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selHomeGol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlResults.Controls.Add(this.btnInvio);
            this.pnlResults.Controls.Add(this.selAwayGol);
            this.pnlResults.Controls.Add(this.selHomeGol);
            this.pnlResults.Controls.Add(this.lblAway);
            this.pnlResults.Controls.Add(this.lblHome);
            this.pnlResults.Controls.Add(this.txtHomeName);
            this.pnlResults.Controls.Add(this.txtAwayName);
            this.pnlResults.Location = new System.Drawing.Point(68, 84);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(481, 65);
            this.pnlResults.TabIndex = 0;
            // 
            // btnInvio
            // 
            this.btnInvio.Location = new System.Drawing.Point(352, 12);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(115, 39);
            this.btnInvio.TabIndex = 7;
            this.btnInvio.Text = "Aggiungi";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // selAwayGol
            // 
            this.selAwayGol.Location = new System.Drawing.Point(188, 29);
            this.selAwayGol.Name = "selAwayGol";
            this.selAwayGol.Size = new System.Drawing.Size(39, 20);
            this.selAwayGol.TabIndex = 6;
            this.selAwayGol.ValueChanged += new System.EventHandler(this.selAwayGol_ValueChanged);
            // 
            // selHomeGol
            // 
            this.selHomeGol.Location = new System.Drawing.Point(128, 29);
            this.selHomeGol.Name = "selHomeGol";
            this.selHomeGol.Size = new System.Drawing.Size(39, 20);
            this.selHomeGol.TabIndex = 5;
            this.selHomeGol.ValueChanged += new System.EventHandler(this.selHomeGol_ValueChanged);
            // 
            // lblAway
            // 
            this.lblAway.Location = new System.Drawing.Point(233, 8);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(100, 20);
            this.lblAway.TabIndex = 3;
            this.lblAway.Text = "Away";
            this.lblAway.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHome
            // 
            this.lblHome.Location = new System.Drawing.Point(18, 5);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(100, 23);
            this.lblHome.TabIndex = 4;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHomeName
            // 
            this.txtHomeName.Location = new System.Drawing.Point(18, 29);
            this.txtHomeName.Name = "txtHomeName";
            this.txtHomeName.Size = new System.Drawing.Size(100, 20);
            this.txtHomeName.TabIndex = 4;
            this.txtHomeName.TextChanged += new System.EventHandler(this.txtHomeName_TextChanged);
            // 
            // txtAwayName
            // 
            this.txtAwayName.Location = new System.Drawing.Point(236, 28);
            this.txtAwayName.Name = "txtAwayName";
            this.txtAwayName.Size = new System.Drawing.Size(100, 20);
            this.txtAwayName.TabIndex = 0;
            this.txtAwayName.TextChanged += new System.EventHandler(this.txtAwayName_TextChanged);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(68, 174);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(481, 212);
            this.lstResults.TabIndex = 1;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.rdoPartitamaxgoal);
            this.panel1.Controls.Add(this.rdoTotgoal);
            this.panel1.Controls.Add(this.rdoSquadramaxgol);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(615, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 188);
            this.panel1.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Cerca";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoSquadramaxgol
            // 
            this.rdoSquadramaxgol.AutoSize = true;
            this.rdoSquadramaxgol.Location = new System.Drawing.Point(27, 100);
            this.rdoSquadramaxgol.Name = "rdoSquadramaxgol";
            this.rdoSquadramaxgol.Size = new System.Drawing.Size(121, 17);
            this.rdoSquadramaxgol.TabIndex = 9;
            this.rdoSquadramaxgol.TabStop = true;
            this.rdoSquadramaxgol.Text = "Squadra più prolifica";
            this.rdoSquadramaxgol.UseVisualStyleBackColor = true;
            this.rdoSquadramaxgol.CheckedChanged += new System.EventHandler(this.rdoSquadramaxgol_CheckedChanged);
            // 
            // rdoTotgoal
            // 
            this.rdoTotgoal.AutoSize = true;
            this.rdoTotgoal.Location = new System.Drawing.Point(27, 125);
            this.rdoTotgoal.Name = "rdoTotgoal";
            this.rdoTotgoal.Size = new System.Drawing.Size(78, 17);
            this.rdoTotgoal.TabIndex = 10;
            this.rdoTotgoal.TabStop = true;
            this.rdoTotgoal.Text = "Totale goal";
            this.rdoTotgoal.UseVisualStyleBackColor = true;
            this.rdoTotgoal.CheckedChanged += new System.EventHandler(this.rdoTotgoal_CheckedChanged);
            // 
            // rdoPartitamaxgoal
            // 
            this.rdoPartitamaxgoal.AutoSize = true;
            this.rdoPartitamaxgoal.Location = new System.Drawing.Point(27, 150);
            this.rdoPartitamaxgoal.Name = "rdoPartitamaxgoal";
            this.rdoPartitamaxgoal.Size = new System.Drawing.Size(116, 17);
            this.rdoPartitamaxgoal.TabIndex = 11;
            this.rdoPartitamaxgoal.TabStop = true;
            this.rdoPartitamaxgoal.Text = "Partita con più goal";
            this.rdoPartitamaxgoal.UseVisualStyleBackColor = true;
            this.rdoPartitamaxgoal.CheckedChanged += new System.EventHandler(this.rdoPartitamaxgoal_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(174, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calcola";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.pnlResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selAwayGol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selHomeGol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox txtHomeName;
        private System.Windows.Forms.TextBox txtAwayName;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.NumericUpDown selAwayGol;
        private System.Windows.Forms.NumericUpDown selHomeGol;
        private System.Windows.Forms.Button btnInvio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoPartitamaxgoal;
        private System.Windows.Forms.RadioButton rdoTotgoal;
        private System.Windows.Forms.RadioButton rdoSquadramaxgol;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCalculate;
    }
}

