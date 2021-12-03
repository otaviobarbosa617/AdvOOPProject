using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvOOPProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //This method clears the panel and then call the new window/form to inside the panel
        public void LoadPage(object form)
        {
            panel1.Controls.Clear();
            Form customerWindow = form as Form;
            customerWindow.TopLevel = false;
            panel1.Controls.Add(customerWindow);
            panel1.Tag = customerWindow;
            customerWindow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPage(new AddCustomerWindow());
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPage(new ViewCustomers());
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPage(new DeleteCustomerWindow());
        }
    }
}
