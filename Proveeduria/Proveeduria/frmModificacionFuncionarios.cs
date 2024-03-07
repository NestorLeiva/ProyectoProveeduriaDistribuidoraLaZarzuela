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
    public partial class frmModificacionFuncionarios : Form
    {
        public frmModificacionFuncionarios()
        {
            InitializeComponent(); 
        }
        private void frmModificacionFuncionarios_Load(object sender, EventArgs e)
        {
            CargarListaFuncionariosMod("Funcionarios.xml");
        }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        Funcionario _Funcionario;
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/
        private int indiceFilaSeleccionada;
        private string codigoFuncionarioSeleccionado;
        private string dniSeleccionado;
        private string nombreSeleccionado;
        private string apellidoPrimeroSeleccionado;
        private string apellidoSegundoSeleccionado;
        private string emailSeleccionado;
        private string contraseniaSeleccionada;
        private string estadoSeleccionado;
        private bool estadoModificado = false;

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/

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

        private void txtFuncionarioEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionarioConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        /*------------------------------------------------- Botones --------------------------------------------------------------------*/
        private void btnModificarConsutar_Click(object sender, EventArgs e)
        {
            try
            {
                string consultaDNI = txtFuncionarioConsulta.Text;
                lvListaFuncionarios.Items.Clear();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Funcionarios.xml");

                XmlNode _nodoFuncionario = xmlDoc.SelectSingleNode($"//Funcionario[Identificacion='{consultaDNI}']");
                /* se realiza la busqueda en todos los nodos "Hijo /
				  [Identificacion='{consulta}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaId  "*/

                if (_nodoFuncionario != null)
                {
                    ListViewItem _itemFuncionario = new ListViewItem(_nodoFuncionario.SelectSingleNode("Identificacion").InnerText);

                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("Nombre").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("ApellidoPrimero").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("ApellidoSegundo").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("Email").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("CodigoFuncionario").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("Contrasenia").InnerText);
                    _itemFuncionario.SubItems.Add(_nodoFuncionario.SelectSingleNode("Estado").InnerText);

                    lvListaFuncionarios.Items.Add(_itemFuncionario);
                    /*agrego los datos a la lista*/

                    if (_nodoFuncionario != null)
                    {
                        ListViewItem itemSeleccionado = lvListaFuncionarios.Items[indiceFilaSeleccionada];


                        if (indiceFilaSeleccionada != -1)
                        {
                            // Obtener los datos de la fila seleccionada

                            dniSeleccionado = itemSeleccionado.SubItems[0].Text;
                            nombreSeleccionado = itemSeleccionado.SubItems[1].Text;
                            apellidoPrimeroSeleccionado = itemSeleccionado.SubItems[2].Text;
                            apellidoSegundoSeleccionado = itemSeleccionado.SubItems[3].Text;
                            emailSeleccionado = itemSeleccionado.SubItems[4].Text;
                            codigoFuncionarioSeleccionado = itemSeleccionado.SubItems[5].Text;
                            contraseniaSeleccionada = itemSeleccionado.SubItems[6].Text;
                            estadoSeleccionado = itemSeleccionado.SubItems[7].Text;
                            /*almaceno los datos en las variables*/

                            txtFuncionarioNombre.Text = nombreSeleccionado.ToUpper();
                            txtFuncionarioApellidoPrimero.Text = apellidoPrimeroSeleccionado.ToUpper();
                            txtFuncionarioApellidoSegundo.Text = apellidoSegundoSeleccionado.ToUpper();
                            txtFuncionarioEmail.Text = emailSeleccionado.ToUpper();
                            txtModificarContrasenia.Text = contraseniaSeleccionada.ToUpper();
                            txtFuncionarioDNI.Text = dniSeleccionado;
                            txtFuncionarioCodigo.Text = codigoFuncionarioSeleccionado;
                            /*pinta los datos en los TextBox*/
                        }


                        if (estadoSeleccionado == "Activo")
                        {
                            rbtnEstadoActivo.Checked = true;
                            rbtnEstadoInactivo.Checked = false;
                        }
                        else if (estadoSeleccionado == "Inactivo")
                        {
                            rbtnEstadoInactivo.Checked = true;
                            rbtnEstadoActivo.Checked = false;
                        }
                        estadoModificado = true;
                        /*Selecciono el Estado*/

                    } // Obtener el índice de la fila seleccionada

                }
                else
                {
                    MessageBox.Show("No se encontro ningun Funcionario con la Identificacion: " + consultaDNI);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar la Lista de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin boton  Consultar*/

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceFilaSeleccionada != -1) 
                {
                    
                    string nuevoNombre = txtFuncionarioNombre.Text.ToUpper();
                    string nuevoApellidoPrimero = txtFuncionarioApellidoPrimero.Text.ToUpper();
                    string nuevoApellidoSegundo = txtFuncionarioApellidoSegundo.Text.ToUpper();
                    string nuevoEmail = txtFuncionarioEmail.Text.ToUpper();
                    string nuevoContrasenia = txtModificarContrasenia.Text.ToUpper();

                    // Obtener el nuevo estado
                    string nuevoEstado = rbtnEstadoActivo.Checked ? "Activo" : "Inactivo";




                    _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/Nombre", nuevoNombre);
                    _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/ApellidoPrimero", nuevoApellidoPrimero);
                    _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/ApellidoSegundo", nuevoApellidoSegundo);
                    _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/Email", nuevoEmail);
                    _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/Contrasenia", nuevoContrasenia);

                    if (estadoModificado)
                    {
                        _ArchivoXML.modificarXML("Funcionarios.xml", $"//Funcionario[Identificacion='{dniSeleccionado}']/Estado", nuevoEstado);
                    }
                    /*Modifica solo Si ha sido Cambiado*/



                    MessageBox.Show("Funcionario modificado correctamente.");
                    CargarListaFuncionariosMod("Funcionarios.xml");
                    // Recargar la lista después de la modificación
                    LimpiarTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar el Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin boton modificar*/

        private void btnModifcarLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        } /*fin boton limpiar*/

        private void btnModificarActualizar_Click(object sender, EventArgs e)
        {
            CargarListaFuncionariosMod("Funcionarios.xml");
        } /*fin boton actualizar*/

        private void btnModificarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } /*fin boton cancelar*/


        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/
        private void CargarListaFuncionariosMod(string rutaArchivo)
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

        private void lvListaFuncionarios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /* actualizar varios TextBox con la información del elemento seleccionado en el ListView */

            /*implemento el evento Select Indez Changed*/
            if (lvListaFuncionarios.SelectedItems.Count > 0)
            {
                ListViewItem obtenerItemFuncionario = lvListaFuncionarios.SelectedItems[0];

                /**/
                txtFuncionarioConsulta.Text = obtenerItemFuncionario.SubItems[0].Text;
                txtFuncionarioNombre.Text = obtenerItemFuncionario.SubItems[1].Text;
                txtFuncionarioApellidoPrimero.Text = obtenerItemFuncionario.SubItems[2].Text;
                txtFuncionarioApellidoSegundo.Text = obtenerItemFuncionario.SubItems[3].Text;
                txtFuncionarioDNI.Text = obtenerItemFuncionario.SubItems[4].Text;
                txtFuncionarioCodigo.Text = obtenerItemFuncionario.SubItems[5].Text;
                txtFuncionarioEmail.Text = obtenerItemFuncionario.SubItems[6].Text;
                txtModificarContrasenia.Text = obtenerItemFuncionario.SubItems[7].Text;

            }
            
        }/*fin evento ListView*/


        public void LimpiarTextBox()
        {
            txtFuncionarioConsulta.Text = string.Empty;
            txtFuncionarioNombre.Text = string.Empty;
            txtFuncionarioApellidoPrimero.Text = string.Empty;
            txtFuncionarioApellidoSegundo.Text = string.Empty;
            txtFuncionarioEmail.Text = string.Empty;
            txtFuncionarioCodigo.Text = string.Empty;
            txtFuncionarioDNI.Text = string.Empty;
            txtModificarContrasenia.Text= string.Empty;
        }


    } /*fin frmModificacionFuncionarios*/
}/*fin Proveeduria*/
