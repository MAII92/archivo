﻿using ARCHIVO;
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
        public Int32 totaldelregistosDetalle { get; set; }
        public Decimal valorServicioPrincipal { get; set; }
        public Decimal numtotaldelServicioAdicional { get; set; }
        public String nReservado { get; set; }
        public  void CrearRegistroControl(List<Detalle> listaDetalles, String fileName2)
        {

            Int32 totalfilas = 0;
            Decimal totalvalores = 0;
            Decimal valores = 0;
            Int32 totalDetalles = listaDetalles.Count;
            for (Int32 i = 0; i < totalDetalles; i++)
            {
                totalfilas += 1;
                totalvalores = totalvalores + listaDetalles[i].valorTotalServicioPrincipal;
                valores = valores + listaDetalles[i].valorTotalServicioAdicional;
            }
           
                 Registrocontrol regControl = new Registrocontrol();
                 regControl.tipderegistro = "09";
                 regControl.totaldelregistosDetalle = totalfilas;
                 regControl.valorServicioPrincipal = totalvalores;
                 regControl.numtotaldelServicioAdicional = valores;
                 regControl.nReservado = new String(' ', 173);

                String SaveFile = @"C:\Proyectos\archivo\nuevo_archivo\" + fileName2 + ".txt";
            
                using (StreamWriter sw = new StreamWriter(SaveFile,true))
                {
                    String registroControl = (regControl.tipderegistro + regControl.totaldelregistosDetalle + regControl.valorServicioPrincipal + regControl.numtotaldelServicioAdicional + regControl.nReservado);

                    sw.WriteLine(registroControl.ToString());
                }

        }
    }
}    







