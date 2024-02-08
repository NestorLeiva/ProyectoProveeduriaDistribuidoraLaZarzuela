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
    public partial class frmRegistroFuncionarios : Form
    {
        public frmRegistroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnFuncionarioLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncionarioNombre.Text = "";
            txtFuncionarioApellidoPrimero.Text = "";
            txtFuncionarioApellidoSegundo.Text = "";
            txtFuncionarioDNI.Text = "";
            txtFuncionarioCodigo.Text = "";
            txtFuncionarioEmail.Text = "";
        }

        private void txtFuncionarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioApellidoPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioApellidoSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}