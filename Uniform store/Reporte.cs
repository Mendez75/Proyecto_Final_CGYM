using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniform_store
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Stockbutton_Click(object sender, EventArgs e)
        {
            FormVerDatos viewData = new FormVerDatos();
            viewData.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeVentas viewData = new InformeVentas();
            viewData.Show();
            this.Hide();
        }
    }
}
