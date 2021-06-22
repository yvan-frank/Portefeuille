namespace iPorfolio.Views.Controls
{
    partial class Datacontrol
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbAvancement = new Guna.UI.WinForms.GunaLabel();
            this.lbDebut = new Guna.UI.WinForms.GunaLabel();
            this.lbDuree = new Guna.UI.WinForms.GunaLabel();
            this.lbChef = new Guna.UI.WinForms.GunaLabel();
            this.lbCout = new Guna.UI.WinForms.GunaLabel();
            this.lbNom = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaLinePanel1.Controls.Add(this.lbAvancement);
            this.gunaLinePanel1.Controls.Add(this.lbDebut);
            this.gunaLinePanel1.Controls.Add(this.lbDuree);
            this.gunaLinePanel1.Controls.Add(this.lbChef);
            this.gunaLinePanel1.Controls.Add(this.lbCout);
            this.gunaLinePanel1.Controls.Add(this.lbNom);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(917, 42);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // lbAvancement
            // 
            this.lbAvancement.AutoSize = true;
            this.lbAvancement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbAvancement.ForeColor = System.Drawing.Color.Navy;
            this.lbAvancement.Location = new System.Drawing.Point(601, 5);
            this.lbAvancement.Name = "lbAvancement";
            this.lbAvancement.Size = new System.Drawing.Size(106, 21);
            this.lbAvancement.TabIndex = 1;
            this.lbAvancement.Text = "Avancement";
            // 
            // lbDebut
            // 
            this.lbDebut.AutoSize = true;
            this.lbDebut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbDebut.ForeColor = System.Drawing.Color.Navy;
            this.lbDebut.Location = new System.Drawing.Point(442, 5);
            this.lbDebut.Name = "lbDebut";
            this.lbDebut.Size = new System.Drawing.Size(120, 21);
            this.lbDebut.TabIndex = 6;
            this.lbDebut.Text = "Date de Debut";
            // 
            // lbDuree
            // 
            this.lbDuree.AutoSize = true;
            this.lbDuree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbDuree.ForeColor = System.Drawing.Color.Navy;
            this.lbDuree.Location = new System.Drawing.Point(242, 5);
            this.lbDuree.Name = "lbDuree";
            this.lbDuree.Size = new System.Drawing.Size(122, 21);
            this.lbDuree.TabIndex = 5;
            this.lbDuree.Text = "Nom du projet";
            // 
            // lbChef
            // 
            this.lbChef.AutoSize = true;
            this.lbChef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbChef.ForeColor = System.Drawing.Color.Navy;
            this.lbChef.Location = new System.Drawing.Point(23, 5);
            this.lbChef.Name = "lbChef";
            this.lbChef.Size = new System.Drawing.Size(118, 21);
            this.lbChef.TabIndex = 4;
            this.lbChef.Text = "Chef de projet";
            // 
            // lbCout
            // 
            this.lbCout.AutoSize = true;
            this.lbCout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbCout.ForeColor = System.Drawing.Color.Navy;
            this.lbCout.Location = new System.Drawing.Point(759, 5);
            this.lbCout.Name = "lbCout";
            this.lbCout.Size = new System.Drawing.Size(46, 21);
            this.lbCout.TabIndex = 2;
            this.lbCout.Text = "Cout";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbNom.ForeColor = System.Drawing.Color.Navy;
            this.lbNom.Location = new System.Drawing.Point(153, 6);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(73, 21);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Numero";
            // 
            // Datacontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "Datacontrol";
            this.Size = new System.Drawing.Size(917, 42);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaLabel lbAvancement;
        public Guna.UI.WinForms.GunaLabel lbDebut;
        public Guna.UI.WinForms.GunaLabel lbDuree;
        public Guna.UI.WinForms.GunaLabel lbChef;
        public Guna.UI.WinForms.GunaLabel lbCout;
        public Guna.UI.WinForms.GunaLabel lbNom;
    }
}