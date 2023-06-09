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
        public void GenerarDetalle(Int32 numRegistros, String fileName)
        {
            List<Detalle> listaDetalles = new List<Detalle>();
            String SaveFile = @"D:\Users\maguilarm\source\repos\archivo\archivo\" + fileName + ".txt";
            for (Int32 i = 1; i <= numRegistros; i++)
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
                
                if (!File.Exists(SaveFile))
                {
                    using (StreamWriter detalle = new StreamWriter(SaveFile))
                    {

                            String fila = (detail.tipoRegistro + detail.referenciaUsuario + detail.referenciaSecundaria + detail.ciclos + detail.codigoServicio + detail.totalRegistroDetalle + detail.valorTotalServicioPrincipal + detail.valorTotalServicioAdicional + detail.fechaVencimiento + detail.filler);
                            detalle.WriteLine(fila);
                    }

                }


            }
        }
    }
}



