using ManageCourseAPP.Resources;
using ManageCourseAPP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCourseAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           var dialogResult= MessageBox.Show(
                "Are you sure you want to close application?",
                "Close Application",
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

        private void btn_Add_Teacher_Click(object sender, EventArgs e)
        {
            Frm_list_Teacher frm =new Frm_list_Teacher() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel3.Controls.Add(frm);
            frm.Show();
        }


        private void btn_Add_Cours_Click(object sender, EventArgs e)
        {
            Frm_Add_Course frm = new Frm_Add_Course() { TopLevel=false, TopMost=true };
            frm.FormBorderStyle= FormBorderStyle.None;
            panel3.Controls.Add(frm);
            frm.Show();

        }

        private void btn_Add_student_Click(object sender, EventArgs e)
        {
            Frm_list_student frm = new Frm_list_student() { TopLevel=false, TopMost= true };
            frm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }    
}
