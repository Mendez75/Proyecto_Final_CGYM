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
    public partial class Reset_Password_form : Form
    {
        string email = Forget_password.to;
        public Reset_Password_form()
        {
            InitializeComponent();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usernametextBox.Text)==true)
            {
                usernametextBox.Focus();
                MessageBox.Show("Introduzca el usuario!");

            }
            else if(resetpasswordtextBox.Text==confirmResetpasswordtextBox.Text)
            {
               OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
                string query = "update logindatatable set  password= '"+resetpasswordtextBox.Text+"' , username='"+usernametextBox.Text+"' where email = '"+email+"'"; 
                OleDbCommand cmd = new OleDbCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Contraseña actualizada.");
                Login lo = new Login();
                this.Hide();
                lo.Show();

            }
            else
            {
                resetpasswordtextBox.Focus();
                MessageBox.Show("No coiciden las contraseñas!");
            }
        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Password_form_Load(object sender, EventArgs e)
        {

        }
    }
}
