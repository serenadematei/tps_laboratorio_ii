using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {

        private double numero;


        /// <summary>
        /// Constructor que inicializa el atributo de la clase en cero
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que inicializa el atributo de la clase con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que inicializa el atributo de la clase con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Operando(string numero)
        {
            this.Numero = numero;

        }


        /// <summary>
        /// Asigna el valor al atributo numero luego de validarlo.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }

        }



        /// <summary>
        /// Valida si el valor pasado por parametro es un numero y lo retorna. Caso contrario retorna cero.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            bool esNumero;
            double numero;

            esNumero = double.TryParse(strNumero, out numero);
            if (esNumero)
            {
                return numero;
            }


            return 0;
        }

        /// <summary>
        /// Valida si el valor pasado por parametro es un numero binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convierte el numero binario pasado por parametro en su valor decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";

            double acumulador = 0;
            string decimalStr;
            int cantidadCaracteres;
            int j = 0;

            if (this.EsBinario(binario))
            {


                cantidadCaracteres = binario.Length;
                for (int i = cantidadCaracteres - 1; i >= 0; i--)
                {

                    if (binario[i] == '1')
                    {
                        acumulador += Math.Pow(2, j);
                    }
                    j++;
                }


                decimalStr = acumulador.ToString();
                retorno = decimalStr;


            }

            return retorno;
        }





        /// <summary>
        /// Convierte el numero decimal pasado por parametro en su valor binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            bool esValido;
            double numeroDouble;

            esValido = double.TryParse(numero, out numeroDouble);
            if (esValido)
            {
                return DecimalBinario(numeroDouble);
            }

            return retorno;
        }









        /// <summary>
        /// Convierte el numero decimal pasado por parametro en su valor binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido";


            string cadenaInvertida;
            int resto;
            string restoStr;
            string binarioStr = "";
            double cociente;
            double auxNumero;


            if (numero > 1 || numero < 0)
            {
                auxNumero = Math.Abs(numero);

                do
                {

                    cociente = auxNumero / 2;
                    resto = (int)auxNumero % 2;
                    restoStr = resto.ToString();

                    binarioStr += restoStr;
                    auxNumero = cociente;

                } while (cociente >= 2);


                binarioStr += "1";
                cadenaInvertida = InvertirCadena(binarioStr);
                retorno = cadenaInvertida;
            }
            else if (numero == 0)
            {
                retorno = "0";
            }
            else if (numero == 1)
            {
                retorno = "1";
            }



            return retorno;
        }


        /// <summary>
        /// Invierte la cadena que recibe por parametro y la devuelve.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string InvertirCadena(string cadena)
        {
            string cadenaInvertida = "";
            int cantidadCaracteres;
            cantidadCaracteres = cadena.Length;



            for (int i = cantidadCaracteres - 1; i >= 0; i--)
            {
                cadenaInvertida += cadena[i];
            }


            return cadenaInvertida;

        }









        /// <summary>
        /// Realiza la suma entre dos objetos de tipo Operando y devuelve su resultado
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Realiza la resta entre dos objetos de tipo Operando y devuelve su resultado
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Realiza la multiplicacion entre dos objetos de tipo Operando y devuelve su resultado
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza la division entre dos objetos de tipo Operando y devuelve su resultado
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {


            if (n2.numero == 0)
            {
                return double.MinValue;
            }


            return n1.numero / n2.numero;
        }

    }
}
