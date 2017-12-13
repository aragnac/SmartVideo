using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IToolsBD
    {

        [OperationContract]
        List<FilmDTO> GetFilms(string table, int start);

        [OperationContract]
        List<FilmDTO> SearchMovies(string table, string search);

        [OperationContract]
        List<FilmDTO> GetMoviesByActor(string id);

        [OperationContract]
        List<ActeurDTO> SearchActors(string table, string search);

        [OperationContract]
        List<FilmDTO> GetFilmById(int id);
    }
}
