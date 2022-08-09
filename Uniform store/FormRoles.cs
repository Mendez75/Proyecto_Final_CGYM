using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Uniform_store
{
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
             BindGridView();
            
        }
        
            

        void BindGridView()
        {
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from loginDataTable";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void logoutbutton1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void catagorybutton_Click(object sender, EventArgs e)
        {
            FormCategoria form = new FormCategoria();
            this.Hide();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm form = new adminForm();
            this.Hide();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistro form = new FormRegistro();
            this.Hide();
            form.Show();

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            nametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sellertextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
