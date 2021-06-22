namespace iPorfolio.Views.Controls
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbDateCible = new Guna.UI.WinForms.GunaLabel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.affecterLesRessourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAvancement = new Guna.UI.WinForms.GunaLabel();
            this.lbDebut = new Guna.UI.WinForms.GunaLabel();
            this.lblNm = new Guna.UI.WinForms.GunaLabel();
            this.lbChef = new Guna.UI.WinForms.GunaLabel();
            this.lbCout = new Guna.UI.WinForms.GunaLabel();
            this.lbNom = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lbDateCible);
            this.gunaLinePanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaLinePanel1.Controls.Add(this.lbAvancement);
            this.gunaLinePanel1.Controls.Add(this.lbDebut);
            this.gunaLinePanel1.Controls.Add(this.lblNm);
            this.gunaLinePanel1.Controls.Add(this.lbChef);
            this.gunaLinePanel1.Controls.Add(this.lbCout);
            this.gunaLinePanel1.Controls.Add(this.lbNom);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(864, 43);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lbDateCible
            // 
            this.lbDateCible.AutoSize = true;
            this.lbDateCible.BackColor = System.Drawing.Color.DarkGreen;
            this.lbDateCible.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbDateCible.ForeColor = System.Drawing.Color.White;
            this.lbDateCible.Location = new System.Drawing.Point(444, 28);
            this.lbDateCible.Name = "lbDateCible";
            this.lbDateCible.Size = new System.Drawing.Size(58, 13);
            this.lbDateCible.TabIndex = 10;
            this.lbDateCible.Text = "Date cible";
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.Image")));
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaCircleButton1.Location = new System.Drawing.Point(835, 4);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.OnHoverImage")));
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(25, 25);
            this.gunaCircleButton1.TabIndex = 9;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affecterLesRessourcesToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(192, 48);
            // 
            // affecterLesRessourcesToolStripMenuItem
            // 
            this.affecterLesRessourcesToolStripMenuItem.Name = "affecterLesRessourcesToolStripMenuItem";
            this.affecterLesRessourcesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.affecterLesRessourcesToolStripMenuItem.Text = "Affecter les ressources";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // lbAvancement
            // 
            this.lbAvancement.AutoSize = true;
            this.lbAvancement.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbAvancement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lbAvancement.Location = new System.Drawing.Point(628, 12);
            this.lbAvancement.Name = "lbAvancement";
            this.lbAvancement.Size = new System.Drawing.Size(72, 13);
            this.lbAvancement.TabIndex = 1;
            this.lbAvancement.Text = "Avancement";
            // 
            // lbDebut
            // 
            this.lbDebut.AutoSize = true;
            this.lbDebut.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lbDebut.Location = new System.Drawing.Point(444, 12);
            this.lbDebut.Name = "lbDebut";
            this.lbDebut.Size = new System.Drawing.Size(82, 13);
            this.lbDebut.TabIndex = 6;
            this.lbDebut.Text = "Date de Debut";
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblNm.Location = new System.Drawing.Point(238, 12);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(84, 13);
            this.lblNm.TabIndex = 5;
            this.lblNm.Text = "Nom du projet";
            // 
            // lbChef
            // 
            this.lbChef.AutoSize = true;
            this.lbChef.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbChef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lbChef.Location = new System.Drawing.Point(34, 12);
            this.lbChef.Name = "lbChef";
            this.lbChef.Size = new System.Drawing.Size(81, 13);
            this.lbChef.TabIndex = 4;
            this.lbChef.Text = "Chef de projet";
            // 
            // lbCout
            // 
            this.lbCout.AutoSize = true;
            this.lbCout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbCout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lbCout.Location = new System.Drawing.Point(760, 12);
            this.lbCout.Name = "lbCout";
            this.lbCout.Size = new System.Drawing.Size(32, 13);
            this.lbCout.TabIndex = 2;
            this.lbCout.Text = "Cout";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lbNom.Location = new System.Drawing.Point(152, 13);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(50, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Numero";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(864, 43);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        public Guna.UI.WinForms.GunaLabel lbAvancement;
        public Guna.UI.WinForms.GunaLabel lbDebut;
        public Guna.UI.WinForms.GunaLabel lblNm;
        public Guna.UI.WinForms.GunaLabel lbChef;
        public Guna.UI.WinForms.GunaLabel lbCout;
        public Guna.UI.WinForms.GunaLabel lbNom;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaLabel lbDateCible;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affecterLesRessourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
