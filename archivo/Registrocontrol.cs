using ARCHIVO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    public class Registrocontrol
    {
        public Int16 tipderegistro { get; set; }
        public Int32 totaldelregistosDetalle { get; set; }
        public Decimal valorServicioPrincipal { get; set; }
        public Decimal numtotaldelServicioAdicional { get; set; }
        public String nReservado { get; set; }

        public Int16 Tiporegistros;
        public Registrocontrol CrearRegistroControl(List<Detalle> listaDetalles)
        {
            Registrocontrol regControl = new Registrocontrol();
            Int32 totalfilas = 0;
            Decimal totalvalores = 0;
            Decimal valores = 0;        

            for (Int32 i = 0; i < listaDetalles.Count; i++)
            {
                totalfilas += 1;
                totalvalores = totalvalores + listaDetalles[i].valorTotalServicioPrincipal;
                valores = valores + listaDetalles[i].valorTotalServicioAdicional;
            }
            

            regControl.tipderegistro = 09;
            regControl.totaldelregistosDetalle = totalfilas;
            regControl.valorServicioPrincipal = totalvalores;
            regControl.numtotaldelServicioAdicional = valores;
            regControl.nReservado = new String(' ', 173);

           





            
            return regControl;




        }
    }
}






