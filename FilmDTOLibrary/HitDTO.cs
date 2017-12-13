using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{
    public class HitDTO
    {
        private int _idType;
        private string _typeData;
        private DateTime _date;
        private int _hit;


        public int IdType
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
            get{return _typeData; }
            set{ _typeData = value;}
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Hits
        {
            get { return _hit; }
            set { _hit = value; }
        }

        public HitDTO(int idType, string typeData, DateTime date, int hit)
        {
            IdType = idType;
            TypeData = typeData;
            Date = date;
            Hits = hit;
        }

        public HitDTO()
        {
        }
    }
}
