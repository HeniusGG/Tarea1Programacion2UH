using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Progra2_Fundamentos_de_programacion
{
    internal class Program
    {
        private static float total;

        /*
uint solo puede poner numero en positivos
ulong solo puede poner numeros en positivos
long sirve para poner numeros muy largos para negativo y positivo
int sirve para poner numeros no tan largos para negativo y positivo
byte hasta 255
sbyte hasta 127 y en negativo hasta el -128

float es flotante y se escribe en decimal 25.36f
double igual es para decimal 100.5d
decimal igual es una decimal 56.65m

String para poner palabras como "Miguel" siempre en comillas
Char solo puede poner un caracter como 'g' siempre en comillas unicas
*/

        static void Main(string[] args)
        {
            int num1 = 214748364;
            uint valo1 = 0;
            int num2 = 5, num3 = 6;
            long largas = 21474836488888;
            ulong ularga = 2222;
            byte b = 100;
            sbyte s = 23;
            int? Total = null;


            float flotante = 25.36f;
            double doble = 100.5d;
            decimal dec = 56.65m;

            bool boleana = new bool();
            // var y dynamic

            var variable = 20.03f;
            variable = 20;
           
           
            dynamic dinamico = "Hola mundo";
            dinamico = 20.699f;
            dinamico = true;

            var persona = new {NOMBRE = "MIGUEL", APELLIDO="PEREZ", Edad = 45 };
            Console.WriteLine($" {persona.NOMBRE} {persona.APELLIDO} {persona.Edad} ");

            string nombre = "Astrid";
            string Nombre = "Jose Juan";
            string apellido = "Granger";
            string Apellido = "Diaz";
            char caracter = 'm';

            Console.WriteLine("total: " + Total + "Boleana: " + boleana);
            Console.WriteLine(nombre + " " + Apellido);
            Console.WriteLine(Nombre + " " + apellido);
            //Desplegar con parametros
            Console.WriteLine("La estudiante se llama {0} {1}", nombre, Apellido);
            //Desplegar con interpolaion
            Console.WriteLine($"El estudiante se llama {Nombre} {apellido}");
           
            Console.ForegroundColor = ConsoleColor.Red;

            //contadores
            //Contadores
            float salario = 0;
            float total = 0;

            total += salario; // total = total + salario 
            total *= salario; // total = total * salario
            total -= salario; // total = total - salario
            total /= salario; // total = total / salario

            //Arreglos y matrices
            int[] edad = new int[] { 20, 22, 33 }; // arreglo de tres posiciones
            float[] salarios = new float[] { 200, 300, 150 };

            string[] musico = new string[3];
            musico[0] = "Juan";
            musico[1] = "Roger";
            musico[2] = "Alexis";

            string[] arreglo;
            Console.WriteLine("Digite el tamaño");
            uint tamanio = uint.Parse(Console.ReadLine());
            arreglo = new string[tamanio];

            //cree una variable para sumar todos los salarios + el iva <3
            //Ciclo for
            float sumaTotalSalarios = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                float IVA = salarios[i] * 0.13f;
                Console.WriteLine($"{musico[i]} Edad: {edad[i]} Salario: {salarios[i]} IVA: {IVA} Total: {salarios[i] + IVA}");
                sumaTotalSalarios += salarios[i];
            }

            Console.WriteLine("Suma total de salarios: " + sumaTotalSalarios);
            Console.ReadLine();



            Console.ReadLine();
        }//End main 
    
    
    }//End class


}//End namespace
