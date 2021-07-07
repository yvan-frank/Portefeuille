using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Controls
{
    public partial class DeleteControl : UserControl
    {
        public string P { get; }
        public DeleteControl()
        {
            InitializeComponent();
        }
        public DeleteControl(string p)
        {
            InitializeComponent();
            this.P = p;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectController controller = new ProjectController();
                EvaluationController ev = new EvaluationController();
                foreach (ProjectModel model in controller.GetAll(int.Parse(P)))
                {
                    string[] number = { model.NumberProject };


                    for (int i = 0; i < 1; i++)
                    {
                        var j = i;
                        btnDelete.Invoke(new Action((() =>
                        {
                            if (lblNum.Text.Equals(number[j]))
                            {
                                if (controller.DeleteProject(lblNum.Text) > 0 && ev.DeleteEvaluation(lblNum.Text) > 0)
                                {
                                    if (MessageBox.Show(@"Projet retiré du porfeuille",
                                        @"Information relative a la suppression", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information) == DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                }
                            }
                        })));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue pendant la suppression" , "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }
    }
}