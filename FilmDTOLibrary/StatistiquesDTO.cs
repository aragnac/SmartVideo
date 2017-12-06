using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{
    class StatistiquesDTO
    {
        private string _idType;
        private string _typeData;
        private string _dateStat;
        private int _position;


        public string IdType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType = value;
            }
        }

        public string TypeData
        {
            get { return _typeData; }
            set { _typeData = value; }
        }

        public string DateStat
        {
            get { return _dateStat; }
            set { _dateStat = value; }
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public StatistiquesDTO(string idType, string typeData, string datestat, int pos)
        {
            IdType = idType;
            TypeData = typeData;
            DateStat = datestat;
            Position = pos;
        }

        public StatistiquesDTO()
        {
        }
    }
}
