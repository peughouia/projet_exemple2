using ManagerCourse.BLL;
using ManagerCourse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCourse.GUI
{
    public partial class Form1 : Form
    {
        ClasseManager classeManager;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            classeManager = new ClasseManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nomClasse.Text != string.Empty)
                {
                    classeManager.CreateClasse(new Classe(txt_nomClasse.Text));
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
