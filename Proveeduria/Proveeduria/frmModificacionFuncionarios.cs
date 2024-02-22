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
    public partial class frmModificacionFuncionarios : Form
    {
        public frmModificacionFuncionarios()
        {
            InitializeComponent();
        }
        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        Funcionario _Funcionario;


        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/
        private void frmModificacionFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarConsutar_Click(object sender, EventArgs e)
        {

        }/*fin metodo Consultar*/

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/

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

        private void txtFuncionarioEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
