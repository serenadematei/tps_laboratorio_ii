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
    public partial class FrmCargarDatosCliente : Form
    {
        public FrmCargarDatosCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Valida si los datos ingresados son correctos y agrega un nuevo cliente a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Aceptar_Click(object sender, EventArgs e)
        {

            if (NombreValido() && ApellidoValido() && DniValido() && TelefonoValido())
            {      
                try
                {
                    int dni = int.Parse(tb_Dni.Text);
                    Cliente nuevoCliente = new Cliente(tb_Nombre.Text, tb_Apellido.Text, tb_Telefono.Text, dni);
                    if (Spa.AgregarCliente(nuevoCliente))
                    {
                        MessageBox.Show("Cliente cargado con exito.\nActualice la lista para ver los cambios.");
                        this.Close();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocurrio un problema al intentar cargar un cliente");           
                }

            }

        }

        private bool TelefonoValido()
        {

            if (Validaciones.TelefonoYaIngresado(tb_Telefono.Text) || !Validaciones.NumericoConDiezNumeros_Telefono(tb_Telefono.Text))
            {
                MessageBox.Show("El telefono ingresado le pertenece a otra persona o no es un telefono valido.");
                tb_Telefono.Text = string.Empty;
                return false;
            }

            return true;
        }

        private bool DniValido()
        {
            if (!Validaciones.NumericoConAlMenosSieteNumeros_Dni(tb_Dni.Text) || Validaciones.DniYaIngresado(tb_Dni.Text))
            {
                MessageBox.Show("El dni ingresado le pertenece a otra persona o no es un dni valido.");
                tb_Dni.Text = string.Empty;
                return false;

            }
            return true;
        }

        private bool NombreValido()
        {
            if (!Validaciones.SoloLetrasYHastaVeinteCaracteres(tb_Nombre.Text))
            {
                MessageBox.Show("El nombre ingresado contiene caracteres invalidos o es demasiado largo.");
                tb_Nombre.Text = string.Empty;
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
