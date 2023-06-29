using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ARCHIVO
{
    public class Encabezado
    {
        public String tipoRegistro1 { get; set; }
        public String nitFacturadoraPrincipal { get; set; }
        public String nitFacturadoraAdicional { get; set; }
        public Int16 CodigoEntidadFinanciera { get; set; }
        public DateTime fechaGeneracionArchivo { get; set; }
        public DateTime horaGeneracionArchivo { get; set; }
        public String modificadorArchivo { get; set; }
        public String reservado { get; set; }

        public Encabezado CrearEncabezado(String fileName)
        {
            Encabezado header = new Encabezado();
            header.tipoRegistro1 = "01";
            header.nitFacturadoraPrincipal = "0000000123456789";
            header.nitFacturadoraAdicional = "0000000789654321";
            header.CodigoEntidadFinanciera = 123;
            header.fechaGeneracionArchivo = DateTime.Now;
            header.horaGeneracionArchivo = DateTime.Now;
            header.modificadorArchivo = "A";
            header.reservado = new string(' ', 170);
            { 
                String SaveFile =@"C:\Proyectos\archivo\nuevo_archivo\" + fileName + ".txt";

                if (!File.Exists(SaveFile))
                string content = "Este es el contenido del archivo.";
                {
                    using (StreamWriter sw = new StreamWriter(SaveFile))
                    {
                        String encabezados=(header.tipoRegistro1 + header.nitFacturadoraPrincipal + header.nitFacturadoraAdicional + header.CodigoEntidadFinanciera + header.horaGeneracionArchivo + header.fechaGeneracionArchivo + header.modificadorArchivo + header.reservado);

                        sw.WriteLine(encabezados);
                    }







                }
            }
            
                return header;
        }
        
    }
}











