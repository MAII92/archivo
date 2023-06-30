using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    public class Detalle
    {
        public String tipoRegistro { get; set; }
        public String referenciaUsuario { get; set; }
        public String referenciaSecundaria { get; set; } 
        public Int32 reservadoControl { get; set; }
        public String periodosFacturados { get; set; }
        public String ciclos { get; set; }
        public String codigoServicio { get; set; }
        public String valorTotalServicioPrincipal { get; set; }
        public String valorTotalServicioAdicional { get; set; }
        public String fechaVencimiento { get; set; }
        public String filler { get; set; }
        public List<Detalle> GenerarDetalle(Int32 numRegistros, String fileName)
        {
            List<Detalle> listaDetalles = new List<Detalle>();

            for (Int32 i = 0; i < numRegistros; i++)
            {
                Detalle detail = new Detalle();
                detail.tipoRegistro = CerosRellenar.Left(6, 2);
                detail.referenciaUsuario = CerosRellenar.Left(RandomNumber.Generar(), 48);
                detail.referenciaSecundaria = CerosRellenar.Left(RandomNumber.Generar(), 30);
                detail.periodosFacturados = "01" + CerosRellenar.Left(0, 1);
                detail.ciclos = "002";
                detail.codigoServicio = CerosRellenar.Left(0, 13);

                Decimal valorPrincipalAleatorio = 0;
                Decimal valorAdicionalAleatorio = 0;

                detail.valorTotalServicioPrincipal = valorPrincipalAleatorio.ToString("00000000000000").PadLeft(14, '0');
                detail.valorTotalServicioAdicional = valorAdicionalAleatorio.ToString("00000000000000").PadLeft(14, '0');
                detail.fechaVencimiento = DateTime.Now.AddDays(new Random().Next(1, 31) * -1).AddDays(-30).ToString("yyyyMMdd");
                detail.filler = new String('0', 86);

                listaDetalles.Add(detail);
            }

            FileManager fileManager = new FileManager();
            String SaveFile = fileName + ".txt";

            foreach (var detail in listaDetalles)
            {
                String fila = detail.tipoRegistro + detail.referenciaUsuario + detail.referenciaSecundaria + detail.ciclos + detail.valorTotalServicioPrincipal + detail.codigoServicio + detail.valorTotalServicioAdicional + detail.fechaVencimiento + detail.filler;

                FileManager.SaveFile(fileName, fila);
            }
            return listaDetalles;

           
        }

    }
}



            
        
    




