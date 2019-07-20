using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// ctlr 

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Copy
        private void button11_Click(object sender, EventArgs e)
        {
            var fileToCopy = "C:\\Users\\deleo\\Desktop\\Dele Isaac Oyinsan..docx";
            var newLocation = "C:\\Users\\deleo\\Desktop\\new\\Dele Isaac Oyinsan..docx";
            var findDirectory = "C:\\Users\\deleo\\Desktop";

            if (Directory.Exists(findDirectory))
            {
                if (File.Exists(fileToCopy))
                {
                    File.Copy(fileToCopy, newLocation, true);
                    MessageBox.Show("File has been copied!");
                }
                else
                {
                    MessageBox.Show("Please find the correct file");
                }
            }
            else
            {

                MessageBox.Show("Not available");
            }
        }
        //Delete
        private void button12_Click(object sender, EventArgs e)
        {
            var DoNotExist = "C:\\Users\\deleo\\Desktop\\new\\Dele Isaac Oyinsan..docx";

            File.Delete(DoNotExist);
            MessageBox.Show("File Gone");
        }
        //Move 
        private void button13_Click(object sender, EventArgs e)
        {
            var FileLoc = "C:\\Users\\deleo\\Desktop\\Dele Isaac Oyinsan..docx";
            var WhereFile = "C:\\Users\\deleo\\Desktop\\new\\Dele Isaac Oyinsan..docx";
            if (File.Exists(FileLoc))
            {
                File.Move(FileLoc, WhereFile);
                //Directory.Move("C:\\Users\\deleo\\Desktop\\Dele Isaac Oyinsan.", "C:\\Users\\deleo\\Desktop\\new");
                MessageBox.Show("Yaay! it work");
            }
            else
                MessageBox.Show("Sorry, this file doesn't Exsit :(!");
        }
        // Move there and back
        private void button14_Click(object sender, EventArgs e)
        {
            var MoveBack = "C:\\Users\\deleo\\Desktop\\new\\Dele Isaac Oyinsan..docx";
            var backMove = "C:\\Users\\deleo\\Desktop\\Dele Isaac Oyinsan..docx";

            if (File.Exists(MoveBack))
            {
                File.Move(MoveBack, backMove);
                MessageBox.Show("Back to where you came from!");
            }

            else
            {
                MessageBox.Show("I wasn't here :(");
            }

        }














        //Move mulitple file 
        private void Dropfile(object sender, DragEventArgs e)
        {
            var Newfile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var Newfiles in Newfile)
                textBox5.Text = Newfiles;
        }

        private void Openfile(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private void DropFiles2(object sender, DragEventArgs e)
        {
            var Newfile2 = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var Newfiles2 in Newfile2)
                textBox6.Text = Newfiles2;


        }

        private void OpenFiles2(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var CreateFile = Directory.Exists("C:\\Users\\deleo\\Desktop\\NewFolder");
            // var Createfile = Directory.SetAccessControl("C:\\Users\\deleo\\Desktop\\NewFolder";)

            //  //this is a loop i created, hoping I can make it create more than one file 
            //for (int i = Createfile, i < 1, i++)
            // {
            //     messagebox.show("it making more!")
            //  }
            try
            {
            if (CreateFile)
                MessageBox.Show("It already exsit");
            else if (!CreateFile)
            {
                Directory.CreateDirectory("C:\\Users\\deleo\\Desktop\\NewFolder");
                MessageBox.Show("this has been Created! :)");
            }
          
                string filelocation = textBox5.Text;
                string[] Filebutton = Directory.GetFiles(filelocation);
                string Movinglocation = textBox6.Text;

                foreach (var file in Filebutton)
                {
                    var NameFile = Path.GetFileName(file);
                    File.Copy(file, Movinglocation + "\\" + NameFile, true);
                    // File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var CreateFile = Directory.Exists("C:\\Users\\deleo\\Desktop\\NewFolder");
            //  //this is a loop i created, hoping I can make it create more than one file 
            //  for (int i = CreateFile, i < 17, i++)
            //    {
            //      MessageBox.Show("it making more!")
            //    }

            if (CreateFile)
                MessageBox.Show("It already exsit");
            else if (!CreateFile)
            { 
                Directory.CreateDirectory("C:\\Users\\deleo\\Desktop\\NewFolder");

                MessageBox.Show("this has been Created! bdecause Mary Anne bullied me! :D, Hope everyone had a Dounut!");
            }
            
                try
                {
                     MessageBox.Show("It already There, I told you!");
                    var filelocation = textBox5.Text;
                    var Filebutton = Directory.GetFiles(filelocation);
                    var CheckCreatedtime = Directory.GetCreationTime("C:\\Users\\deleo\\Desktop\\Docx");
                    var Movinglocation = textBox6.Text;

                    foreach (var file in Filebutton)
                    {
                        var NameFile = Path.GetFileName(file);
                        File.Copy(file, Movinglocation + "\\" + NameFile, true);
                        File.Delete(file);
                        //File.Move()
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\deleo\\Desktop\\NewFolder");
            MessageBox.Show("It has Gone");
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }


    //private void button10_Click(object sender, EventArgs e)
    //{

    //    //try
    //    //{

    //    //    var filelocation = textBox1.Text;
    //    //    var Filebutton = Directory.GetFiles(filelocation);
    //    //    var Movinglocation = textBox2.Text;

    //    //    foreach (var file in Filebutton)
    //    //    {
    //    //        var NameFile = Path.GetFileName(file);
    //    //        File.Copy(file, Movinglocation + "\\" + NameFile, true);
    //    //        // File.Delete(file);
    //    //    }
    //    //}
    //    //catch (Exception ex)
    //    //{
    //    //    MessageBox.Show(ex.ToString());
    //    //}
    //}


}

//}









//private void textBox1_TextChanged(object sender, DragEventArgs e)
//{
//    var CopyFile = (string[])e.Data.GetData(DataFormats.FileDrop, false); 
//    foreach(var newFile in CopyFile)
//    {
//        textBox1.Text = newFile;
//    }
//}

//    }
//}

