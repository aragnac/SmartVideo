using FilmDTOLibrary;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IToolsBD
    {

        [OperationContract]
        List<FilmDTO> GetFilms(string table, int start);


        // TODO: ajoutez vos opérations de service ici
    }
}
