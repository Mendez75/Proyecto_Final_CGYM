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
    public partial class FormCategoria : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormCategoria()
        {
            OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");;
            InitializeComponent();
            BindGridView();
        }

        void BindGridView()
        {
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from catagory";
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendedor form3 = new FormVendedor();
            this.Hide();
            form3.ShowDialog();
        }

        private void Productbutton_Click(object sender, EventArgs e)
        {

            adminForm form = new adminForm();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            cidtextBox.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DescriptiontextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nametextBox.Text) == true)
            {
                MessageBox.Show("Introduzca el nombre de la categoría");
                nametextBox.Focus();
            }
            
            else if (string.IsNullOrEmpty(DescriptiontextBox.Text) == true)

            {
                MessageBox.Show("Introduzca una descripción ");
                DescriptiontextBox.Focus();
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string query2 = "insert into catagory(cid,cname,cdescription) values (null,'" + nametextBox.Text + "','" + DescriptiontextBox.Text + "')";
                    cmd.CommandText = query2;


                    con.Open();

                    int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (a > 0)
                    {
                        MessageBox.Show("Inserción exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();


                    }
                    else
                        MessageBox.Show("Inserción fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametextBox.Text) == true)
            {
                MessageBox.Show("Introduzca el nombre de la categoría");
                nametextBox.Focus();
            }

            else if (string.IsNullOrEmpty(DescriptiontextBox.Text) == true)

            {
                MessageBox.Show("Digite una descripción ");
                DescriptiontextBox.Focus();
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string query2 = "update catagory set cname='" + nametextBox.Text + "',cdescription='" + DescriptiontextBox.Text + "' where cid ='" + cidtextBox.Text + "' ";
                    cmd.CommandText = query2;


                    con.Open();

                    int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (a > 0)
                    {
                        MessageBox.Show("Actualizado con exito", "Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cidtextBox.Clear();
                        nametextBox.Clear();
                        DescriptiontextBox.Clear();
                        BindGridView();


                    }
                    else
                        MessageBox.Show("update Fail", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            cidtextBox.Clear();
            nametextBox.Clear();
            DescriptiontextBox.Clear();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                  OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query2 = "delete catagory where cid ='" + cidtextBox.Text + "' ";
                cmd.CommandText = query2;


                con.Open();

                int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (a > 0)
                {
                    MessageBox.Show("Eliminado con exito", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cidtextBox.Clear();
                    nametextBox.Clear();
                    DescriptiontextBox.Clear();
                    BindGridView();


                }
                else
                    MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
