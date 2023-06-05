using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    public class Detalle
    {
        public Int16 tipoRegistro { get; set; }
        public Int16 referenciaUsuario { get; set; }
        public Int16 referenciaSecundaria { get; set; }
        public Int16 totalRegistroDetalle { get; set; }
        public Int32 reservadoControl { get; set; }
        public String periodosFacturados { get; set; }
        public String ciclos { get; set; }
        public String codigoServicio { get; set; }
        public Decimal valorTotalServicioPrincipal { get; set; }
        public Decimal valorTotalServicioAdicional { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public String filler { get; set; }
        public List<Detalle> GenerarDetalle(Int64 numRegistros)
        {
            List<Detalle> listaDetalles = new List<Detalle>();

            for (Int16 i = 1; i <= numRegistros; i++)
            {
                Detalle detail = new Detalle();
                detail.tipoRegistro = 6;
                detail.referenciaUsuario = 48;
                detail.referenciaSecundaria = 30;
                detail.periodosFacturados = "01";
                detail.ciclos = "03";
                detail.codigoServicio = "13";
                detail.totalRegistroDetalle = 1000;
                detail.valorTotalServicioPrincipal = 14;
                detail.valorTotalServicioAdicional = 14;
                detail.fechaVencimiento = DateTime.Now;
                detail.filler = new String(' ', 86);
                listaDetalles.Add(detail);

                Detalle detalle = new

               sw.WriteLine(detalle.tipoRegistro+ detalle.referenciaUsuario + detalle.referenciaSecundaria + detalle.ciclos + detalle.codigoServicio + detalle.totalRegistroDetalle + detalle.valorTotalServicioPrincipal + detalle.valorTotalServicioAdicional+ detalle.fechaVencimiento + detalle.filler);
                Console.ReadLine();

                String fileName = Console.ReadLine();
                String SaveFile=@"D:\Users\maguilarm\source\repos\archivo\archivo\" + fileName + ".txt";

            }
            return listaDetalles;
        }



    }
}



