using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgarveBeach
{
    class Ficheiros
    {
        string fileLoc = @"c:\sample1.txt";

        // Criar um ficheiro de texto
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            if (!File.Exists(fileLoc))
            {
                using (fs = File.Create(fileLoc))
                {

                }
            }
        }


        // Escrever num ficheiro de texto
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileLoc))
            {
                using (StreamWriter sw = new StreamWriter(fileLoc))
                {
                    sw.Write("Some sample text for the file");
                }
            }
        }


        // Ler um ficheiro de texto
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(fileLoc))
            {
                using (System.IO.TextReader tr = new System.IO.StreamReader(fileLoc))
                {
                    System.Windows.Forms.MessageBox.Show(tr.ReadLine());
                }
            }
        }


        // Copiar um ficheiro de texto
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string fileLocCopy = @"d:\sample1.txt";
            if (File.Exists(fileLoc))
            {
                // If file already exists in destination, delete it.
                if (File.Exists(fileLocCopy))
                    File.Delete(fileLocCopy);
                File.Copy(fileLoc, fileLocCopy);
            }
        }

        // Mover um ficheiro de texto
        private void btnMove_Click(object sender, EventArgs e)
        {
            // Create unique file name
            string fileLocMove = @"d:\sample1" + System.DateTime.Now.Ticks + ".txt";
            if (File.Exists(fileLoc))
            {
                File.Move(fileLoc, fileLocMove);
            }
        }

        // Apagar um ficheirode texto
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileLoc))
            {
                File.Delete(fileLoc);
            }
        }


    }
}
