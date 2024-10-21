using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_Assignment_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void HideLabels(Label keepVisible)
        {
            lblDivide.Visible = false;
            lblMultiply.Visible = false;
            lblAdd.Visible = false;
            lblSubtract.Visible = false;
            keepVisible.Visible = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            lblAdd.Text = "8 + 8 = " + (8 + 8);
            HideLabels(lblAdd);
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Firebrick;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblSubtract.Text = "8 - 8 = " + (8 - 8);
            HideLabels(lblSubtract);
            btnSubtract.Enabled = false;
            btnSubtract.BackColor = Color.Firebrick;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblMultiply.Text = "8 * 8 = " + (8 * 8);
            HideLabels(lblMultiply);
            btnMultiply.Enabled = false;
            btnMultiply.BackColor = Color.Firebrick;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblDivide.Text = "8 / 8 = " + (8 / 8);
            HideLabels(lblDivide);
            btnDivide.Enabled = false;
            btnDivide.BackColor = Color.Firebrick;
        }
    }
}
