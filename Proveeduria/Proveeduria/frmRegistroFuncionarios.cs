using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Utils;




namespace Proveeduria
{
    public partial class frmRegistroFuncionarios : Form
    {
        public frmRegistroFuncionarios()
        {
            InitializeComponent();
        }

        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        private void frmRegistroFuncionarios_Load(object sender, EventArgs e)
        {
            CargarListaFuncionarios("Funcionarios.xml"); // Leer el XML y cargar los datos en el ListView
        }


        /*Instancias*/
        Funcionario _Funcionario;
        /*----------------------------------------- TextBox ------------------------------------------------*/

        private void txtFuncionarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioApellidoPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioApellidoSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
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

        private void txtFuncionarioContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }



        /*----------------------------------------- Botones ------------------------------------------------*/
        private void btnFuncionarioAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                _Funcionario = new Funcionario()
                /*Inicializacion de la clase*/
                {
                    DNI = Convert.ToInt32(this.txtFuncionarioDNI.Text),
                    Nombre = this.txtFuncionarioNombre.Text.ToUpper(),
                    ApellidoPrimero = this.txtFuncionarioApellidoPrimero.Text.ToUpper(),
                    ApellidoSegundo = this.txtFuncionarioApellidoSegundo.Text.ToUpper(),
                    CodFuncionario = Convert.ToInt32(this.txtFuncionarioDNI.Text),

                    Contrasenia = this.txtFuncionarioContrasenia.Text,
                    Estado = this.rbtnEstadoActivo.Text,
                };


                _Funcionario.grabarXMLFuncionario("Funcionarios.xml");
                // ruta para escribir el XML
                MessageBox.Show("*Se Registro al Funcionario Exitosamente*", "Registrar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // mensaje de exito 


                CargarListaFuncionarios("Funcionarios.xml"); // Leer el XML y cargar los datos en el ListView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registrar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // mensaje de error
            }

        }/*fin Boton Aceptar*/

        private void btnFuncionarioLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncionarioNombre.Text = string.Empty;
            txtFuncionarioApellidoPrimero.Text = string.Empty;
            txtFuncionarioApellidoSegundo.Text = string.Empty;
            txtFuncionarioDNI.Text = string.Empty;

            txtFuncionarioContrasenia.Text = string.Empty;
        }/*fin boton Limpiar*/

        private void btnFuncionarioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*----------------------------------------- Metodo ------------------------------------------------*/

        private void CargarListaFuncionarios(string rutaArchivo)
        {
            lvListaFuncionarios.Items.Clear();
            /*limpia la lista*/

            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Funcionarios = xmlDoc.SelectNodes("//Funcionario");
            /*obtengo los nodos del XML*/

            foreach (XmlNode funcionario in _Funcionarios)
            {
                string DNI = funcionario.SelectSingleNode("Identificacion").InnerText;
                string Nombre = funcionario.SelectSingleNode("Nombre").InnerText;
                string ApellidoPrimero = funcionario.SelectSingleNode("ApellidoPrimero").InnerText;
                string ApellidoSegundo = funcionario.SelectSingleNode("ApellidoSegundo").InnerText;
                string Email = funcionario.SelectSingleNode("Email").InnerText;
                string CodFuncionario = funcionario.SelectSingleNode("CodigoFuncionario").InnerText;
                string Contrasenia = funcionario.SelectSingleNode("Contrasenia").InnerText;
                string Estado = funcionario.SelectSingleNode("Estado").InnerText;

                ListViewItem itemFuncionario = new ListViewItem(
                    new[] { DNI, Nombre, ApellidoPrimero, ApellidoSegundo, Email, CodFuncionario, Contrasenia, Estado });
                /*creo el ListView con los datos */

                lvListaFuncionarios.Items.Add(itemFuncionario);
                /*Agrego los Items al ListView*/

            } /*iteracion por los nodos */



        }/*Fin metodo CargarListaFuncionarios */


    }/*fin clase frmRegistroFuncionarios*/
}