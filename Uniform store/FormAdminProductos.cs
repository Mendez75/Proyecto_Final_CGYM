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
    public partial class adminForm : Form
    {
        OleDbConnection con = new OleDbConnection();
        public adminForm()
        {
            con.ConnectionString = @"Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True";
            InitializeComponent();
            BindGridView();
            GetItems();
        }

        private void GetItems()
        {
            CatagorycomboBox.Items.Clear();
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from catagory";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string items_names = dr.GetString(1);
                CatagorycomboBox.Items.Add(items_names);
            }
            CatagorycomboBox.Sorted = true;
            con.Close();
        }


        void BindGridView()
        {
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from productTable";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;
        }

        private void logoutbutton1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void catagorybutton_Click(object sender, EventArgs e)
        {
            FormCategoria form2 = new FormCategoria();
            this.Hide();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVendedor form3 = new FormVendedor();
            this.Hide();
            form3.ShowDialog();
        }

       


        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametextBox.Text) == true)
            {
                MessageBox.Show("Introduzca el nombre del producto!");
                nametextBox.Focus();
            }
            else if (string.IsNullOrEmpty(PricetextBox.Text) == true)
            {
                MessageBox.Show("Introduzca el precio");
                PricetextBox.Focus();
            }
            else if(string.IsNullOrEmpty(QuantitytextBox.Text) == true)

            {
                MessageBox.Show("Introduzca la cantidad");
                QuantitytextBox.Focus();
            }
            else if (string.IsNullOrEmpty(BarcodetextBox.Text) == true)

            {
                MessageBox.Show("Introduzca el código");
                BarcodetextBox.Focus();
            }
            else if (string.IsNullOrEmpty(CatagorycomboBox.Text) == true)

            {
                MessageBox.Show("Seleccione la categoría del producto");
                CatagorycomboBox.Focus();
            }
            else if (string.IsNullOrEmpty(sizecomboBox.Text) == true)

            {
                MessageBox.Show("Seleccione el tamaño ");
                sizecomboBox.Focus();
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.Parameters.Clear();

                    string query2 = "insert into ProductTable(productid,productbarcode,name,quantity,sizee,price,cid) values (null," + BarcodetextBox.Text + ",'" + nametextBox.Text + "'," + QuantitytextBox.Text + ",'" + sizecomboBox.Text + "'," + PricetextBox.Text + "," + Convert.ToInt32(catagorytextBox.Text) + ")";
                    cmd.CommandText = query2;
                    int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (a > 0)
                    {
                        MessageBox.Show("Inserción exitosa", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        catagorytextBox.Clear();
                        
                        idtextBox.Clear();
                        nametextBox.Clear();
                        QuantitytextBox.Clear();
                        PricetextBox.Clear();
                        BarcodetextBox.Clear();
                        BindGridView();

                    }
                    else
                        MessageBox.Show("Insertion Fail", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }
             
        }



        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtextBox.Text)==true)
                {
                MessageBox.Show("Seleccione el ID del producto");
            }
            else {
               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                string query = "delete from productTable where productid=" + idtextBox.Text + "";
                OleDbCommand cmd = new OleDbCommand(query, con);


                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (a > 0)
                {
                    MessageBox.Show("Eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    catagorytextBox.Clear();
                    idtextBox.Clear();
                    nametextBox.Clear();
                    QuantitytextBox.Clear();
                    PricetextBox.Clear();
                    BarcodetextBox.Clear();
                    
                    BindGridView();
                }
                else
                    MessageBox.Show("Eliminacion fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                con.Close();
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtextBox.Text) == true)
            {
                MessageBox.Show("Select product ID");
            }
            else
            {
                con.ConnectionString = @"Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                string query = "update  productTable set productbarcode=" + BarcodetextBox.Text + ",name='" + nametextBox.Text.ToString() + "',quantity= " + QuantitytextBox.Text + ",sizee='" + sizecomboBox.Text.ToString() + "', price =" + PricetextBox.Text + "where productid =" + idtextBox.Text + "";

                cmd.CommandText=query;



                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (a > 0)
                {
                    MessageBox.Show("Updated Successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    catagorytextBox.Clear();
                    idtextBox.Clear();
                    nametextBox.Clear();
                    QuantitytextBox.Clear();
                    PricetextBox.Clear();
                    BarcodetextBox.Clear();
                    BindGridView();
                }
                else
                {
                    MessageBox.Show("Updation Fail", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void CatagorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select cid from catagory where cname='" + CatagorycomboBox.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    catagorytextBox.Text = reader["cid"].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            catagorytextBox.Clear();
            idtextBox.Clear();
            nametextBox.Clear();
            QuantitytextBox.Clear();
            PricetextBox.Clear();
            BarcodetextBox.Clear();
            sizecomboBox.DataSource = null;
        }

       

        private void dataGridView2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            idtextBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            nametextBox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            QuantitytextBox.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            PricetextBox.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            BarcodetextBox.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            sizecomboBox.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sizecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
