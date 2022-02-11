using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScors
{
    public partial class frmAddUpdateScore : Form
    {
        public bool isAddScore;
        public decimal score;
        public frmAddUpdateScore()
        {
            InitializeComponent();
        }

        private void frmAddUpdateScore_Load(object sender, EventArgs e)
        {
            if (isAddScore)
            {
                this.Text = "Add Score";
            }
            else
            {
                this.Text = "Update Score";
                this.txtScore.Text = score.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtScore) && Validator.IsDecimal(txtScore))
            {
                score = Convert.ToDecimal(txtScore.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
