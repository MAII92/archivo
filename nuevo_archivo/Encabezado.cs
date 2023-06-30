using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
        public String CodigoEntidadFinanciera { get; set; }
        public String fechaGeneracionArchivo { get; set; }
        public String horaGeneracionArchivo { get; set; }
        public String modificadorArchivo { get; set; }
        public String reservado { get; set; }

        public Encabezado CrearEncabezado(String fileName)  
        {
            Encabezado header = new Encabezado();
            header.tipoRegistro1 = "01";
            header.nitFacturadoraPrincipal = RandomNumber.Generar().ToString().PadLeft(16, '0');
            header.nitFacturadoraAdicional = RandomNumber.Generar().ToString().PadLeft(16, '0');
            header.CodigoEntidadFinanciera = RandomNumber.GenerateNewCode(3).PadLeft(3, '0');
            header.fechaGeneracionArchivo = DateTime.Now.ToString("yyyyMMdd");
            header.horaGeneracionArchivo = DateTime.Now.ToString("HHmm");
            header.modificadorArchivo = "A";
            header.reservado = new string(' ', 170);

            FileManager fileManager = new FileManager();
            String encabezados = ( header.tipoRegistro1 + header.nitFacturadoraPrincipal + header.nitFacturadoraAdicional + header.CodigoEntidadFinanciera + header.fechaGeneracionArchivo + header.horaGeneracionArchivo + header.modificadorArchivo + header.reservado);
            FileManager.SaveFile(fileName, encabezados);
            return header;

}   }   }












