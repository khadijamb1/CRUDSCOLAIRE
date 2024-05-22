using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSCOLAIRE
{
    public partial class FormEtudiantListe : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormEtudiantListe()
        {
            InitializeComponent();
            LoadEtudiants();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEtudiants()
        {
            dataGridEtudiant.DataSource = context.Etudiant.ToList();
        }

        private void FormEtudiantListe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReportEtudiant formReportEtudiant = new FormReportEtudiant();
            formReportEtudiant.Show();
        }
    }
}
