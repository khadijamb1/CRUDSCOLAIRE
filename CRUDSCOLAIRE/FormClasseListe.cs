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

    public partial class FormClasseListe : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormClasseListe()
        {
            InitializeComponent();
            LoadClasses();
        }

        private void FormClasseListe_Load(object sender, EventArgs e)
        {

        }
        private void LoadClasses()
        {
            dataGridClasse.DataSource = context.Etudiant.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {FormReportClasse formReportClasse = new FormReportClasse();
            formReportClasse.Show();
        }
    }
}
