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
    public partial class FrmModificarCliente : Form
    {
        Cliente auxCliente;
        
        public FrmModificarCliente(Cliente unCliente)
        {
            InitializeComponent();
            auxCliente = new Cliente();

            auxCliente = unCliente;
            rtb_ClienteEncontrado.Text = unCliente.ToString();
           
        }

 
        /// <summary>
        /// Descarta las modificaciones realizadas y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CancelarCambios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios descartados");
            this.Close();
        }

        /// <summary>
        /// Valida si los datos ingresados son validos y modifica al cliente, cerrando el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarCambios_Click(object sender, EventArgs e)
        {

            if (NombreValido() && ApellidoValido() && TelefonoValido())
            {

                auxCliente.Nombre = tb_nombre.Text;
                auxCliente.Apellido = tb_Apellido.Text;
                auxCliente.Telefono = tb_telefono.Text;

                MessageBox.Show("Cliente modificado con exito!\nActualice la lista para ver los cambios.");
                this.Close();
            }
        }

        private bool TelefonoValido()
        {

            if (!Validaciones.NumericoConDiezNumeros_Telefono(tb_telefono.Text))
            {
                MessageBox.Show("El telefono ingresado no es un telefono valido.");
                tb_telefono.Text = string.Empty;
                return false;
            }

            return true;
        }

       

        private bool NombreValido()
        {
            if (!Validaciones.SoloLetrasYHastaVeinteCaracteres(tb_nombre.Text))
            {
                MessageBox.Show("El nombre ingresado contiene caracteres invalidos o es demasiado largo.");
                tb_nombre.Text = string.Empty;
                return false;
            }
            return true;
        }

        private bool ApellidoValido()
        {
            if (!Validaciones.SoloLetrasYHastaVeinteCaracteres(tb_Apellido.Text))
            {
                MessageBox.Show("El apellido ingresado contiene caracteres invalidos o es demasiado largo.");
                tb_Apellido.Text = string.Empty;
                return false;
            }
            return true;
        }

    }
}
