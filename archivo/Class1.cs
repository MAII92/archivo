using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa un número entero:");
            string entrada = Console.ReadLine();
            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("No se ingresó ningún número.");
                Environment.Exit(0);

                Console.WriteLine("Ingresa nombre del archivo es :");
                string namefile = Console.ReadLine();
            }
              if (string.IsNullOrEmpty(entrada))
              { 
               Console.WriteLine("No se ingresó ningún archivo.");
                Environment.Exit(0);

              }
             int repeticiones = int.Parse(entrada);
             string primero, segundo, tercero, cuarto, quinto, sexto, septimo, octavo, noveno, decimo, linea = "";
             for (int i = 1; i <= repeticiones; i++)
             { 
        
               primero = CerosRellenar.Left(6, 2);
               segundo = CerosRellenar.Left(RandomNumber.Generar(), 48);
               tercero = CerosRellenar.Left(RandomNumber.Generar(), 30);
               cuarto = "01";
               quinto = CerosRellenar.Left(i, 3);
               sexto = CerosRellenar.Left(RandomNumber.Generar(), 14);
               septimo = CerosRellenar.Left(0, 13);
               octavo = CerosRellenar.Left(0, 14);
               noveno = FechaRandom.Fecha();
               decimo = CerosRellenar.Left(0, 86);
               linea += primero + segundo + tercero + cuarto + quinto + sexto + septimo + octavo + noveno + decimo;
               linea += "\n";


            
             }

            using (StreamWriter writer = new StreamWriter("C:/Users/Maria renteria/Desktop/leiner/archivo.Nfile"))
            {
                writer.Write(linea);


                writer.Write();


                writer.Dispose();
            }

        }
    }
}
