using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCourseAPP.DAL;
using ManageCourseAPP.Entity;
using ManageCourseAPP.Service;


namespace ManageCourseAPP.View
{
    public partial class Frm_Add_Class : Form
    {
        ClasseService classeService;
        public Frm_Add_Class()
        {
            InitializeComponent();
            classeService= new ClasseService();
        }

        private void bnt_reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClass.Text != string.Empty)
                {
                    classeService.CreateClasse(new Classe(txtClass.Text));
                    MessageBox.Show("classe add success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("veuillez renseigner le champ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
