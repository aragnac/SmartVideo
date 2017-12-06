using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{
    class LocationDTO
    {
        private string _idFilm;
        private string _username;
        private string _dateDebut;
        private string _dateFin;


        public string IdFilm
        {
            get
            {
                return _idFilm;
            }

            set
            {
                _idFilm = value;
            }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }

        public string DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public LocationDTO(string idFilm, string user, string dated, string datef)
        {
            IdFilm = idFilm;
            Username = user;
            DateDebut = dated;
            DateFin = datef;
        }

        public LocationDTO()
        {
        }
    }
}
