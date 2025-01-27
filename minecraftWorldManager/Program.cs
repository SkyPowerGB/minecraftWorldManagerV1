using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    internal static class Program
    {
        private static NotifyIcon trayIcon;
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();


       

            if (IsRunningAtStartup()) {

                trayIcon = new NotifyIcon()
                {
                    Icon = new Icon("mcWorldMngr.ico"), 
                    ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                    Visible = true,
                    Text = "McWorldBackuper" 
                };


            }

            AutoBackuper backuper = new AutoBackuper();

            var data = ProgDataFileMngr.GetProgramData();
            if (data != null)
            {
                if (data.quickBackupsPath != null && data.mcSavesPath != null)
                {
                    Console.WriteLine("run autobackups");
                    Task.Run(() => backuper.BackupAsync(data.quickBackupsPath, data.mcSavesPath));

                }
            }



            Application.SetCompatibleTextRenderingDefault(false);

          
           

            Application.Run(new MCworldMngr());
       

        }

        private static void Exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false; 
            Application.Exit(); 
        }
        private static bool IsRunningAtStartup()
        {

            return Environment.GetCommandLineArgs().Length > 1 &&
                   Environment.GetCommandLineArgs()[1] == "autostart";
        }

    }
}
