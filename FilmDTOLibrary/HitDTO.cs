using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{
    class HitDTO
    {
        private string _idType;
        private string _typeData;
        private string _date;
        private int _hit;


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
            get{return _typeData; }
            set{ _typeData = value;}
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Hit
        {
            get { return _hit; }
            set { _hit = value; }
        }

        public HitDTO(string idType, string typeData, string date, int hit)
        {
            IdType = idType;
            TypeData = typeData;
            Date = date;
            Hit = hit;
        }

        public HitDTO()
        {
        }
    }
}
