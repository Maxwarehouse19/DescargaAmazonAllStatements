using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace UpsSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    // crea carpeta con archivos de descargas
            //    // --------------------------------------
            //    string destFile = ConfigurationManager.AppSettings["RutaDescarga"];
            //    destFile = destFile + "ArchivosAnteriores" + DateTime.Now.ToString("yyyyMMdd");
            //
            //    // si no existe crea el directorio
            //    // -------------------------------
            //    if (!System.IO.Directory.Exists(destFile))
            //    {
            //        System.IO.Directory.CreateDirectory(destFile);
            //    }
            //
            //    // Realiza Movimiento de archivos existentes para poder tener la carpeta solo con los archivos descargados
            //    // -------------------------------------------------------------------------------------------------------
            //    string sourcePath = ConfigurationManager.AppSettings["RutaDescarga"];
            //
            //    if (System.IO.Directory.Exists(sourcePath))
            //    {
            //        string[] files = System.IO.Directory.GetFiles(sourcePath);
            //
            //        // Copy the files and overwrite destination files if they already exist. 
            //        foreach (string s in files)
            //        {
            //            // Use static Path methods to extract only the file name from the path.
            //            string fileName = System.IO.Path.GetFullPath(s);
            //            string DestinoFile = destFile + "\\" + System.IO.Path.GetFileName(s);
            //            System.IO.File.Move(fileName, DestinoFile);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR no existe ruta de archivos!");
            //    }
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("ERROR");
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                // Realiza descarga de archivos
                // ----------------------------
                DescargaamazonTest AmazonObj = new DescargaamazonTest();

                AmazonObj.SetUp();
                AmazonObj.descargaamazon();

            }
            catch (SystemException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }

            string EsperaMoverMili = ConfigurationManager.AppSettings["EsperaMover"];

            int EsperaMilisegundos = Convert.ToInt32(EsperaMoverMili);

            //System.Threading.Thread.Sleep(EsperaMilisegundos);

            //try
            //{
            //    // mueve los archivos descargados
            //    // ------------------------------
            //    string destFile = ConfigurationManager.AppSettings["RutaDescarga"];
            //    destFile = ConfigurationManager.AppSettings["RutaProceso"]; ;
            //
            //    // Realiza Movimiento de archivos existentes para poder tener la carpeta solo con los archivos descargados
            //    // -------------------------------------------------------------------------------------------------------
            //    string sourcePath = ConfigurationManager.AppSettings["RutaDescarga"];
            //
            //    if (System.IO.Directory.Exists(sourcePath))
            //    {
            //        string[] files = System.IO.Directory.GetFiles(sourcePath);
            //
            //        try
            //        {
            //            int Conteo = 0;
            //
            //            // Copy the files and overwrite destination files if they already exist. 
            //            foreach (string s in files)
            //            {
            //                
            //                try
            //                {
            //                    // Use static Path methods to extract only the file name from the path.
            //                    string fileName = System.IO.Path.GetFullPath(s);
            //                    string DestinoFile = destFile + "\\" + "amazon_" + DateTime.Now.ToString("yyyyMMddTHHmmss")+ Conteo + ".csv";
            //                    System.IO.File.Move(fileName, DestinoFile);
            //                }
            //                catch (SystemException e)
            //                {
            //                    Console.WriteLine("ERROR");
            //                    Console.WriteLine(e.Message);
            //                }
            //
            //                Conteo = Conteo + 1;
            //            }
            //        }
            //        catch (SystemException e)
            //        {
            //            Console.WriteLine("ERROR");
            //            Console.WriteLine(e.Message);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR no existe ruta de archivos!");
            //    }
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("ERROR");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
