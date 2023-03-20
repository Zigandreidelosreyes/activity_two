using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fillbtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("IPhone 14 Pro Max Full Paid");
            wishlist.Items.Add("Xrm 150"); 
            wishlist.Items.Add("House n Lot");

            wishlist.Items.Add("Black Pink Concert Ticket");
            wishlist.Items.Add("100,000,000");
        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishlist.Text;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void countbtn_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void countOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectionOutputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
