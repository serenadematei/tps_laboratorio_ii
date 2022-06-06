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
using System.IO;

namespace Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

        }

       /// <summary>
       /// Despliega el menu de clientes
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            FrmMenuClientes menuClientes = new FrmMenuClientes();
            menuClientes.ShowDialog();
           
        }

        /// <summary>
        /// Despliega la carta de servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Servicios_Click(object sender, EventArgs e)
        {
            FrmCartaDeServicios cartaDeServicios = new FrmCartaDeServicios();
            cartaDeServicios.ShowDialog();
        }

        /// <summary>
        /// Despliega el menu de agenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            FrmMenuAgenda menuAgenda = new FrmMenuAgenda();
            menuAgenda.ShowDialog();
        }
    }
}
