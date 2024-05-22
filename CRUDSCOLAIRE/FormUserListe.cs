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
    public partial class FormUserListe : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormUserListe()
        {
            InitializeComponent();
            LoadUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReportUser formReportUser = new FormReportUser();
            formReportUser.Show();
        }
        private void LoadUser()
        {
            dataGridUser.DataSource = context.User.ToList();
        }

        private void FormUserListe_Load(object sender, EventArgs e)
        {

        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
