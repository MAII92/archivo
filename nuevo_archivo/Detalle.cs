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
        public Decimal valorTotalServicioPrincipal { get; set; }
        public Decimal valorTotalServicioAdicional { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public String filler { get; set; }
        public List<Detalle> GenerarDetalle(Int32 numRegistros, String fileName1)
        {
            List<Detalle> listaDetalles = new List<Detalle>();
            for (Int32 i = 0; i < numRegistros; i++)
            {
                Detalle detail = new Detalle();
                detail.tipoRegistro = CerosRellenar.Left(6, 2);
                detail.referenciaUsuario = CerosRellenar.Left(RandomNumber.Generar(), 48);
                detail.referenciaSecundaria = CerosRellenar.Left(RandomNumber.Generar(), 30);
                detail.periodosFacturados = "01";
                detail.ciclos = CerosRellenar.Left(i, 3);
                detail.codigoServicio = CerosRellenar.Left(0, 13);
                detail.valorTotalServicioPrincipal = (Int32)0000000000000000.23;
                detail.valorTotalServicioAdicional = (Int32)0000000000000000.63;
                detail.fechaVencimiento = DateTime.Now;
                detail.filler = new String('0', 86);
                listaDetalles.Add(detail);
                {
                    String SaveFile = @"C:\Proyectos\archivo\nuevo_archivo\" + fileName1 + ".txt";
                    
                        using (StreamWriter detalle = new StreamWriter(SaveFile, true))
                        {

                          String fila = (detail.tipoRegistro + detail.referenciaUsuario + detail.referenciaSecundaria + detail.ciclos + detail.codigoServicio + detail.valorTotalServicioPrincipal + detail.valorTotalServicioAdicional + detail.fechaVencimiento + detail.filler);
                          detalle.WriteLine(fila);
                        }

                }       
            }
            return listaDetalles;   
        }
    }
}



