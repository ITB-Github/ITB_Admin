using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AdminView
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            //app.Run(new PointControl.PointControlView());

            ServiceBuilder service = new ServiceBuilder();

            PointControlRunner pointControlrunner = new PointControlRunner();
            pointControlrunner.AttachService(service);

            app.Run(pointControlrunner.Run());

        }
    }
}
