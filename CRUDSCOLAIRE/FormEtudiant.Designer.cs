namespace CRUDSCOLAIRE
{
    partial class FormEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnajout = new System.Windows.Forms.Button();
            this.dataGridEtudiant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.bntupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchClasse = new System.Windows.Forms.TextBox();
            this.txtSearchAnnee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajout
            // 
            this.btnajout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnajout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajout.Location = new System.Drawing.Point(5, 518);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(246, 67);
            this.btnajout.TabIndex = 15;
            this.btnajout.Text = "Enregistrer";
            this.btnajout.UseVisualStyleBackColor = false;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // dataGridEtudiant
            // 
            this.dataGridEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtudiant.Location = new System.Drawing.Point(279, 102);
            this.dataGridEtudiant.Name = "dataGridEtudiant";
            this.dataGridEtudiant.RowHeadersWidth = 62;
            this.dataGridEtudiant.RowTemplate.Height = 28;
            this.dataGridEtudiant.Size = new System.Drawing.Size(639, 395);
            this.dataGridEtudiant.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Prenom";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(5, 178);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(235, 40);
            this.txtprenom.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(5, 263);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(235, 38);
            this.txtnom.TabIndex = 19;
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(5, 327);
            this.txtcredit.Multiline = true;
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(235, 36);
            this.txtcredit.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reglement";
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(5, 399);
            this.txtreglement.Multiline = true;
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(235, 36);
            this.txtreglement.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "AnneeScolaire";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(5, 461);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(235, 36);
            this.txtannee.TabIndex = 25;
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(12, 110);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(201, 28);
            this.cmbclasse.TabIndex = 26;
            // 
            // bntupdate
            // 
            this.bntupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntupdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntupdate.Location = new System.Drawing.Point(385, 518);
            this.bntupdate.Name = "bntupdate";
            this.bntupdate.Size = new System.Drawing.Size(234, 67);
            this.bntupdate.TabIndex = 27;
            this.bntupdate.Text = "Modifier";
            this.bntupdate.UseVisualStyleBackColor = false;
            this.bntupdate.Click += new System.EventHandler(this.bntupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(714, 518);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(204, 67);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(505, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 56);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Recherche";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchClasse
            // 
            this.txtSearchClasse.Location = new System.Drawing.Point(12, 50);
            this.txtSearchClasse.Multiline = true;
            this.txtSearchClasse.Name = "txtSearchClasse";
            this.txtSearchClasse.Size = new System.Drawing.Size(201, 33);
            this.txtSearchClasse.TabIndex = 31;
            // 
            // txtSearchAnnee
            // 
            this.txtSearchAnnee.Location = new System.Drawing.Point(269, 50);
            this.txtSearchAnnee.Multiline = true;
            this.txtSearchAnnee.Name = "txtSearchAnnee";
            this.txtSearchAnnee.Size = new System.Drawing.Size(209, 33);
            this.txtSearchAnnee.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Recherche par classe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Recherche par annee";
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchAnnee);
            this.Controls.Add(this.txtSearchClasse);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.bntupdate);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.txtannee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtreglement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.dataGridEtudiant);
            this.Controls.Add(this.label1);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.DataGridView dataGridEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.Button bntupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchClasse;
        private System.Windows.Forms.TextBox txtSearchAnnee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}