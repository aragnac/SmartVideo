using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{

    public class FilmDTO
    {
        // <copyright file="FilmDTO" company="Haute Ecole de la Province de Liège">
            // Copyright (c) 2016 All Rights Reserved
            // <author>Cécile Moitroux</author>
            // </copyright>
        private List<GenreDTO> genrelist;
        private List<RealisateurDTO> realisateurlist;
        private List<ActeurDTO> acteurlist;

        private int id;
        private string title;
        private string original_title;
        private int runtime;
        private string posterpath;
        private string trailerpath;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Original_title
        {
            get
            {
                return original_title;
            }

            set
            {
                original_title = value;
            }
        }

        public int Runtime
        {
            get
            {
                return runtime;
            }

            set
            {
                runtime = value;
            }
        }

        public string Posterpath
        {
            get
            {
                return posterpath;
            }

            set
            {
                posterpath = value;
            }
        }

        public string Trailerpath
        {
            get
            {
                return trailerpath;
            }

            set
            {
                trailerpath = value;
            }
        }

        public List<GenreDTO> Genrelist
        {
            get
            {
                return genrelist;
            }

            set
            {
                genrelist = value;
            }
        }

        public List<RealisateurDTO> Realisateurlist
        {
            get
            {
                return realisateurlist;
            }

            set
            {
                realisateurlist = value;
            }
        }

        public List<ActeurDTO> Acteurlist
        {
            get
            {
                return acteurlist;
            }

            set
            {
                acteurlist = value;
            }
        }

        // Préparation de la classe pour recevoir les données
        public FilmDTO()
        {
            Genrelist = new List<GenreDTO>();
            Realisateurlist = new List<RealisateurDTO>();
            Acteurlist = new List<ActeurDTO>();
        }
    }

}
