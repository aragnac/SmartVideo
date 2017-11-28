using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.ServiceProcess;

namespace WinService1
{
    [RunInstaller(true)]
    public partial class Service1Install : Installer
    {
        private ServiceInstaller serviceInstaller;
        private ServiceProcessInstaller processInstaller;

        public Service1Install() : base()
        {

            processInstaller = new ServiceProcessInstaller();
            serviceInstaller = new ServiceInstaller();

            // Service will run under system account
            processInstaller.Account = ServiceAccount.LocalSystem;

            // Service will have Start Type of Manual
            serviceInstaller.StartType = ServiceStartMode.Manual;

            serviceInstaller.ServiceName = "WinSer1HostWCF";

            Installers.Add(serviceInstaller);
            Installers.Add(processInstaller);

        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            EventLog.WriteEntry("WinSer1HostWCF", "Installation de mon service", EventLogEntryType.Information);
        }

        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            base.Uninstall(savedState);
            EventLog.WriteEntry("WinSer1HostWCF", "Désinstallation de mon service", EventLogEntryType.Information);
        }


    }
}
