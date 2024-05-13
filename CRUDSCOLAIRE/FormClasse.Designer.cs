namespace CRUDSCOLAIRE
{
    partial class FormClasse
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridClasse = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbspecialite = new System.Windows.Forms.ComboBox();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ajout Classe";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnadd.Location = new System.Drawing.Point(70, 350);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(225, 59);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Enregistrer";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridClasse
            // 
            this.dataGridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasse.Location = new System.Drawing.Point(428, 64);
            this.dataGridClasse.Name = "dataGridClasse";
            this.dataGridClasse.RowHeadersWidth = 62;
            this.dataGridClasse.RowTemplate.Height = 28;
            this.dataGridClasse.Size = new System.Drawing.Size(484, 362);
            this.dataGridClasse.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Specilatite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Niveau";
            // 
            // cmbspecialite
            // 
            this.cmbspecialite.FormattingEnabled = true;
            this.cmbspecialite.Items.AddRange(new object[] {
            "IAGE",
            "GL",
            "AD",
            "MULTIMEDIA",
            "FC"});
            this.cmbspecialite.Location = new System.Drawing.Point(137, 210);
            this.cmbspecialite.Name = "cmbspecialite";
            this.cmbspecialite.Size = new System.Drawing.Size(212, 28);
            this.cmbspecialite.TabIndex = 11;
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2",
            "M3"});
            this.cmbniveau.Location = new System.Drawing.Point(137, 86);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(212, 28);
            this.cmbniveau.TabIndex = 10;
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbspecialite);
            this.Controls.Add(this.cmbniveau);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridClasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbspecialite;
        private System.Windows.Forms.ComboBox cmbniveau;
    }
}