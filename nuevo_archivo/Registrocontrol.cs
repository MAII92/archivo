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
        public void CrearRegistroControl(List<Detalle>  listaDetalles, String fileName)
        {

            Int32 totalfilas = 0;
            Decimal  totalvalores = 0;
            Decimal valores = 0;
            Int32 totalDetalles = listaDetalles.Count;
            foreach (var item in listaDetalles)
            {
                totalfilas += 1;
                totalvalores = totalvalores + Convert.ToDecimal(item.valorTotalServicioPrincipal);
                valores = valores +Convert.ToDecimal(item.valorTotalServicioAdicional);      
            }

            Registrocontrol regControl = new Registrocontrol();
            regControl.tipderegistro = "09";
            regControl.totaldelregistosDetalle = totalfilas.ToString().PadLeft(9, '0');//sirve de relleno para los caracteres restantes 
            regControl.valorServicioPrincipal = totalvalores.ToString().PadLeft(16, '0');
            regControl.valorTotalServicioAdicional = valores.ToString().PadLeft(16, '0');
            regControl.nReservado = new String(' ', 173);

            String SaveFile = fileName+ ".txt";

            using (StreamWriter sw = new StreamWriter(SaveFile, true))
            {
                String registroControl = (regControl.tipderegistro + regControl.totaldelregistosDetalle + regControl.valorServicioPrincipal  + regControl.nReservado);

                sw.WriteLine(registroControl.ToString());
            }
       
        }

}   }



/* totalvalores.ToString();
valores.ToString();*/

/*      totalfilas += 1;
                totalvalores += listaDetalles[i].valorTotalServicioPrincipal.tostring;
                valores += listaDetalles[i].valorTotalServicioAdicional;

// recorrer los elementos mediante una iteracion */