﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Net.NetworkInformation;

namespace ARCHIVO
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Encabezado encabezado = new Encabezado();
            Console.WriteLine("cual es nombre del archivo ");
            String SaveFile  = Console.ReadLine();
            encabezado.CrearEncabezado(SaveFile);

            Int32 numRegistros = 0;
            Console.WriteLine("ingresar numero de registros");
            numRegistros = Int32.Parse(Console.ReadLine());
            Detalle detalle = new Detalle();
            List<Detalle> listaDetalles = detalle.GenerarDetalle(numRegistros, SaveFile);

            Registrocontrol regControl = new Registrocontrol();
            regControl.CrearRegistroControl(listaDetalles, SaveFile);
            List<Detalle> detalles= new List<Detalle>();
            Console.WriteLine("Guardar archivo");

             

        }
}   }






//}
//  return regControl;/














/*lista+= TipoRegistro + NumIdentificacion + NumIdentificacionAdicional + CodigoEntidad + Reservado + FechadeGeneracióndeArchivo + Hora + ModificadordelArchivo;//
                 linea += "\n";
                 Console.WriteLine(linea);

                try
                 {
                     using (StreamWriter writer = new StreamWriter(@"D:\Users\maguilarm\source\repos\archivo\archivo\" + filename + ".txt"))
                     {
                         writer.Write(linea);

                     }



                 }
                 catch (Exception)
                 {

                     throw
                 }

             }*/
