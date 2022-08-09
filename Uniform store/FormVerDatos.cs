using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;


namespace Uniform_store
{
    public partial class FormVerDatos : Form
    {
        public FormVerDatos()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from producttable ";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

      

       

        

        private void ViewData_Activated(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            form1 viewData = new form1();
            viewData.Show();
            
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewData_Load(object sender, EventArgs e)
        {

        }
    }
}
