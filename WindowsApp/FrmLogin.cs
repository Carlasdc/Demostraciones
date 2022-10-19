using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresarClick(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            int password = Convert.ToInt32(txtPassword.Text);

            if (nombre.ToUpper() == "CARLA" && password.Equals(654321))
            {
                MessageBox.Show("Bienvenida " + nombre);
            }
            else
            {
                MessageBox.Show("No se encuentra registrado");
            }

        }
    }
}
