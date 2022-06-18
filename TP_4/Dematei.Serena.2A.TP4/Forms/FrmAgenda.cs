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
    public delegate void MiDelegado(int n);
  
    public partial class FrmAgenda : Form, ICargarListBox
    {
        MiDelegado delegadoCalculadora;
        public int minutosDeServicio;
        public FrmAgenda()
        {
            InitializeComponent();
            agregarItemsEnListBox();

        }

        /// <summary>
        /// Crea un nuevo turno con la fecha, cliente y servicio elegidos por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevoTurno_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Servicio servicio = new Servicio();
           

            if (rb_Masaje.Checked)
            {
                servicio = new Masaje((ETipoMasaje)cmb_Masaje.SelectedItem, (int)cmb_MinutosMasaje.SelectedItem);
               

            }
            if (rb_Ducha.Checked)
            {
                
                servicio = new Ducha((ETipoDucha)cmb_Ducha.SelectedItem,(int)cmb_MinutosDucha.SelectedItem);
               

            }
            if(rb_TerapiaHolistica.Checked)
            {

                servicio = new Holistica((ETipoTerapiaHolistica)cmb_Holistica.SelectedItem,(int)cmb_MinutosHolistica.SelectedItem);
               
            }


            try
            {
                cliente = (Cliente)listBox1.SelectedItem;
                DateTime fecha = calendario.SelectionStart;
                Turno nuevoTurno = new Turno(fecha, cliente, servicio);  
                nuevoTurno = new Turno(fecha, cliente, servicio);
                Agenda.AgendarNuevoTurno(nuevoTurno);
                MessageBox.Show("Turno agendado con exito.\nActualice la lista de turnos para verlo en su agenda");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            
        }



        /// <summary>
        /// Carga los combolist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            cmb_Masaje.Items.Add(ETipoMasaje.Linfatico);
            cmb_Masaje.Items.Add(ETipoMasaje.PiedrasCalientes);
            cmb_Masaje.Items.Add(ETipoMasaje.Shiatsu);
            cmb_Masaje.Items.Add(ETipoMasaje.Tailandes);

            cmb_Ducha.Items.Add(ETipoDucha.Escocesa);
            cmb_Ducha.Items.Add(ETipoDucha.Finlandesa);
            cmb_Ducha.Items.Add(ETipoDucha.Sauna);

            cmb_Holistica.Items.Add(ETipoTerapiaHolistica.Acupuntura);
            cmb_Holistica.Items.Add(ETipoTerapiaHolistica.Aromaterapia);
            cmb_Holistica.Items.Add(ETipoTerapiaHolistica.MeditacionGuiada);
            cmb_Holistica.Items.Add(ETipoTerapiaHolistica.Reiki);

            cmb_MinutosMasaje.Items.Add(60);
            cmb_MinutosMasaje.Items.Add(90);
            cmb_MinutosMasaje.Items.Add(120);

            cmb_MinutosDucha.Items.Add(10);
            cmb_MinutosDucha.Items.Add(20);
            cmb_MinutosDucha.Items.Add(30);

            cmb_MinutosHolistica.Items.Add(60);
            cmb_MinutosHolistica.Items.Add(90);
            cmb_MinutosHolistica.Items.Add(120);


            this.InicializarEstadosCombos();
            

        }


        private void InicializarEstadosCombos()
        {
            cmb_Ducha.Enabled = false;
            cmb_MinutosDucha.Enabled = false;

            cmb_Holistica.Enabled = false;
            cmb_MinutosHolistica.Enabled = false;

            cmb_Masaje.Enabled = false;
            cmb_MinutosMasaje.Enabled = false;
        }


        /// <summary>
        ///  Agrega los clientes en el listbox
        /// </summary>
        public void agregarItemsEnListBox()
        {    
            listBox1.DataSource = Spa.clientes;
        }


        /// <summary>
        /// Activa e inactiva los combobox y los radiobutton segun la eleccion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_Masaje_CheckedChanged(object sender, EventArgs e)
        {
            rb_Ducha.Enabled = false;
            rb_TerapiaHolistica.Enabled = false;
            cmb_Masaje.Enabled = true;
            cmb_MinutosMasaje.Enabled = true;
           
        }
        /// <summary>
        /// Activa e inactiva los combobox y los radiobutton segun la eleccion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_Ducha_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Ducha.Enabled = true;
            cmb_MinutosDucha.Enabled = true;

            rb_Masaje.Enabled = false;
            rb_TerapiaHolistica.Enabled = false;
        }

        /// <summary>
        /// Activa e inactiva los combobox y los radiobutton segun la eleccion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_TerapiaHolistica_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Holistica.Enabled = true;
            cmb_MinutosHolistica.Enabled = true;

            rb_Ducha.Enabled = false;
            rb_Masaje.Enabled = false;
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }


        /// <summary>
        /// Invoca al metodo que calcula el precio del servicio elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CalcularPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                this.AsignarMetodo();
                delegadoCalculadora.Invoke(minutosDeServicio);
            }
            catch (NullReferenceException)
            {
                this.MensajeAdvertencia();
            }

        }

        /// <summary>
        /// Asigna al delegadoCalculadora el metodo correspondiente segun el servicio elegido por el usuario
        /// </summary>
        public void AsignarMetodo()
        {
            if (rb_Ducha.Checked)
            {
                delegadoCalculadora = this.CalcularCostoDucha;
            }
            if (rb_Masaje.Checked)
            {
                delegadoCalculadora = this.CalcularCostoMasaje;
            }
            if (rb_TerapiaHolistica.Checked)
            {
                delegadoCalculadora = this.CalcularCostoHolistica;
            }
        
        }


        /// <summary>
        /// Calcula el precio del servicio de tipo ducha segun su duracion
        /// </summary>
        /// <param name="minutos"></param>
        public void CalcularCostoDucha(int minutos)
        {     
            int costoMinutoDucha = 10;
            if (cmb_Ducha.SelectedItem is not null && cmb_MinutosDucha.SelectedItem is not null)
            {
                MessageBox.Show($"El costo de la ducha de tipo {cmb_Ducha.SelectedItem} de {minutos} minutos es de ${minutos * costoMinutoDucha}");
            }
            else
            {
                this.MensajeAdvertencia();
            }
           
        }

        /// <summary>
        /// Calcula el precio del servicio de tipo terapia holistica segun su duracion
        /// </summary>
        /// <param name="minutos"></param>
        public void CalcularCostoHolistica(int minutos)
        {

            int costoMinutoTerapiaHolistica = 20;
            if (cmb_Holistica.SelectedItem is not null && cmb_MinutosHolistica.SelectedItem is not null)
            {
                MessageBox.Show($"El costo de la sesion de {cmb_Holistica.SelectedItem} de {minutos} minutos es de ${minutos * costoMinutoTerapiaHolistica}");

            }
            else
            {
                this.MensajeAdvertencia();
            }


        }


        /// <summary>
        /// Calcula el precio del servicio de tipo Masaje segun su duracion
        /// </summary>
        /// <param name="minutos"></param>
        public void CalcularCostoMasaje(int minutos)
        {
            int costoMinutoMasaje = 30;
            if (cmb_Masaje.SelectedItem is not null && cmb_MinutosMasaje.SelectedItem is not null)
            {
                MessageBox.Show($"El costo del masaje de tipo {cmb_Masaje.SelectedItem} de {minutos} minutos es de ${minutos * costoMinutoMasaje}");
            }
            else
            {
                this.MensajeAdvertencia();
            }
           
          
        }

        /// <summary>
        /// Muestra un mensaje de advertencia al usuario
        /// </summary>
        public void MensajeAdvertencia()
        {
            MessageBox.Show("Para calcular el costo del turno, debe primero seleccionar el tipo de servicio y la cantidad de minutos.");
        }





        private void cmb_MinutosDucha_SelectedIndexChanged(object sender, EventArgs e)
        {
            minutosDeServicio = (int)cmb_MinutosDucha.SelectedItem;
        }

        private void cmb_MinutosMasaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            minutosDeServicio = (int)cmb_MinutosMasaje.SelectedItem;
        }

        private void cmb_MinutosHolistica_SelectedIndexChanged(object sender, EventArgs e)
        {
            minutosDeServicio = (int)cmb_MinutosHolistica.SelectedItem;
        }
    }
}
