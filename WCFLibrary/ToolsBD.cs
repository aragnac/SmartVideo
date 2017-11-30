using BLL;
using FilmDTOLibrary;
using System.Collections.Generic;

namespace WCFLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ToolsBD : IToolsBD
    {
        DBFilm filmBLL = new DBFilm();


        public List<FilmDTO> GetFilms(string table, int start)
        {
            return filmBLL.GetFilms(table, start);
        }
    }
}
