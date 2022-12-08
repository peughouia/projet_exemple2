using ManageCourseAPP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCourseAPP.Entity;

namespace ManageCourseAPP.Resources
{
    public partial class Frm_Add_Student : Form
    {
        ApprenantService apprenantService;
        public Frm_Add_Student()
        {
            InitializeComponent();
            apprenantService= new ApprenantService();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Are you sure you want to close this window?",
                "Close windows",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            try
            {
                apprenantService.CreateApprenant(new Apprenant(txtNom.Text,txtprenom.Text,classe:,parent:));
            }catch(Exception ex)
            {

            }

        }
    }
}
