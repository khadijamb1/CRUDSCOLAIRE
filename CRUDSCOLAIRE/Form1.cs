using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSCOLAIRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse formClasse = new FormClasse();
            
            formClasse.Show();
        }

        private void etudantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtudiant formEtudiant = new FormEtudiant();
            formEtudiant.Show();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
        }
    }
}
