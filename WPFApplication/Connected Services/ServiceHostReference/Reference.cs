﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFApplication.ServiceHostReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHostReference.IToolsBD")]
    public interface IToolsBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        FilmDTOLibrary.FilmDTO[] GetFilms(string table, int start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetFilmsAsync(string table, int start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchMovies", ReplyAction="http://tempuri.org/IToolsBD/SearchMoviesResponse")]
        FilmDTOLibrary.FilmDTO[] SearchMovies(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchMovies", ReplyAction="http://tempuri.org/IToolsBD/SearchMoviesResponse")]
        System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> SearchMoviesAsync(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetMoviesByActor", ReplyAction="http://tempuri.org/IToolsBD/GetMoviesByActorResponse")]
        FilmDTOLibrary.FilmDTO[] GetMoviesByActor(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetMoviesByActor", ReplyAction="http://tempuri.org/IToolsBD/GetMoviesByActorResponse")]
        System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetMoviesByActorAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchActors", ReplyAction="http://tempuri.org/IToolsBD/SearchActorsResponse")]
        FilmDTOLibrary.ActeurDTO[] SearchActors(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchActors", ReplyAction="http://tempuri.org/IToolsBD/SearchActorsResponse")]
        System.Threading.Tasks.Task<FilmDTOLibrary.ActeurDTO[]> SearchActorsAsync(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilmById", ReplyAction="http://tempuri.org/IToolsBD/GetFilmByIdResponse")]
        FilmDTOLibrary.FilmDTO[] GetFilmById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilmById", ReplyAction="http://tempuri.org/IToolsBD/GetFilmByIdResponse")]
        System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetFilmByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/InsertTrailer", ReplyAction="http://tempuri.org/IToolsBD/InsertTrailerResponse")]
        bool InsertTrailer(string trailer, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/InsertTrailer", ReplyAction="http://tempuri.org/IToolsBD/InsertTrailerResponse")]
        System.Threading.Tasks.Task<bool> InsertTrailerAsync(string trailer, int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToolsBDChannel : WPFApplication.ServiceHostReference.IToolsBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToolsBDClient : System.ServiceModel.ClientBase<WPFApplication.ServiceHostReference.IToolsBD>, WPFApplication.ServiceHostReference.IToolsBD {
        
        public ToolsBDClient() {
        }
        
        public ToolsBDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToolsBDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToolsBDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToolsBDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FilmDTOLibrary.FilmDTO[] GetFilms(string table, int start) {
            return base.Channel.GetFilms(table, start);
        }
        
        public System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetFilmsAsync(string table, int start) {
            return base.Channel.GetFilmsAsync(table, start);
        }
        
        public FilmDTOLibrary.FilmDTO[] SearchMovies(string table, string search) {
            return base.Channel.SearchMovies(table, search);
        }
        
        public System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> SearchMoviesAsync(string table, string search) {
            return base.Channel.SearchMoviesAsync(table, search);
        }
        
        public FilmDTOLibrary.FilmDTO[] GetMoviesByActor(string id) {
            return base.Channel.GetMoviesByActor(id);
        }
        
        public System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetMoviesByActorAsync(string id) {
            return base.Channel.GetMoviesByActorAsync(id);
        }
        
        public FilmDTOLibrary.ActeurDTO[] SearchActors(string table, string search) {
            return base.Channel.SearchActors(table, search);
        }
        
        public System.Threading.Tasks.Task<FilmDTOLibrary.ActeurDTO[]> SearchActorsAsync(string table, string search) {
            return base.Channel.SearchActorsAsync(table, search);
        }
        
        public FilmDTOLibrary.FilmDTO[] GetFilmById(int id) {
            return base.Channel.GetFilmById(id);
        }
        
        public System.Threading.Tasks.Task<FilmDTOLibrary.FilmDTO[]> GetFilmByIdAsync(int id) {
            return base.Channel.GetFilmByIdAsync(id);
        }
        
        public bool InsertTrailer(string trailer, int id) {
            return base.Channel.InsertTrailer(trailer, id);
        }
        
        public System.Threading.Tasks.Task<bool> InsertTrailerAsync(string trailer, int id) {
            return base.Channel.InsertTrailerAsync(trailer, id);
        }
    }
}
