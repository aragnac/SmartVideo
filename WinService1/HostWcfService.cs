using WCFLibrary;
using System;
using System.ServiceModel;
using System.ServiceProcess;


namespace WinService1
{
    public partial class HostWcfService : ServiceBase
    {
        ServiceHost service1Host = null;

        public HostWcfService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (service1Host != null)
            {
                service1Host.Close();
            }

            service1Host = new ServiceHost(typeof(ToolsBD), new Uri("http://localhost:8733/Design_Time_Addresses/WCFLibrary/ToolsBD/"));
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
