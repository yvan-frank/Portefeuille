namespace iPorfolio.Views.Home
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEvaluation = new Guna.UI2.WinForms.Guna2Button();
            this.btndeconnexion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExecutive = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnProjet = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panContainer = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblPortefeuille = new Guna.UI2.WinForms.Guna2Chip();
            this.btnRetour = new Guna.UI2.WinForms.Guna2Button();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHeader.BackColor = System.Drawing.Color.White;
            this.panHeader.Controls.Add(this.btnRetour);
            this.panHeader.Controls.Add(this.lblPortefeuille);
            this.panHeader.Controls.Add(this.pictureBox1);
            this.panHeader.Controls.Add(this.btnEvaluation);
            this.panHeader.Controls.Add(this.btndeconnexion);
            this.panHeader.Controls.Add(this.btnExecutive);
            this.panHeader.Controls.Add(this.btnDashboard);
            this.panHeader.Controls.Add(this.btnProjet);
            this.panHeader.Controls.Add(this.guna2ControlBox1);
            this.panHeader.Controls.Add(this.guna2ControlBox2);
            this.panHeader.Controls.Add(this.btnClose);
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1093, 38);
            this.panHeader.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEvaluation.CheckedState.Parent = this.btnEvaluation;
            this.btnEvaluation.CustomImages.Parent = this.btnEvaluation;
            this.btnEvaluation.DisabledState.Parent = this.btnEvaluation;
            this.btnEvaluation.FillColor = System.Drawing.Color.White;
            this.btnEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluation.ForeColor = System.Drawing.Color.Black;
            this.btnEvaluation.HoverState.Parent = this.btnEvaluation;
            this.btnEvaluation.Location = new System.Drawing.Point(233, 4);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.ShadowDecoration.Parent = this.btnEvaluation;
            this.btnEvaluation.Size = new System.Drawing.Size(92, 31);
            this.btnEvaluation.TabIndex = 10;
            this.btnEvaluation.Text = "Evaluation du portefeuille";
            this.btnEvaluation.Click += new System.EventHandler(this.BtnEvaluation_Click);
            // 
            // btndeconnexion
            // 
            this.btndeconnexion.ActiveBorderThickness = 1;
            this.btndeconnexion.ActiveCornerRadius = 20;
            this.btndeconnexion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btndeconnexion.ActiveForecolor = System.Drawing.Color.White;
            this.btndeconnexion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeconnexion.BackColor = System.Drawing.Color.White;
            this.btndeconnexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndeconnexion.BackgroundImage")));
            this.btndeconnexion.ButtonText = "Déconnexion";
            this.btndeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeconnexion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeconnexion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndeconnexion.IdleBorderThickness = 1;
            this.btndeconnexion.IdleCornerRadius = 20;
            this.btndeconnexion.IdleFillColor = System.Drawing.Color.White;
            this.btndeconnexion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndeconnexion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndeconnexion.Location = new System.Drawing.Point(866, 3);
            this.btndeconnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndeconnexion.Name = "btndeconnexion";
            this.btndeconnexion.Size = new System.Drawing.Size(93, 32);
            this.btndeconnexion.TabIndex = 0;
            this.btndeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndeconnexion.Click += new System.EventHandler(this.Btndeconnexion_Click);
            // 
            // btnExecutive
            // 
            this.btnExecutive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExecutive.CheckedState.Parent = this.btnExecutive;
            this.btnExecutive.CustomImages.Parent = this.btnExecutive;
            this.btnExecutive.DisabledState.Parent = this.btnExecutive;
            this.btnExecutive.FillColor = System.Drawing.Color.White;
            this.btnExecutive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutive.ForeColor = System.Drawing.Color.Black;
            this.btnExecutive.HoverState.Parent = this.btnExecutive;
            this.btnExecutive.Location = new System.Drawing.Point(331, 3);
            this.btnExecutive.Name = "btnExecutive";
            this.btnExecutive.ShadowDecoration.Parent = this.btnExecutive;
            this.btnExecutive.Size = new System.Drawing.Size(82, 31);
            this.btnExecutive.TabIndex = 8;
            this.btnExecutive.Text = "Executive Dashboard";
            this.btnExecutive.Click += new System.EventHandler(this.BtnExecutive_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.DisabledState.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(148, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(73, 31);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Tableaux de bord";
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProjet.CheckedState.Parent = this.btnProjet;
            this.btnProjet.CustomImages.Parent = this.btnProjet;
            this.btnProjet.DisabledState.Parent = this.btnProjet;
            this.btnProjet.FillColor = System.Drawing.Color.White;
            this.btnProjet.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnProjet.ForeColor = System.Drawing.Color.Black;
            this.btnProjet.HoverState.Parent = this.btnProjet;
            this.btnProjet.Location = new System.Drawing.Point(66, 4);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.ShadowDecoration.Parent = this.btnProjet;
            this.btnProjet.Size = new System.Drawing.Size(79, 31);
            this.btnProjet.TabIndex = 0;
            this.btnProjet.Text = "Projets";
            this.btnProjet.Click += new System.EventHandler(this.BtnProjet_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(966, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(41, 34);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1007, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(41, 34);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1048, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panContainer
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.Location = new System.Drawing.Point(0, 41);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(1090, 607);
            this.panContainer.TabIndex = 4;
            this.panContainer.Resize += new System.EventHandler(this.PanContainer_Resize);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-1, 39);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1108, 7);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // lblPortefeuille
            // 
            this.lblPortefeuille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortefeuille.AutoRoundedCorners = true;
            this.lblPortefeuille.BorderRadius = 14;
            this.lblPortefeuille.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPortefeuille.ForeColor = System.Drawing.Color.White;
            this.lblPortefeuille.IsClosable = false;
            this.lblPortefeuille.Location = new System.Drawing.Point(514, 5);
            this.lblPortefeuille.Name = "lblPortefeuille";
            this.lblPortefeuille.ShadowDecoration.Parent = this.lblPortefeuille;
            this.lblPortefeuille.Size = new System.Drawing.Size(142, 30);
            this.lblPortefeuille.TabIndex = 0;
            this.lblPortefeuille.Text = "portefeuille";
            // 
            // btnRetour
            // 
            this.btnRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetour.Animated = true;
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BorderColor = System.Drawing.Color.White;
            this.btnRetour.BorderRadius = 10;
            this.btnRetour.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnRetour.BorderThickness = 1;
            this.btnRetour.CheckedState.Parent = this.btnRetour;
            this.btnRetour.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRetour.CustomImages.Parent = this.btnRetour;
            this.btnRetour.DisabledState.Parent = this.btnRetour;
            this.btnRetour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRetour.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRetour.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRetour.HoverState.Parent = this.btnRetour;
            this.btnRetour.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRetour.Location = new System.Drawing.Point(662, 4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.ShadowDecoration.Parent = this.btnRetour;
            this.btnRetour.Size = new System.Drawing.Size(197, 32);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour à la sélection";
            this.btnRetour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRetour.TextOffset = new System.Drawing.Point(38, 0);
            this.btnRetour.UseTransparentBackground = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1091, 650);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panHeader);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Portfolio management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnExecutive;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnProjet;
        private Bunifu.Framework.UI.BunifuThinButton2 btndeconnexion;
        private System.Windows.Forms.Panel panContainer;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnEvaluation;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2Chip lblPortefeuille;
        private Guna.UI2.WinForms.Guna2Button btnRetour;
    }
}