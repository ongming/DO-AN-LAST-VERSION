using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class AddFunds_Form : Form
    {
        string id;
        int wallet;
        Customer customer;
        public AddFunds_Form(int wallet, Customer customer,string id)
        {
            InitializeComponent();
            this.id = id;
            this.customer = customer;
            this.wallet = wallet;
        }

        private void pictureBoxCloseAddfunds_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if(txtMoneyAdd.Text==null)
            {
                MessageBox.Show("Don't let any Information Empty!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.customer.Wallet+=Convert.ToInt32(txtMoneyAdd.Text);
                 this.Close();
            }
        }
    }
}
