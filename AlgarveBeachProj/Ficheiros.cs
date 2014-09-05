using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text;

namespace AlgarveBeach
{
   public class Ficheiros
    {

       public void CriarComentarioFile(string DirPath,string comentario)
       {
       /*    string path = @"c:\temp\MyTest.txt";

           try
           {

               // Delete the file if it exists. 
               if (File.Exists(path))
               {
                   // Note that no lock is put on the 
                   // file and the possibility exists 
                   // that another process could do 
                   // something with it between 
                   // the calls to Exists and Delete.
                   File.AppendAllLines(path);
               }

               // Create the file. 
               using (FileStream fs = File.Create(path))
               {
                   Byte[] info = new UTF8Encoding(true).GetBytes(comentario);
                   // Add some information to the file.
                   fs.Write(info, 0, info.Length);
               }

               // Open the stream and read it back. 
               using (StreamReader sr = File.OpenText(path))
               {
                   string s = "";
                   while ((s = sr.ReadLine()) != null)
                   {
                       Console.WriteLine(s);
                   }
               }
           }

           catch (Exception Ex)
           {
               Console.WriteLine(Ex.ToString());
           }*/


           // 1: Write single line to new file
          // using (StreamWriter writer = new StreamWriter("C:\\temp\\log.txt", true))

              
               using (StreamWriter writer = new StreamWriter(DirPath, true))
               {
                   writer.WriteLine(comentario);
               }
           

       }

    }
}
