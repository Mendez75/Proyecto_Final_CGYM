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
    public partial class form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        int Sr_no = 0;
        int finalCost = 0;

        public form1()
        {
            InitializeComponent();
            GetItems();
            getInvoiceID();
            GetUserid();

            USERtextBox.Text = Login.username;
            DataGridView.ColumnCount = 8;
            DataGridView.Columns[0].Name = "N.";
            DataGridView.Columns[1].Name = "NOMBRE ARTICULO";
            DataGridView.Columns[2].Name = "PRECIO UNITARIO";
            DataGridView.Columns[3].Name = "TAMAÑO";
            DataGridView.Columns[4].Name = "CANTIDAD";
            DataGridView.Columns[5].Name = "SUBTOTAL";
            DataGridView.Columns[6].Name = "IMPUESTO";
            DataGridView.Columns[7].Name = "COSTO TOTAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetItems();
            GetUserid();


        }

        private void GetUserid()
        {
            try
            {

                OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from LOGINDATATABLE where username like'" + USERtextBox.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UseridtextBox.Text = reader["userid"].ToString();


                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }
        }

        private void GetItems()
        {
            catagorycomboBox.Items.Clear();
           OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select * from catagory";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string items_names = dr.GetString(1);
                catagorycomboBox.Items.Add(items_names);
            }
            catagorycomboBox.Sorted = true;
            con.Close();
        }





        private void QuantitynumericUpDown_TextChanged(object sender, EventArgs e)
        {

            int price = Convert.ToInt32(PRICEtextBox.Text);

            int quantity = Convert.ToInt32(QuantitynumericUpDown.Text);
            int subTotal = (price * quantity);
            SUBTOTALtextBox.Text = subTotal.ToString();

        }


        private void SUBTOTALtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SUBTOTALtextBox.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SUBTOTALtextBox.Text);
                int tax = 0;

                if (subTotal >= 10000)
                {
                    tax = (int)(subTotal * 0.05);
                    TAXtextBox.Text = tax.ToString();

                }
                else
                {
                    tax = (int)(subTotal * 0.02);
                    TAXtextBox.Text = tax.ToString();
                }
            }
        }

        private void TAXtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAXtextBox.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SUBTOTALtextBox.Text);
                int tax = Convert.ToInt32(TAXtextBox.Text);
                int finalcost = subTotal + tax;
                TOTALCOSTtextBox.Text = finalcost.ToString();
            }
        }

        private void TOTALCOSTtextBox_TextChanged(object sender, EventArgs e)
        {

        }







        void AddDataToGridView(string Sr_No, string item_name, string unit_price, string size, string quantity, string sub_total, string tax, string total_cost)
        {
            string[] row = { Sr_No, item_name, unit_price, size, quantity, sub_total, tax, total_cost };
            DataGridView.Rows.Add(row);
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(catagorycomboBox.Text) == true)
            {
                MessageBox.Show("Seleccione la categoria ");
            }
            else if (itemslistBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el artículo ");
            }
            else if (QuantitynumericUpDown.Text == "0")
            {
                MessageBox.Show("Introduzca la cantidad que desea");
            }
            else if (Convert.ToInt32(QuantitynumericUpDown.Text) > Convert.ToInt32(UnitstextBox.Text))
            {
                MessageBox.Show("Las unidades máximas son " + UnitstextBox.Text);
                QuantitynumericUpDown.Focus();
            }
            else if (sizelistBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tamaño");
            }

            else
            {
                update_stock();
                AddDataToGridView((++Sr_no).ToString(), itemslistBox.SelectedItem.ToString(), PRICEtextBox.Text, sizelistBox.Text.ToString(), QuantitynumericUpDown.Text, SUBTOTALtextBox.Text, TAXtextBox.Text, TOTALCOSTtextBox.Text);

                ResetControl();
                CalculateFinalCost();
            }
        }
        void ResetControl()
        {

            PRICEtextBox.Clear();

            QuantitynumericUpDown.ResetText();
            SUBTOTALtextBox.Clear();
            TAXtextBox.Clear();
            TOTALCOSTtextBox.Clear();
            FINALCOSTtextBox.Clear();
            AMOUNTPAIDtextBox.Clear();
            CHANGEtextBox.Clear();

        }
        void CalculateFinalCost()
        {

            finalCost = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                finalCost = finalCost + Convert.ToInt32(DataGridView.Rows[i].Cells[7].Value);
            }
            FINALCOSTtextBox.Text = finalCost.ToString();

        }

        private void AMOUNTPAIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AMOUNTPAIDtextBox.Text) == true)
            {

            }
            else
            {
                int finalcost = Convert.ToInt32(FINALCOSTtextBox.Text);

                int amountpaid = Convert.ToInt32(AMOUNTPAIDtextBox.Text);

                CHANGEtextBox.Text = (amountpaid - finalcost).ToString();
            }
        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void CLEARGRIDVIEWbutton_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            Sr_no = 0;
        }

        void getInvoiceID()
        {
          OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "select invoiceid from ordermastertable ";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count < 1)
            {

                INVOICEtextBox.Text = "1";
            }
            else
            {
                string query2 = "select max(invoiceid) from ordermastertable ";
                OleDbCommand cmd = new OleDbCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                INVOICEtextBox.Text = a.ToString();
                con.Close();
            }
        }


        private void FINALCOSTtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FINALCOSTtextBox.Text) == true)
            {
                AMOUNTPAIDtextBox.Enabled = false;
            }
            else
            {
                AMOUNTPAIDtextBox.Enabled = true;
            }
        }

       

        private void AMOUNTPAIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }




        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerDatos view = new FormVerDatos();
            view.ShowDialog();
        }



        private void catagorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_items();
        }


        void get_items()
        {
            try
            {
                itemslistBox.Items.Clear();
               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select distinct(name) from productTable where cid=(select cid from catagory where cname='" + catagorycomboBox.Text + "')";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();               //leer data 
                while (reader.Read())
                {
                    itemslistBox.Items.Add(reader["name"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }





        private void itemslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sizelistBox.Items.Clear();
               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from productTable where name like'" + itemslistBox.Text + "' and quantity>0 ";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    sizelistBox.Items.Add(reader["sizee"].ToString());

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }
        }

        private void sizelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from productTable where sizee like'" + sizelistBox.Text + "' and name like '" + itemslistBox.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PRICEtextBox.Text = reader["price"].ToString();
                    UnitstextBox.Text = reader["quantity"].ToString();
                    QuantitynumericUpDown.Enabled = true;

                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }
        }

        private void QuantitynumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int stotal = Convert.ToInt32(PRICEtextBox.Text) * Convert.ToInt32(QuantitynumericUpDown.Value);
            SUBTOTALtextBox.Text = stotal.ToString();
        }

        void update_stock()
        {
            if (string.IsNullOrEmpty(FINALCOSTtextBox.Text))
             {

            }
            else {
                int quantity = 0;
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    quantity += +Convert.ToInt32(DataGridView.Rows[i].Cells[4].Value);
                }
                int Quantity = Convert.ToInt32(UnitstextBox.Text) - quantity;

              OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                string query = "update  producttable set quantity=" + Quantity + "where name='" + itemslistBox.Text + "'and sizee='" + sizelistBox.Text + "'";

                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        void addrecord()
        {
            if (string.IsNullOrEmpty(FINALCOSTtextBox.Text))
            {

            }
            else
            {
                update_stock();
               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                string query = "insert into  ordermastertable values (null, " + Convert.ToInt32(UseridtextBox.Text) + "  ,'" + DateTime.Now.ToString() + "'," + FINALCOSTtextBox.Text + ")";
                OleDbCommand cmd = new OleDbCommand(query, con);


                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (a > 0)
                {

                    getInvoiceID();
                    ResetControl();
                    
                    Sr_no = 0;
                }
                else
                {
                    MessageBox.Show("inserción fallida", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
           


        private void INSERTbutton_Click(object sender, EventArgs e)
        {


            addrecord();

        }

        




        

        private void PRINTPREVIEWbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AMOUNTPAIDtextBox.Text) == true)
            {
                MessageBox.Show("Introduzca el monto", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AMOUNTPAIDtextBox.Focus();
            }
            else
            {
                addrecord();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        
        

        private void DISCOUNTtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerDatos viewData = new FormVerDatos();
            viewData.Show();
            this.Hide();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeVentas viewData = new InformeVentas();
            viewData.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.png_transparent_logo_brand_font_mini_market_white_text_black_and_white;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 5, 800, 250);
            e.Graphics.DrawString("ID Factura : " + INVOICEtextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Usuario : " + USERtextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Fecha : " + DateTime.Now.ToShortDateString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Hora : " + DateTime.Now.ToLongTimeString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("Nombre Articulo ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("Cantidad ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(260, 450));
            e.Graphics.DrawString("Precio Unitario ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(450, 450));
            e.Graphics.DrawString("Precio", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(700, 450));

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 470));


            if (DataGridView.Rows.Count > 0)
            {
                int gap = 500;
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(DataGridView.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                        gap += 30;
                    }
                    catch
                    {

                    }
                }
            }

            if (DataGridView.Rows.Count > 0)
            {
                int gap = 500;
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(DataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(260, gap));
                        gap += 30;
                    }
                    catch
                    {

                    }
                }

            }

            if (DataGridView.Rows.Count > 0)
            {
                int gap = 500;
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(DataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(450, gap));
                        gap += 30;
                    }
                    catch
                    {

                    }
                }
            }
            if (DataGridView.Rows.Count > 0)
            {
                int gap = 500;
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(DataGridView.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(700, gap));
                        gap += 30;
                    }
                    catch
                    {

                    }
                }
            }

            e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 880));
            int subCost = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                subCost = subCost + Convert.ToInt32(DataGridView.Rows[i].Cells[5].Value);
            }
            e.Graphics.DrawString("SubTotal:" + subCost.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 900));

            int taxPrint = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                taxPrint = taxPrint + Convert.ToInt32(DataGridView.Rows[i].Cells[6].Value);
            }
            e.Graphics.DrawString("Impuesto :" + taxPrint.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 930));

            int totalCost = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                totalCost = totalCost + Convert.ToInt32(DataGridView.Rows[i].Cells[7].Value);
            }

            e.Graphics.DrawString("Monto total: " + totalCost.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 960));

            e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 1000));
            e.Graphics.DrawString("Monto pagado: " + AMOUNTPAIDtextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 1020));
            e.Graphics.DrawString("Cambio: " + CHANGEtextBox.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(530, 1050));
            addrecord();

        }

       

        private void PRINTbutton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void PRINTPREVIEWbutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AMOUNTPAIDtextBox.Text) == true)
            {
                MessageBox.Show("Introduzca monto", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AMOUNTPAIDtextBox.Focus();
            }
            else if (Convert.ToInt32(AMOUNTPAIDtextBox.Text) < Convert.ToInt32(FINALCOSTtextBox.Text))
            {
                MessageBox.Show("No se ha pagado por complepto", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AMOUNTPAIDtextBox.Focus();
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
    }
}

