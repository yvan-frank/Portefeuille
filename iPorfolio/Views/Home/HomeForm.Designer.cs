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
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExecutive = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnProjet = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panContainer = new System.Windows.Forms.Panel();
            this.btnCriteria = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnScenario = new Bunifu.Framework.UI.BunifuTileButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHeader.BackColor = System.Drawing.Color.White;
            this.panHeader.Controls.Add(this.pictureBox1);
            this.panHeader.Controls.Add(this.btnEvaluation);
            this.panHeader.Controls.Add(this.bunifuThinButton21);
            this.panHeader.Controls.Add(this.btnExecutive);
            this.panHeader.Controls.Add(this.btnDashboard);
            this.panHeader.Controls.Add(this.btnProjet);
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Controls.Add(this.guna2ControlBox1);
            this.panHeader.Controls.Add(this.guna2ControlBox2);
            this.panHeader.Controls.Add(this.btnClose);
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1002, 38);
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
            this.btnEvaluation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEvaluation.ForeColor = System.Drawing.Color.Black;
            this.btnEvaluation.HoverState.Parent = this.btnEvaluation;
            this.btnEvaluation.Location = new System.Drawing.Point(341, 4);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.ShadowDecoration.Parent = this.btnEvaluation;
            this.btnEvaluation.Size = new System.Drawing.Size(238, 31);
            this.btnEvaluation.TabIndex = 10;
            this.btnEvaluation.Text = "Evaluation du portefeuille";
            this.btnEvaluation.Click += new System.EventHandler(this.BtnEvaluation_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Aide";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(805, 4);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(40, 28);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExecutive
            // 
            this.btnExecutive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutive.CheckedState.Parent = this.btnExecutive;
            this.btnExecutive.CustomImages.Parent = this.btnExecutive;
            this.btnExecutive.DisabledState.Parent = this.btnExecutive;
            this.btnExecutive.FillColor = System.Drawing.Color.White;
            this.btnExecutive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExecutive.ForeColor = System.Drawing.Color.Black;
            this.btnExecutive.HoverState.Parent = this.btnExecutive;
            this.btnExecutive.Location = new System.Drawing.Point(592, 6);
            this.btnExecutive.Name = "btnExecutive";
            this.btnExecutive.ShadowDecoration.Parent = this.btnExecutive;
            this.btnExecutive.Size = new System.Drawing.Size(148, 31);
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
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(194, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(152, 31);
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
            this.btnProjet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProjet.ForeColor = System.Drawing.Color.Black;
            this.btnProjet.HoverState.Parent = this.btnProjet;
            this.btnProjet.Location = new System.Drawing.Point(79, 4);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.ShadowDecoration.Parent = this.btnProjet;
            this.btnProjet.Size = new System.Drawing.Size(82, 31);
            this.btnProjet.TabIndex = 0;
            this.btnProjet.Text = "Projets";
            this.btnProjet.Click += new System.EventHandler(this.BtnProjet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project portfolio";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(875, 3);
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(916, 3);
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
            this.btnClose.Location = new System.Drawing.Point(957, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 34);
            this.btnClose.TabIndex = 3;
            // 
            // panContainer
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.Controls.Add(this.btnCriteria);
            this.panContainer.Controls.Add(this.btnScenario);
            this.panContainer.Location = new System.Drawing.Point(0, 41);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(999, 607);
            this.panContainer.TabIndex = 4;
            this.panContainer.Resize += new System.EventHandler(this.PanContainer_Resize);
            // 
            // btnCriteria
            // 
            this.btnCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriteria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCriteria.color = System.Drawing.Color.SeaGreen;
            this.btnCriteria.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCriteria.ForeColor = System.Drawing.Color.White;
            this.btnCriteria.Image = ((System.Drawing.Image)(resources.GetObject("btnCriteria.Image")));
            this.btnCriteria.ImagePosition = 20;
            this.btnCriteria.ImageZoom = 50;
            this.btnCriteria.LabelPosition = 41;
            this.btnCriteria.LabelText = "A partir des critères";
            this.btnCriteria.Location = new System.Drawing.Point(599, 201);
            this.btnCriteria.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(302, 214);
            this.btnCriteria.TabIndex = 1;
            this.btnCriteria.Visible = false;
            this.btnCriteria.Click += new System.EventHandler(this.BtnCriteria_Click);
            // 
            // btnScenario
            // 
            this.btnScenario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScenario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnScenario.color = System.Drawing.Color.SeaGreen;
            this.btnScenario.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnScenario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnScenario.ForeColor = System.Drawing.Color.White;
            this.btnScenario.Image = ((System.Drawing.Image)(resources.GetObject("btnScenario.Image")));
            this.btnScenario.ImagePosition = 20;
            this.btnScenario.ImageZoom = 50;
            this.btnScenario.LabelPosition = 41;
            this.btnScenario.LabelText = "A partir d\'un scénario existant";
            this.btnScenario.Location = new System.Drawing.Point(103, 201);
            this.btnScenario.Margin = new System.Windows.Forms.Padding(6);
            this.btnScenario.Name = "btnScenario";
            this.btnScenario.Size = new System.Drawing.Size(302, 214);
            this.btnScenario.TabIndex = 0;
            this.btnScenario.Visible = false;
            this.btnScenario.Click += new System.EventHandler(this.BtnScenario_Click);
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
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(997, 7);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panHeader);
            this.DisplayHeader = false;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Portfolio management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExecutive;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnProjet;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panContainer;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnEvaluation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnCriteria;
        private Bunifu.Framework.UI.BunifuTileButton btnScenario;
    }
}