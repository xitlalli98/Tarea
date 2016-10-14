using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Salario { get; set; }

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese Nombre:");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese Edad:");
            linea = Console.ReadLine();
            Edad = int.Parse(linea);
            Console.Write("Ingrese Salario:");
            linea = Console.ReadLine();
            Salario = float.Parse(linea);
        }

        public void Impuestos()
        {
            if (Salario > 10000)
            {
                Salario = 20/ 100 * 10000;
            }
            else
            {
                if (Salario < 10000)
                {
                    Salario = 16/100 - 10000;
                }
            }
        }

        public void Imprimir()
        {
            Console.Write("Nombre:" +Nombre);
            Console.Write("Edad:" +Edad);
            Console.WriteLine("Salario con o sin impuesto:" +Salario);
            
        }
    }  
}
