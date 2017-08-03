using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateCinemasWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public decimal lcNumber;
        public decimal lcYourNumber;
        
        private void GetReady()
        {
            lcNumber = Convert.ToDecimal(lblNumber.Text);
            lcYourNumber = Convert.ToDecimal(txtNumber.Text);
        }
           
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetReady();        
            lblTotal.Text = (lcYourNumber + lcNumber).ToString();            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            GetReady();
            lblTotal.Text = (lcYourNumber - lcNumber).ToString();
        }

        private void bunDiv_Click(object sender, EventArgs e)
        {
            GetReady();
            lblTotal.Text = (lcYourNumber / lcNumber).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            GetReady();
            lblTotal.Text = (lcYourNumber * lcNumber).ToString();
        }
    }
}
