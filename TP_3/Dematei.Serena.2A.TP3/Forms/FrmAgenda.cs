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
    public partial class FrmAgenda : Form, ICargarListBox
    {
        
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
                DateTime fecha = calendario.SelectionStart; //try catch por si no elije fecha
                Turno nuevoTurno = new Turno(fecha, cliente, servicio);  //try catch por si turno es null
                nuevoTurno = new Turno(fecha, cliente, servicio);
                Agenda.AgendarNuevoTurno(nuevoTurno);
                MessageBox.Show("Turno agendado con exito.\nActualice la lista de turnos para verlo en su agenda");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            //if (Agenda.AgendarNuevoTurno(nuevoTurno))
            //{
            //    MessageBox.Show("Turno agendado con exito.\nActualice la lista de turnos para verlo en su agenda");
            //    this.Close();
               
            //}
            //else
            //{
            //    MessageBox.Show("Problema al agendar nuevo turno.");
            //}

            
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
    }
}
