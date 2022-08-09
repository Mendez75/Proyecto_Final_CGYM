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
    public partial class InformeVentas : Form
    {
        public InformeVentas()
        {
            InitializeComponent();
            BindGridView();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            form1 viewData = new form1();
            viewData.Show();

            this.Hide();
        }

        void BindGridView()
        {
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from ordermastertable inner  join logindatatable on ordermastertable.user_id = logindatatable.userid";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }



        private void SalesReport_Load(object sender, EventArgs e)
        {

        }
    }
}
