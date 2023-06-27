using ARCHIVO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    public class Registrocontrol
    {
        public String tipderegistro { get; set; }
        public String totaldelregistosDetalle { get; set; }
        public String valorServicioPrincipal { get; set; }
        public String valorTotalServicioAdicional { get; set; }
        public String nReservado { get; set; }
        public void CrearRegistroControl(List<Detalle> listaDetalles, String fileName)
        {

            Int32 totalfilas = 0;
            Decimal totalvalores = 0;
            Decimal valores = 0;
            Int32 totalDetalles = listaDetalles.Count;
            foreach (var item in listaDetalles)
            {
                totalfilas += 1;
                totalvalores = totalvalores + Convert.ToDecimal(item.valorTotalServicioPrincipal);
                valores = valores + Convert.ToDecimal(item.valorTotalServicioAdicional);
            }
            Decimal GenerarDecimal()
            {
                Random rnd = new Random();
                Int32 valorEntero = rnd.Next(1000000, 10000000);
                Decimal valorDecimal = rnd.Next(0, 10000) / 100m;
                Decimal val = new Decimal(valorEntero) + valorDecimal;
                return val;
            }

            Decimal valorPrincipalAleatorio = GenerarDecimal();
            Decimal valorAdicionalAleatorio = GenerarDecimal();

            Registrocontrol regControl = new Registrocontrol();
            regControl.tipderegistro = "09";
            regControl.totaldelregistosDetalle = totalfilas.ToString().PadLeft(9, '0');
            regControl.valorServicioPrincipal = valorPrincipalAleatorio.ToString("00000000000000").PadLeft(16, '0');
            regControl.valorTotalServicioAdicional = valorAdicionalAleatorio.ToString("00000000000000").PadLeft(16, '0');
            regControl.nReservado = new String(' ', 173);

            Decimal valorServicioPrincipal = 0;
            Decimal valorTotalServicioAdicional = 0;

            foreach (var detail in listaDetalles)
            {
                valorServicioPrincipal += Convert.ToDecimal(detail.valorTotalServicioPrincipal);
                valorTotalServicioAdicional += Convert.ToDecimal(detail.valorTotalServicioAdicional);
            }

            regControl.valorServicioPrincipal += valorServicioPrincipal.ToString("00000000000000").PadLeft(16, '0');
            regControl.valorTotalServicioAdicional += valorTotalServicioAdicional.ToString("00000000000000").PadLeft(16, '0');
      

            FileManager fileManager = new FileManager();

            string SaveFile = fileName + ".txt";

            String registroControl = regControl.tipderegistro + regControl.totaldelregistosDetalle + regControl.valorServicioPrincipal + regControl.nReservado;

            FileManager.SaveFile(fileName, registroControl);
        }
    }

}   


