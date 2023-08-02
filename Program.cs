using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_CSharp_4_VariableTypes
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 


        //Cuando se codifica en window form, no se puede declarar variables aqui, por lo tanto debera hacerse dentro de main.



        [STAThread]
        static void Main()
        {


            //VARIABLES Y TIPOS DE DATOS
            //String Nombre = "El nombre es en tipo texto"; 
            //Nota: Aqui en C# es muy importante el uso de minusculo o mayuscula al inicio
            // por ejemplo String con la letra mayuscula indica que es una clase
            //mientras que si requerimos utilizar en este caso string, debe emplearse en minusculam para manejar tipo de dato.
            
            string Nombre = "El nombre es en tipo texto";//Esta variable es de tipo string //Si en string se ingresa un numero, este no se podra utilizar para realizar operaciones matematicas o cosas parecidad, ya que se considerara como cadena de texto.
            
            int num1 = 30400;  //Esta variable es de tipo numerico, y solo acepta numeros enteros, pueden ser positivos o negativos.
            uint num2 = 400; //es igual que el int, pero nunca sera negativo
            
            float num3 = 45.5f; //en este es para numeros con decimales //La letra F es necesaria
            double num4 = 456.99; // es muy parecido al float, solo que en este se pueden aceptar cantidades mas grandes
            decimal num5 = 332432.32323232m;//Este sirve igual que los anteriores, solo que puede manejar cantidades enormes, y al final de la cifra debe ir una letra M

            byte num6 = 255; //Este es para manejar cantidades pequeñas, por ejemplo la edad de una persona, este tipo de dato solo llega  255, si tiene mas dara error.

            bool acceso1 = false; //Este tipo de dato es de tipo booleano
            bool acceso2 = true;  //este tipo de dato, Solo acepta true o false

            DateTime fecha = DateTime.Today; //Es para almacenar la fecha actual o de hoy.


            int num7, num8, num9, num10, num11, num12;
            num7 = 122; num8 = 132; num9 = 172; num10 = 182; num11 = 1222; num12 = 126;
            
            int a = 1, b = 2, c = 3, d = 4;

            string dato = "Hola, esto esta activo!!";
            dato = "Hola, esto ya no esta activo!!";

            const string datoUnico = "Hola, esto es unico!!";

            //CONVERTIR UN DATO A STRING - TOSTRING()

            /*
             * 
             * Para mostrar en un cuadro de texto un dato
             * numerico (y tambien aplica para datos de tipo 
             * booleanos, de fecha), no sera posible hacerlo, ya que
             * solo se podra hacer con datos de tipo de cadena
             * de texto, es decir, a continuacion muestro 
             * claramente un error:
             * 
             * MessageBox.Show(num1);
             * 
             * Lo de arriba da error, por lo tanto lo 
             * correcto seria asi:
             * 
             * MessageBox.Show(num1.ToString());
             * 
             * 
             * Lo de arriba no causara ningura modificacion,
             * solo lo transforma para poder visualizarlo,
             * no para modificar el tipo de dato, al menos no por lo 
             * mientras.
             */

            //GUARDAR UNA FECHA EN UNA VARIABLE
            /*
             * 
             * Eso se muestra en la linea 46 de este codigo
             * 
             * 
             * 
             * 
             */

            //APROVECHAR EL ESPACIO AL DECLARAR VARIAS VARIABLES 
            /*
             * En dados caso requerimos hacer o declarar variables,
             * en las cuales ocupamos muchas lineas, ejemplo:
             * 
             *int num7 = 122;
             *int num8 = 132;
             *int num9 = 172;
             *int num10 = 182;
             *int num11 = 1222;
             *int num12 = 126;
             * 
             * Pero esas lineas se puedes reducir de la siguiente
             * forma:
             * 
             * 
             *int num7, num8, num9, num10, num11, num12;
             *num7 = 122; num8 = 132; num9 = 172; num10 = 182; num11 = 1222; num12 = 126;
             * 
             * O tambien puede ser:
             * 
             * int a = 1, b = 2, c = 3, d = 4;
             * 
             */


            //CREAR UNA CONSTANTE
            /*
             * Para crear una constante se debe de hacer lo siguiente:
             * 
             * Esto es una variable:
             *
             * string datoUnico = "Hola, esto es unico!!";
             * 
             * Esto es una constante:
             * 
             * const string datoUnico = "Hola, esto es unico!!";
             * 
             */



            ///MessageBox.Show("Test");//Este sirve para manejarlo como un alert o un mensaje //Hay partes que al querer codificar, te aparece en busqueda relacionada, para seleccionar lo que quieres se da clic en dos veces en TAB //Para rapido mbox
            //MessageBox.Show(Nombre); //Aqui se muestra el valor de la variable 
            //MessageBox.Show(num1.ToString());
            //MessageBox.Show(acceso1.ToString());
            //MessageBox.Show(fecha.ToString()); //para mostrar toda la fecha
            //MessageBox.Show(fecha.ToShortDateString().ToString()); //para mostrar fecha de manera corta
            //MessageBox.Show(fecha.Year.ToString()); //para mostrar solo el año
            //MessageBox.Show(num9.ToString());
            //MessageBox.Show(b.ToString());
            MessageBox.Show(dato);
            MessageBox.Show(datoUnico);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
}
}
