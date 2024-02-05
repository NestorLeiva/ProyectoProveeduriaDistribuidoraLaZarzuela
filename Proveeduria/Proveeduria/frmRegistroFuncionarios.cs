using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
