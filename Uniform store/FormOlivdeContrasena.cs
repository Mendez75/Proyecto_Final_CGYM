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
using System.Data.OleDb;


namespace Uniform_store
{
    public partial class Forget_password : Form
    {
        String randomCode;
        public static string to;
        public Forget_password()
        {
            InitializeComponent();
        }




        private void Sendbutton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = MSDAORA;Data Source=XE;User ID=project;Password=project;Unicode=True");
            con.Open();
            OleDbCommand commandcheckEmail = new OleDbCommand("select email from logindatatable where email='" + forgetEmailtextBox.Text + "'", con);
            string checkEmail = (string)commandcheckEmail.ExecuteScalar();
            con.Close();

            if (string.IsNullOrEmpty(forgetEmailtextBox.Text) == true)
            {
                forgetEmailtextBox.Focus();
                MessageBox.Show("Introduzca el Email");
            }

            else if (checkEmail != forgetEmailtextBox.Text)
            {
                forgetEmailtextBox.Focus();
                MessageBox.Show("El email no existe en la base de datos!");
            }

            else
            {


                string from, pass, messagebody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage messagee = new MailMessage();
                to = forgetEmailtextBox.Text.ToString();

                from = "emailsendercs1@gmail.com";
                pass = "ylobvdpkvlnsgplz";
                messagebody = $"Password Reseting code is {randomCode}";
                messagee.To.Add(to);
                messagee.From = new MailAddress(from);
                messagee.Body = messagebody;
                messagee.Subject = "Pasword reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(messagee);
                    MessageBox.Show("Código enviado con exito.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void verifybutton_Click(object sender, EventArgs e)
        {
            if (randomCode == codetextBox.Text.ToString())
            {
                to = forgetEmailtextBox.Text;

                Reset_Password_form rs = new Reset_Password_form();
                this.Hide();
                rs.Show();
            }
            else
            {
                MessageBox.Show("Código erróneo!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lo = new Login();
            this.Hide();
            lo.Show();

        }
    }
}
