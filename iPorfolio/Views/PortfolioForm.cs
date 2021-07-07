using System;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Controls;
using Models;

namespace iPorfolio.Views
{
    public partial class PortfolioForm : Form
    {
        public PortfolioForm()
        {
            InitializeComponent();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PortfolioForm_Load(object sender, EventArgs e)
        {
           LoadPortfolio();
           var p = new ShowPortfolioListControl();
           //flowLayoutPanel1.Controls.Add(p);
        }

        private void LoadPortfolio()
        {
            PortfolioController c = new PortfolioController();

            foreach (PortfolioModel model in c.GetAll())
            {
                string[] id = new[] { model.IdPortfolio };
                string[] denominate = new[] { model.Denominate };
                string[] strategy = new[] { model.ObjectiveList };
                string[] mission = new[] { model.MissionList };
                string[] cost = new[] { model.Cost.ToString() };

                for (int i = 0; i < 1; i++)
                {
                    var port = new ShowPortfolioListControl();
                    port.Dock = DockStyle.Top;
                    port.lbldenominate.Text = denominate[i];
                    port.lblNump.Text = id[i];
                    port.lblCount.Text = cost[i];

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(port);
                    }
                }
            }

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                panel1.BringToFront();
            }
            
            panel1.Visible = true;

        }

       

        PortfolioController portfolioController = new PortfolioController();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtDenomi.Text.Equals(string.Empty) && txtMission.Text.Equals(string.Empty) &&
                txtCost.Text.Equals(string.Empty) && txtStrategi.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                PortfolioModel model = new PortfolioModel();

                model.Denominate = txtDenomi.Text;
                model.Cost = int.Parse(txtCost.Text);
                model.MissionList = txtMission.Text;
                model.ObjectiveList = txtStrategi.Text;

                if (portfolioController.Create(model) > 0)
                {
                    MessageBox.Show(@"Insert successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(panel1);
                    LoadPortfolio();
                }
                else
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
        }
    }
}
