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
               using (StreamWriter writer = new StreamWriter(DirPath, true))
               {
                   writer.WriteLine(comentario);
               }
       }

       public void LerComentarios(string DirPath)
       {
           // The files used in this example are created in the topic 
           // How to: Write to a Text File. You can change the path and 
           // file name to substitute text files of your own. 

           // Example #1 
           // Read the file as one string. 
           // string text = System.IO.File.ReadAllText(DirPath);

           // Display the file contents to the console. Variable text is a string.
           //   System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

           // Example #2 
           // Read each line of the file into a string array. Each element 
           // of the array is one line of the file. 
           string[] lines = System.IO.File.ReadAllLines(DirPath);
       }

    }
}
