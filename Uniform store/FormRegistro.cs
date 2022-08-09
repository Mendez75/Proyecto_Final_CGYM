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
using System.Text.RegularExpressions;

namespace Uniform_store
{
    public partial class FormRegistro : Form
    {
       
        public FormRegistro()
        {
            InitializeComponent();
        }

       OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");


        private void AlreadyRegisterLink_Click(object sender, EventArgs e)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();

            }
        


        private void createButtton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            string query = "insert into  logindatatable(userid,username, role ,fname ,lname ,gender ,dob ,password ,discription ,address ,email ) values (null,'" +UserNametextBox.Text + "' , '" +rolecomboBox.Text + "', '" + FirstnametextBox.Text + "', '" +LnametextBox.Text + "' , '" + GendercomboBox.Text + "','" + DateTime.Now.ToString() + "', '" + PasswordtextBox.Text + "', '" + DiscriptiontextBox.Text + "', '" + AddresstextBox.Text + "', '" + EmailtextBox.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, con);

           
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            con.Open();
            OleDbCommand commandcheckEmail = new OleDbCommand("select email from logindatatable where email='" + EmailtextBox.Text + "'", con);
            OleDbCommand commandcheckusername = new OleDbCommand("select username from logindatatable where username='" + UserNametextBox.Text + "'", con);
            string checkusername = (string)commandcheckusername.ExecuteScalar();
            string checkEmail = (string)commandcheckEmail.ExecuteScalar();
            con.Close();

            if (string.IsNullOrEmpty(FirstnametextBox.Text) == true)
            {
                FirstnametextBox.Focus();

                FirstNameerrorProvider.SetError(this.FirstnametextBox, "Introduzca el primer nombre");
            }
            else if (string.IsNullOrEmpty(LnametextBox.Text) == true)
            {
                LnametextBox.Focus();

                LastNameerrorProvider.SetError(this.LnametextBox, "Introduzca el apellido!");
            }
            else if (string.IsNullOrEmpty(rolecomboBox.Text) == true)
            {
                rolecomboBox.Focus();

                RoleerrorProvider.SetError(this.rolecomboBox, "Introduzca el usuario!");
            }
            else if (string.IsNullOrEmpty(UserNametextBox.Text) == true)
            {
                UserNametextBox.Focus();

                UserNameerrorProvider.SetError(this.UserNametextBox, "Introduzca el usuario!");
            }
            else if (checkusername==UserNametextBox.Text) {
                UserNametextBox.Focus();
                UserNameerrorProvider.SetError(this.UserNametextBox, "Ya existe el usuario!");
            }

            
            else if (string.IsNullOrEmpty(EmailtextBox.Text) == true) { 
                EmailtextBox.Focus();
                EmailerrorProvider.SetError(this.EmailtextBox, "Digite el email!");


            }
            else if ((!expr.IsMatch(EmailtextBox.Text))) {

                EmailtextBox.Focus();
                EmailerrorProvider.SetError(this.EmailtextBox, "El email no es valido!");

            }
            else if (checkEmail == EmailtextBox.Text) {
                EmailtextBox.Focus();
                EmailerrorProvider.SetError(this.EmailtextBox, "El correo ya existe!");
            }
            else if (string.IsNullOrEmpty(AddresstextBox.Text) == true)
            {
                AddresstextBox.Focus();

                AddresserrorProvider.SetError(this.AddresstextBox, "Enter la dirección");
            }
            else if (string.IsNullOrEmpty(DiscriptiontextBox.Text) == true)
            {
                DiscriptiontextBox.Focus();

                DiscriptionerrorProvider.SetError(this.DiscriptiontextBox, "Enter the Address!!!");
            }
            else if (string.IsNullOrEmpty(GendercomboBox.Text) == true) {
                
                GendercomboBox.Focus();

                GendererrorProvider.SetError(this.GendercomboBox, "Seleccione el Género!");
            }

            else if (string.IsNullOrEmpty(PasswordtextBox.Text) == true)
            {
                PasswordtextBox.Focus();

                PassworderrorProvider.SetError(this.PasswordtextBox, "Digite la contraseña!");
            }
            else if (PasswordtextBox.Text != ConfirmtextBox.Text)
            {
                PasswordtextBox.Focus();

                PassworderrorProvider.SetError(this.PasswordtextBox, "Digite la contraseña!");
                ConfirmerrorProvider.SetError(this.ConfirmtextBox, "Las contraseñas no coiciden!");
            }
            else
            {
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (a > 0)
                {
                    MessageBox.Show("inserción exitosa!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                    MessageBox.Show("inserción fallida!", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
