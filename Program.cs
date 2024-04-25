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
    class Operacion
    {
        /*guarda los espacios de memoria de 3 variables*/
        //modificador tipo de dato nombre 
        protected         int          valor1;
        protected         int          valor2;
        protected         int          resultado;
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
