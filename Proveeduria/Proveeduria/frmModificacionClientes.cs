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
    public partial class frmModificacionClientes : Form
    {
        public frmModificacionClientes()
        {
            InitializeComponent();
        }

        private void frmModificacionClientes_Load(object sender, EventArgs e)
        {
            LimpiarTexBox();
        }
        /* ----------------------------------------------- textbox -----------------------------------------------*/
        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteApellidoPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        private void txtClienteApellidoSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
            string numeroTelefono = txtClienteTelefono.Text;

            bool esValido = Validaciones.validarTelefono(numeroTelefono);
            btnClienteModificar.Enabled = esValido;
            /*se habilita / desabilita dependiendo si el numero es valido o no*/
        }

        private void txtClienteEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteCanton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteOtrasSenias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        /* ----------------------------------------------- Botones -----------------------------------------------*/

        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexBox();
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* ----------------------------------------------- Metodos -----------------------------------------------*/
        public void LimpiarTexBox()
        {
            cbxBuscarTipoDNI.SelectedIndex = 0;

            cbxClienteTipoDNI.SelectedIndex = 0;
            txtClienteDNI.Text = string.Empty;
            txtClienteNombre.Text = string.Empty;
            txtClienteApellidoPrimero.Text = string.Empty;
            txtClienteApellidoSegundo.Text = string.Empty;
            txtClienteCodigo.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteEmail.Text = string.Empty;

            cbxClienteProvincia.SelectedIndex = 0;
            txtClienteCanton.Text = string.Empty;
            txtClienteDistrito.Text = string.Empty;
            txtClienteOtrasSenias.Text = string.Empty;

        }/*fin LimpiarTexBox*/

        
    }/*fin frmModificacionClientes*/
}/*fin namespace*/
