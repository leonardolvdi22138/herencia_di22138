using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /*programa de herencia 
     * herencia es la caracterisitica de pasar atributos y metodos 
     * a otros objetos o clases*/
    //clase mama
    //esto es un comentario nuevo 26 de abril
    //esto es un  segundo comentario nuevo 26 de abril

    class Operacion
    {
        /*guarda los espacios de memoria de 3 variables*/
        //modificador tipo de dato nombre  //mesajeesss
        protected         float       valor1;
        protected         float       valor2;
        protected         float        resultado;
        // atributos de la clase operacion NINGUNO
        /*los metodos que se ponen a continuacion
         * son las funciones de  obtener el valor 
         * de la caja de texto y guardarlo en la 
         * memoria dentro de la variable indicada*/
        //USAMOS UN CONSTRUCTOR POR CADA CAJA DE MEMORIA 
        public float Valor1 //CAJA DE MEMORIA 1
        {
             get { return valor1; } //vamos por el valor
            set { valor1 = value; } //lo guardamos en memoria 
        }
        public float Valor2 //CAJA DE MEMORIA 2
        {
            get { return valor2; } //vamos por el valor
            set { valor2 = value; } //lo guardamos en memoria 
        }
        public float Resultado //CAJA DE MEMORIA 3 resultado 
        {
            get { return resultado; } //vamos por el valor
            set { resultado = value; } //lo guardamos en memoria 
        }
    }
    //CREAMOS NUESTRAS CLASES HIJOS QUE USARA
    //METODOS DE CREAR DATOS
     //ESTO ES UN NUEVO COMENTARIO NUEVO 02/05/2024

    class sumar : Operacion //los : nos dan permisos de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y metodos
        //pueden tener variables de uso solamente
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase

        public float operar (float v1,float v2)
        {
            valor1 =v1; //hacemos al constructor de operacion
            valor2 =v2;
            return resultado = valor1 + valor2;
        }
    }
    class restar : Operacion //los : nos dan permisos de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y metodos
        //pueden tener variables de uso solamente
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase

        public float operar(float v1, float v2)
        {
            valor1 = v1; //hacemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class multiplicar: Operacion //los : nos dan permisos de usar
                            //lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus
        //propios atributos y metodos
        //pueden tener variables de uso solamente //hola
        //para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase

        public float operar(float v1, float v2)
        {
            valor1 = v1; //hacemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class dividir : Operacion //los : nos dan permisos de usar
                                  //lo que tiene operacion
    {
        public double Operar(float num1, float num2)
        {
            // Verificar si el divisor es cero para evitar una división por cero
            if (num2 == 0)
            {
                throw new ArgumentException("No se puede dividir entre cero.");
            }

            // Realizar la división y devolver el resultado
            return (double)num1 / num2;
        }

        public float operar(float v1, float  v2)
        {
            valor1 = v1; //hacemos al constructor de operacion wwwww
            valor2 = v2;
            return resultado = valor1 / valor2;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new calculadora());
        }
    }
}
