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
    public partial class FormClasse : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormClasse()
        {
            InitializeComponent();
            
            dataGridClasse.DataSource = context.Classe.ToList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Classe c = new Classe();
            c.libelle = cmbniveau.Text + cmbspecialite.Text;
            c.specilaite = cmbspecialite.Text;
            c.niveau = cmbniveau.Text;
            context.Classe.Add(c);
            context.SaveChanges();

            MessageBox.Show("Classe enregistrer");
            dataGridClasse.DataSource = context.Classe.ToList();

        }
    }
}
