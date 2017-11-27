using WCFLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinService1
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost service1Host = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (service1Host != null)
            {
                service1Host.Close();
            }

            service1Host = new ServiceHost(typeof(ToolsBD), new Uri("http://localhost:8733/Design_Time_Addresses/SmartVideo/ToolsBD/"));
            service1Host.AddDefaultEndpoints();

            service1Host.Open();
        }

        protected override void OnStop()
        {
            if (service1Host != null)
            {
                service1Host.Close();
                service1Host = null;
            }
        }
    }
}
