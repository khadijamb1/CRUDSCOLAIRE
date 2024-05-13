using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSCOLAIRE
{
    public partial class FormEtudiant : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormEtudiant()
        {
            InitializeComponent();
            cmbclasse.DataSource = context.Classe.ToList();
            cmbclasse.DisplayMember = "libelle";
            cmbclasse.ValueMember = "id";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnajout_Click(object sender, EventArgs e)
        {

            Etudiant et = new Etudiant();
            et.prenom = txtprenom.Text;
            et.nom = txtnom.Text;
            et.credit = int.Parse(txtcredit.Text);
            et.reglement = int.Parse(txtreglement.Text); ;
            et.anneescol= txtannee.Text;
            et.idClasse=Convert.ToInt32(cmbclasse.SelectedIndex);
            context.Etudiant.Add(et);
            context.SaveChanges();
            MessageBox.Show("Etudiant Ajouter !!");
            RefreshData();





        }

        private void bntupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridEtudiant.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedStudentId = (int)dataGridEtudiant.SelectedRows[0].Cells["Id"].Value;
                Etudiant etudiant = context.Etudiant.FirstOrDefault(et => et.id == selectedStudentId);
                if (etudiant != null)
                {
                    try
                    {
                        context.Etudiant.Remove(etudiant);
                        context.SaveChanges();
                        MessageBox.Show("Étudiant supprimé avec succès !");
                        RefreshData();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression de l'étudiant : {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Étudiant non trouvé dans la base de données.");
                }
            }
        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {

            gestionecoleEntities context = new gestionecoleEntities();

            dataGridEtudiant.DataSource = context.Etudiant.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           string classeLibelle = txtSearchClasse.Text;
            string anneeScolaire = txtSearchAnnee.Text;
            RefreshData(classeLibelle, anneeScolaire);
        }
        private void RefreshData(string classeLibelle = null, string anneeScolaire = null)
        {
            gestionecoleEntities context = new gestionecoleEntities();
            IQueryable<Etudiant> query = context.Etudiant;

            // Filtrer par libellé de classe si fourni
            if (!string.IsNullOrEmpty(classeLibelle))
            {
                query = query.Where(et => et.Classe.libelle.Contains(classeLibelle));
            }

            // Filtrer par année scolaire si fournie
            if (!string.IsNullOrEmpty(anneeScolaire))
            {
                query = query.Where(et => et.anneescol.Contains(anneeScolaire));
            }

            dataGridEtudiant.DataSource = query.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
