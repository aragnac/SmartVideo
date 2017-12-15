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
        private DBSmartVideo _bdSmartVideo;

        public SMUpdateService()
        {
            InitializeComponent();
            _bdSmartVideo = DBSmartVideo.Singleton();
            /*if (!EventLog.SourceExists("SmartVideoStat"))
            {
                EventLog.CreateEventSource(
                    "SmartVideoStat", "SmartVideoLog");
            }
            EventLog.Source = "SmartVideoStat";
            EventLog.Log = "SmartVideoLog";

            _eventId = 0;*/
        }

        protected override void OnStart(string[] args)
        {
            //EventLog.WriteEntry("In OnStart!", EventLogEntryType.Information);
            EventLog.WriteEntry("SmartVideoStatService", "In OnStart!", EventLogEntryType.Information);
            var timer = new Timer { Interval = 10000 };
            // 10 seconds
            timer.Elapsed += OnTimer;
            timer.Start();
            EventLog.WriteEntry("SmartVideoStatService", "Timer started", EventLogEntryType.Information);
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            EventLog.WriteEntry("SmartVideoStatService", "In OnTimer!", EventLogEntryType.Information);

            List<HitDTO> listHit = _bdSmartVideo.GetHits();
            int posActor = 0;
            int posFilm = 0;

            foreach (HitDTO hit in listHit)
            {
                if (hit.TypeData.Equals("Actor") && posActor < 3)
                {
                    posActor++;
                    _bdSmartVideo.AddStatistiques(new StatistiquesDTO(hit.IdType.ToString(), hit.TypeData, DateTime.Now, posActor));
                }
                else
                {
                    if (posFilm < 3)
                    {
                        posFilm++;
                        _bdSmartVideo.AddStatistiques(new StatistiquesDTO(hit.IdType.ToString(), hit.TypeData, DateTime.Now, posFilm));
                    }
                }   

            }
            EventLog.WriteEntry("SmartVideoStatService", "Statistiques mis à jour.", EventLogEntryType.Information);

        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("SmartVideoStatService", "SmartVideo stat service stopped!", EventLogEntryType.Information);
        }
    }
}
