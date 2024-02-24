using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Proveeduria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtContrasenia.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigoFuncionario = txtIdentificacion.Text;
            string contrasenia = txtContrasenia.Text.ToUpper();


            if (_ArchivoXML.validarCredenciales("Funcionarios.xml", codigoFuncionario, contrasenia, out string estado))
            {
                if (estado == "Activo")
                {
                    // Usuario activo, puedes permitir el acceso al sistema
                    MessageBox.Show("Inicio de Sesion Exitoso");
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    // Usuario inactivo
                    MessageBox.Show("El usuario está inactivo. Contacte al administrador.");
                }
            }
            else
            {
                // Credenciales inválidas
                MessageBox.Show("Código de funcionario o contraseña incorrectos.");
            }
        }
    }
}
