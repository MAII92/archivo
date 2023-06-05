using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ARCHIVO
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Encabezado encabezado = new Encabezado();
            Console.WriteLine("cual es nombre del archivo ");
            string namefile = Console.ReadLine();
            String path = @"D:\Users\maguilarm\source\repos\archivo\archivo\" + namefile + ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Encabezado en = encabezado.CrearEncabezado();

                    sw.WriteLine(en.tipoRegistro1 + en.nitFacturadoraPrincipal + en.nitFacturadoraAdicional + en.CodigoEntidadFinanciera + en.horaGeneracionArchivo + en.fechaGeneracionArchivo + en.modificadorArchivo + en.reservado);
                    Console.ReadLine();

                    Int64 numRegistros = 0;
                    Console.WriteLine("ingresar numero de registros");
                    numRegistros = Int64.Parse(Console.ReadLine());
                    Detalle detalle = new Detalle();
                    List<Detalle> listaDetalle = new List<Detalle>();
                    listaDetalle = detalle.GenerarDetalle(numRegistros);
                    Console.ReadLine();

                    Registrocontrol regControl = new Registrocontrol();
                    regControl.CrearRegistroControl(listaDetalle);
                    List<Detalle> detalles = new List<Detalle>();
                    Console.ReadLine();

                    Registrocontrol reg = new Registrocontrol();
                    sw.WriteLine(reg.tipderegistro + reg.totaldelregistosDetalle + reg.valorServicioPrincipal + reg.numtotaldelServicioAdicional + regControl.nReservado);

                }

            }

            


           

            //}
            //  return regControl;/











        }


    }
}


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
