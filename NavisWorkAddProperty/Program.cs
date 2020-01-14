using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Navisworks.Api.Controls;
using Autodesk.Navisworks.Api.Resolver;
namespace NavisWorkAddProperty
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String runtimeName = Resolver.TryBindToRuntime(RuntimeNames.Any);
            //Set to single document mode
            ApplicationControl.ApplicationType = ApplicationType.SingleDocument;

            //Initialise the api
            ApplicationControl.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Create Temp Folder for every user to use Npcc3i Files 
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmNavisWorkAddProp());
            //Dispose of the DocumentControl
            //documentControl.Dispose();
            ApplicationControl.Terminate();
        }
    }
}
