using System;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Valida si el operador es '+', '-', '*', '/'.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> si el parametro es valido retorna el operador, caso contrario retorna '+'
        private static char ValidarOperador(char operador)
        {

            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                operador = '+';
            }


            return operador;
        }

        /// <summary>
        /// Realiza entre dos numeros la  operacion indicada por el parametro operador
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> el resultado de la operacion
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = double.NaN;
            char operadorValido;




            operadorValido = ValidarOperador(operador);



            switch (operadorValido)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;

            }

            return resultado;

        }
    }

}
