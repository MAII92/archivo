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

           
    }   }  
}
        
        
   


