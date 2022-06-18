using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class FrmMenuClientes : Form, ICargarListBox
    {
        bool clientesGuardados = false;
        public FrmMenuClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invoca al form de ingreso de datos del nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CargarCliente_Click(object sender, EventArgs e)
        {

            FrmCargarDatosCliente cargarDatos = new FrmCargarDatosCliente();
            cargarDatos.ShowDialog();

        }

        /// <summary>
        /// Limpia los items del listbox
        /// </summary>
        private void Limpiar()
        {
            listBox_Clientes.Items.Clear();
        }

        /// <summary>
        /// Agrega los clientes en el listbox
        /// </summary>
        public void Listar()
        {
            agregarItemsEnListBox();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            if (listBox_Clientes.SelectedItem is null)
            {
                MessageBox.Show("Primero debe seleccionar un cliente de la lista");
            }
            else
            {
                this.Eliminar((Cliente)listBox_Clientes.SelectedItem);
            }

        }

        /// <summary>
        /// Verifica si el cliente seleccionado existe en la lista y luego lo elimina
        /// </summary>
        private void Eliminar(Cliente cliente)
        {
            ClienteDAO dao = new ClienteDAO();
            try
            {

                if (dao.Borrar(cliente) && Spa.RemoverCliente(cliente))
                {
                    MessageBox.Show("Cliente eliminado con exito. Actualice la lista para ver los cambios");
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al eliminar cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Despliega el menu para modificar los datos de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            if (listBox_Clientes.SelectedItem is null)
            {
                MessageBox.Show("Primero debe seleccionar un cliente");
            }
            else
            {

                Cliente auxCliente = (Cliente)listBox_Clientes.SelectedItem;
                FrmModificarCliente modificarCliente = new FrmModificarCliente(auxCliente);
                modificarCliente.ShowDialog();

            }

        }

        /// <summary>
        /// Agrega los clientes en el listbox
        /// </summary>
        public void agregarItemsEnListBox()
        {
            for (int i = 0; i < Spa.clientes.Count; i++)
            {
                agregarUnClienteEnListBox(Spa.clientes[i]);
            }
        }

        /// <summary>
        /// Agrega un cliente en el listbox
        /// </summary>
        /// <param name="unCliente"></param>
        public void agregarUnClienteEnListBox(Cliente unCliente)
        {
            if (!listBox_Clientes.Items.Contains(unCliente))
            {
                listBox_Clientes.Items.Add(unCliente);
            }
        }


        public void Actualizar()
        {
            this.Limpiar();
            this.Listar();
        }

        /// <summary>
        /// Ordena los clientes por apellido ascendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            Spa.clientes.Sort(Spa.OrdenarPorApellidoAscendente);
            this.Actualizar();
        }

        /// <summary>
        /// Guarda los cambios realizados en un archivo json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Serializar_Click(object sender, EventArgs e)
        {
            if (Spa.GuardarClientesEnArchivoJson())     //GuardarInformacion())
            {
                MessageBox.Show("Clientes guardados");
                this.clientesGuardados = true;
            }
            else
            {
                MessageBox.Show("Problema al guardar el cliente en la base de datos");
            }

        }

        private void FrmMenuClientes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        /// <summary>
        /// Limpia el listbox y lista los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ActualizarLista_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        /// <summary>
        /// Advierte al usuario sobre el cierre sin guardar previamente los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (clientesGuardados == false)
                {
                    DialogResult resultado = MessageBox.Show(" ATENCION\nUsted no ha guardado los cambios en la lista en el archivo.Json.\n¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }

            }
        }

        /// <summary>
        /// Asigna el manejador de eventos a los botones del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CambiarColores_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Click += new EventHandler(CambiarColorFondo);
                }
            }
        }


        /// <summary>
        /// Cambia el color del fondo de los botones, una vez que se pulsan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambiarColorFondo(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;


            if (botonPulsado == this.btn_CargarCliente)
            {
                this.btn_CargarCliente.BackColor = Color.DeepPink;
            }
            if (botonPulsado == this.btn_EliminarCliente)
            {
                this.btn_EliminarCliente.BackColor = Color.DeepPink;
            }
            if (botonPulsado == this.btn_ModificarCliente)
            {
                this.btn_ModificarCliente.BackColor = Color.DeepPink;
            }
            if (botonPulsado == this.btn_Ordenar)
            {
                this.btn_Ordenar.BackColor = Color.DeepPink;
            }
            if (botonPulsado == this.btn_Serializar)
            {
                this.btn_Serializar.BackColor = Color.DeepPink;
            }
            if (botonPulsado == this.btn_ActualizarLista)
            {
                this.btn_ActualizarLista.BackColor = Color.DeepPink;
            }
        }

        /// <summary>
        /// Metodo asincrono que espera la cantidad de registros de la lista de clientes y la muestra en un label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_CantidadClientes_Click(object sender, EventArgs e)
        {
           this.label4.Text = await Spa.ContarTodosLosRegistros();      
        }
    }
}
