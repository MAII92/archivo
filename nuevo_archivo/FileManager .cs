using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    class FileManager
    {
        public static void SaveFile(String fileName, String content)
        {

            String SaveFile = fileName + ".txt";
            
            
            using (StreamWriter sw = new StreamWriter(SaveFile, true))
            {
                sw.WriteLine(content);
            }
                Encabezado header = new Encabezado();

                String encabezados = header.tipoRegistro1 + header.nitFacturadoraPrincipal + header.nitFacturadoraAdicional + header.CodigoEntidadFinanciera + header.fechaGeneracionArchivo + header.horaGeneracionArchivo + header.modificadorArchivo + header.reservado;
                FileManager.SaveFile(content,encabezados);  
            

                Detalle detail = new Detalle();
                String fila= detail.tipoRegistro + detail.referenciaUsuario + detail.referenciaSecundaria + detail.ciclos + detail.valorTotalServicioPrincipal + detail.codigoServicio + detail.valorTotalServicioAdicional + detail.fechaVencimiento + detail.filler;
                FileManager.SaveFile(content, fila); 

                Registrocontrol regControl = new Registrocontrol();
                String registroControl = regControl.tipderegistro + regControl.totaldelregistosDetalle + regControl.valorServicioPrincipal + regControl.nReservado;
                FileManager.SaveFile(content, registroControl);    
                
            
           
    }   }  
}
        
        
   


