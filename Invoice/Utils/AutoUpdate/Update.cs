using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Security.Permissions;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Faktury.Utils.AutoUpdate
{
    public static class Update
    {
        //https://docs.google.com/uc?export=download&id=0B4y6Z4XdBg4AcEJjenZsbV9zSlk

        public static void Download()
        {
            //WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            //bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            //if (!hasAdministrativeRight)
            //{
            //    // relaunch the application with admin rights
            //    string fileName = Assembly.GetExecutingAssembly().Location;
            //    ProcessStartInfo processInfo = new ProcessStartInfo();
            //    processInfo.Verb = "runas";
            //    processInfo.FileName = fileName;

            //    try
            //    {
            //        Process.Start(processInfo);
            //        Process.GetCurrentProcess().Kill();
            //    }
            //    catch (Win32Exception)
            //    {
            //        MessageBox.Show("Aplikacja nie może zostać zakutalizowana!");
            //    }

            //}
            //else
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(new Uri("https://docs.google.com/uc?export=download&id=0B4y6Z4XdBg4AcEJjenZsbV9zSlk"), "invoice_update.temp.exe");
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                try
                {
                    File.Delete(@"Updater.bat");

                    var f = new StreamWriter(@"Updater.bat");
                    f.WriteLine("@echo off");
                    f.WriteLine("%0\\ ");
                    f.WriteLine("cd %0\\..");
                    f.WriteLine("cd /d %0\\.. ");
                    f.WriteLine("timeout 1");
                    f.WriteLine("if exist invoice_update.temp.exe del " + System.AppDomain.CurrentDomain.FriendlyName);
                    f.WriteLine("if not exist Faktury.exe ren invoice_update.temp.exe " + System.AppDomain.CurrentDomain.FriendlyName);
                    f.WriteLine("start " + System.AppDomain.CurrentDomain.FriendlyName);
                    f.Close();

                    ProcessStartInfo procInfo = new ProcessStartInfo();
                    procInfo.UseShellExecute = true;
                    procInfo.FileName = @"Updater.bat";  //The file in that DIR.
                    procInfo.WorkingDirectory = @""; //The working DIR.
                    Process.Start(procInfo);  //Start that process.
                    Process.GetCurrentProcess().Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

    }
}
