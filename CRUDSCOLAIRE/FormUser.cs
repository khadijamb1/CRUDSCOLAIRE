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
    public partial class FormUser : Form
    {
        gestionecoleEntities context = new gestionecoleEntities();
        public FormUser()
        {
            InitializeComponent();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
           
        {
            User user = new User();
            user.login = txtlog.Text;
            user.password = txtlog.Text;
            context.User.Add(user);
            context.SaveChanges();
            MessageBox.Show("User Ajouter !!");
            ReshData();

        }
        private void ReshData()
        {
            gestionecoleEntities context = new gestionecoleEntities();
            dataGridUser.DataSource = context.User.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtlog.Text = "";
            textpasswd.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridUser.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    int userId = (int)dataGridUser.Rows[selectedIndex].Cells["Id"].Value;
                    User userToDelete = context.User.FirstOrDefault(u => u.id == userId);
                    if (userToDelete != null)
                    {
                        context.User.Remove(userToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Utilisateur supprimé !");
                        ReshData();

                    }
                    else
                    {
                        MessageBox.Show("Impossible de trouver l'utilisateur à supprimer.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }
    }
}
    

