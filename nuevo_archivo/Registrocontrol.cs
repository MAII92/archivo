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
        public String valorServicioAdicional { get; set; }
        public String nReservado { get; set; }
        public void CrearRegistroControl(List<Detalle> listaDetalles, String fileName)
        {

            Int32 totalfilas = 0;
            Decimal totalvalores = 0;
            Decimal valores = 0;
            Int32 totalDetalles = listaDetalles.Count;
            Decimal valorTotalServicioPrincipal = 0;
            Decimal valorTotalServicioAdicional = 0;
            foreach (var item in listaDetalles)
            {
                totalfilas += 1;
                totalvalores = totalvalores + Convert.ToDecimal(item.valorTotalServicioPrincipal);
                totalvalores = totalvalores + Convert.ToDecimal(item.valorTotalServicioAdicional);
            }


           valorTotalServicioPrincipal = totalvalores; 
           valorTotalServicioAdicional = totalvalores;    

            Registrocontrol regControl = new Registrocontrol();
            regControl.tipderegistro = "09";
            regControl.totaldelregistosDetalle = totalfilas.ToString().PadLeft(9, '0');
            regControl.valorServicioPrincipal = valorTotalServicioPrincipal.ToString("00000000000000").PadLeft(18, '0');
            regControl.valorServicioAdicional = valorTotalServicioAdicional.ToString("00000000000000").PadLeft(18, '0');
            regControl.nReservado = new String(' ', 173);

            FileManager fileManager = new FileManager();

            string SaveFile = fileName + ".txt";

            String registroControl = regControl.tipderegistro + regControl.totaldelregistosDetalle + regControl.valorServicioPrincipal + regControl.valorServicioAdicional + regControl.nReservado;

            FileManager.SaveFile(fileName, registroControl);
}   }   }




