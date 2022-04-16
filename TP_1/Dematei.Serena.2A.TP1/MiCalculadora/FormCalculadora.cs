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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia todos los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpìar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        /// <summary>
        /// Limpia todos los campos del formulario
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.ResetText();
            this.cmbOperador.ResetText();

        }


        /// <summary>
        /// Realiza entre dos numeros la  operacion indicada por el parametro operador
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {

            Operando operandoUno = new Operando(numero1);
            Operando operandoDos = new Operando(numero2);


            return Calculadora.Operar(operandoUno, operandoDos, char.Parse(operador));
        }


        /// <summary>
        /// Refleja el resultado de la operacion en un control label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string cadena;
            string numeroUno;
            string numeroDos;
            double resultado;
            double numeroValido;
            bool esNumero;

            numeroUno = this.txtNumero1.Text;
            numeroDos = this.txtNumero2.Text;



            if (((esNumero = double.TryParse(numeroUno, out numeroValido))) &&
                ((esNumero = double.TryParse(numeroDos, out numeroValido))) && (this.cmbOperador.Text != ""))
            {
                resultado = Operar(numeroUno, numeroDos, this.cmbOperador.Text);


                if (resultado == Double.MinValue)
                {
                    lblResultado.Text = "Valor inválido";
                }
                else
                {

                    cadena = $"  {this.txtNumero1.Text}  " + $"{ this.cmbOperador.Text} " + $"{this.txtNumero2.Text}" + " = " + $"{Math.Round(resultado, 3)}";
                    lblResultado.Text = Math.Round(resultado, 3).ToString();
                    lstOperaciones.Items.Add(cadena);


                }



            }
            else
            {
                lblResultado.Text = "Valor inválido";
            }



            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }






        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /// <summary>
        /// Convierte el resultado de la operacion a numero binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoBinario;
            Operando aux = new Operando();


            resultadoBinario = aux.DecimalBinario(lblResultado.Text);
            lblResultado.Text = resultadoBinario;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }


        /// <summary>
        /// Convierte el resultado de la operacion a numero decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoDecimal;
            Operando aux = new Operando();

            resultadoDecimal = aux.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultadoDecimal;
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }


        /// <summary>
        /// Confirma el cierre del formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }


            }
        }



        /// <summary>
        /// Establece los valores del comboBox e invoca al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = false;

            cmbOperador.Items.Add("");
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('/');
            cmbOperador.Items.Add('*');
            Limpiar();
        }


    }

}

