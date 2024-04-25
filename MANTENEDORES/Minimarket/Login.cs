using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entUsuario u = logUsuario.Instancia.Login(txtUsuario.Text, txtPassword.Text);
                if (u.IDUSUARIO == null)
                {
                    MessageBox.Show("Credenciales Incorrectas", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal(u);
                    this.Hide();
                    menuPrincipal.Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShowPassword.Image = Minimarket.Properties.Resources.ver;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnShowPassword.Image = Minimarket.Properties.Resources.ojo;
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
