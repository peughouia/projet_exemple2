namespace ManageCourseAPP.View
{
    partial class Frm_Add_Class
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.bnt_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "register class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(200, 219);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(491, 22);
            this.txtClass.TabIndex = 1;
            // 
            // bnt_reg
            // 
            this.bnt_reg.Location = new System.Drawing.Point(361, 304);
            this.bnt_reg.Name = "bnt_reg";
            this.bnt_reg.Size = new System.Drawing.Size(174, 54);
            this.bnt_reg.TabIndex = 2;
            this.bnt_reg.Text = "register";
            this.bnt_reg.UseVisualStyleBackColor = true;
            this.bnt_reg.Click += new System.EventHandler(this.bnt_reg_Click);
            // 
            // Frm_Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_reg);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Add_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Add_Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button bnt_reg;
    }
}