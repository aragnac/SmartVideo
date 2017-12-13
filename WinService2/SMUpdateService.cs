using DAL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinService2
{
    public partial class SMUpdateService : ServiceBase
    {
        private int _eventId;
        private DBSmartVideo _bdSmartVideo;

        public SMUpdateService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("SmartVideoStat"))
            {
                EventLog.CreateEventSource(
                    "SmartVideoStat", "SmartVideoLog");
            }
            EventLog.Source = "SmartVideoStat";
            EventLog.Log = "SmartVideoLog";

            _eventId = 0;
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("In OnStart!", EventLogEntryType.Information);
            var timer = new Timer { Interval = 10000 };
            // 10 seconds
            timer.Elapsed += OnTimer;
            timer.Start();
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            List<HitDTO> listHit = _bdSmartVideo.GetHits();
            int pos = 0;

            foreach(HitDTO hit in listHit)
            {
                if (pos < 3)
                {
                    StatistiquesDTO stat = new StatistiquesDTO(hit.IdType.ToString(), hit.TypeData, DateTime.Now, pos);
                    pos++;
                }
                else
                    break;
            }
            EventLog.WriteEntry("Statistiques mis à jour.", EventLogEntryType.Information);

        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("SmartVideo stat service stopped!", EventLogEntryType.Information);
        }
    }
}
