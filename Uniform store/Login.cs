using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.OleDb;



namespace Uniform_store
{
    public partial class Login : Form
    {
       public static string username = "";
       
       OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
        public Login()
        {
            InitializeComponent();
        }

       
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RolecomboBox.Text) == true )
            {
                MessageBox.Show("Por favor seleccione el rol");
                RolecomboBox.Focus();
            }
            else if(RolecomboBox.Text=="admin")
            {

                string query = "select * from LOGINDATATABLE where username='" + userNameTextBox.Text + "' and password= '" + PasswordTextBox.Text + "'and role = 'admin'";
                OleDbCommand cmd = new OleDbCommand(query, con);

                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                   
                    
                    this.Hide();
                    adminForm form = new adminForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos erróneos o vacíos", "Fallo inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else if(RolecomboBox.Text == "vendedor")
            {
                string query = "select * from LOGINDATATABLE where username='" + userNameTextBox.Text + "' and password= '" + PasswordTextBox.Text + "'and role = 'seller'";
                OleDbCommand cmd = new OleDbCommand(query, con);

                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                   
                    username = userNameTextBox.Text;
                    this.Hide();
                    form1 mainForm = new form1();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos erróneos o vacíos", "Fallo inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

        }

        private void checkPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            bool check = checkPassword.Checked;

            switch (check)
            {
                case true:
                    PasswordTextBox.UseSystemPasswordChar = false;
                    break;

                default:
                    PasswordTextBox.UseSystemPasswordChar = true;
                    break;
            }
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro obj = new FormRegistro();
            this.Hide();
            obj.ShowDialog();

        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_password fp = new Forget_password();
            this.Hide();
            fp.Show();

        }

        private void RolecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signInGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
