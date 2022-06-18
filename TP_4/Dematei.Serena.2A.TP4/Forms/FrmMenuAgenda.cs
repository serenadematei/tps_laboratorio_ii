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
    
    public partial class FrmMenuAgenda : Form,ICargarListBox
    {
        bool turnosGuardados=false;
        public FrmMenuAgenda()
        {
            InitializeComponent();
            this.Actualizar();
            TurnoExtendido.desactivador += DesactivarFuncionalidadBoton;
        }


        /// <summary>
        /// Desactiva la funcionalidad del boton Imprimir Turno
        /// </summary>
        private void DesactivarFuncionalidadBoton()
        {
            this.btn_ImprimirTurno.Enabled = false;
        }

        /// <summary>
        /// Despliega el form Agenda para crear un nuevo turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevoTurno_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.ShowDialog();
        }

        private void btn_ListarTurnos_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        /// <summary>
        /// Agrega los turnos a la listbox
        /// </summary>
        public void agregarItemsEnListBox()
        {
            for (int i = 0; i < Agenda.Turnos.Count; i++)
            {
                listBox_Turnos.Items.Add(Agenda.Turnos[i].MostrarUnTurno());
            }

        }

        private void btn_CancelarTurno_Click(object sender, EventArgs e)
        {
            
            if (listBox_Turnos.SelectedItem is null)
            {
                MessageBox.Show("Primero debe seleccionar un turno de la lista");
            }
            else
            {
                this.Eliminar();
            }
        }

        /// <summary>
        /// Busca el turno a cancelar segun su indice y lo remueve de la lista de turnos
        /// </summary>
        private void Eliminar()
        {
            try
            {
                int indice = listBox_Turnos.SelectedIndex;
                Turno auxTurno = Agenda.BuscarTurnoPorIndice(indice);

                if (Agenda.CancelarTurno(auxTurno))
                {
                    MessageBox.Show("El turno fue cancelado.");
                    this.Actualizar();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void Actualizar()
        {
            this.Limpiar();
            this.Listar();
        }

        private void Limpiar()
        {
            listBox_Turnos.Items.Clear();
        }

        public void Listar()
        {
            this.Limpiar();
            agregarItemsEnListBox();
        }

        /// <summary>
        /// Ordena los turnos por los apellidos de los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrdenarPorNombre_Click(object sender, EventArgs e)
        {
            if (Agenda.Turnos.Count == 0)
            {
                MessageBox.Show("Aun no hay turnos en la agenda.");
            }
            else
            {
                Agenda.Turnos.Sort(Agenda.OrdenarPorApellidoAscendente);
                this.Actualizar();
            }   
        }

        /// <summary>
        /// Ordena los turnos por las fechas ascedentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrdenarPorFecha_Click(object sender, EventArgs e)
        {
            if (Agenda.Turnos.Count == 0)
            {
                MessageBox.Show("Aun no hay turnos en la agenda.");
            }
            else
            {
                Agenda.Turnos.Sort(Agenda.OrdenarPorFechaAscendente);
                this.Actualizar();
            }
          
        }

        /// <summary>
        /// Guarda los cambios realizados en la lista de turnos en un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Serializar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
            if (Agenda.GuardarInformacion())
            {
                MessageBox.Show("Cambios guardados");
                turnosGuardados = true;
            }
        }

        /// <summary>
        /// Imprime un ticket del turno seleccionado en un archivo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ImprimirTurno_Click(object sender, EventArgs e)
        {
            if (listBox_Turnos.SelectedItem is null)
            {
                MessageBox.Show("Primero debe seleccionar un turno de la lista");
            }
            else
            {
                
                int indice = listBox_Turnos.SelectedIndex;
                Turno auxTurno = Agenda.BuscarTurnoPorIndice(indice);
                ArchivoTxt a = new ArchivoTxt();
                string nombreArchivo = "TicketTurno.txt";

                if (auxTurno is not null)
                {
                    if (a.Escribir(nombreArchivo, auxTurno.ImprimirTurno()))
                    {
                        MessageBox.Show($"Se imprimio el ticket del turno. \n {auxTurno.ImprimirTurno()}");
                        
                    }
                }

            }
            
        }

        /// <summary>
        /// Lee los turnos (si es que existen) de un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuAgenda_Load(object sender, EventArgs e)
        {
            Agenda.CargarInformacionTurnos();     
        }

        /// <summary>
        /// Advierte al usuario sobre el cierre sin un previo guardado de los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (turnosGuardados == false)
                {
                    DialogResult resultado = MessageBox.Show(" ATENCION\nUsted no ha guardado los nuevos turnos en la lista.\n¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }

            }
        }
    }
}
