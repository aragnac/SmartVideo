﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceHostReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHostReference.IToolsBD")]
    public interface IToolsBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> GetFilms(string table, int start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> GetFilmsAsync(string table, int start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchMovies", ReplyAction="http://tempuri.org/IToolsBD/SearchMoviesResponse")]
        System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> SearchMovies(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchMovies", ReplyAction="http://tempuri.org/IToolsBD/SearchMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> SearchMoviesAsync(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetMoviesByActor", ReplyAction="http://tempuri.org/IToolsBD/GetMoviesByActorResponse")]
        System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> GetMoviesByActor(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetMoviesByActor", ReplyAction="http://tempuri.org/IToolsBD/GetMoviesByActorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> GetMoviesByActorAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchActors", ReplyAction="http://tempuri.org/IToolsBD/SearchActorsResponse")]
        System.Collections.Generic.List<FilmDTOLibrary.ActeurDTO> SearchActors(string table, string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/SearchActors", ReplyAction="http://tempuri.org/IToolsBD/SearchActorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.ActeurDTO>> SearchActorsAsync(string table, string search);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToolsBDChannel : WebApplication.ServiceHostReference.IToolsBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToolsBDClient : System.ServiceModel.ClientBase<WebApplication.ServiceHostReference.IToolsBD>, WebApplication.ServiceHostReference.IToolsBD {
        
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
        
        public System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> GetFilms(string table, int start) {
            return base.Channel.GetFilms(table, start);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> GetFilmsAsync(string table, int start) {
            return base.Channel.GetFilmsAsync(table, start);
        }
        
        public System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> SearchMovies(string table, string search) {
            return base.Channel.SearchMovies(table, search);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> SearchMoviesAsync(string table, string search) {
            return base.Channel.SearchMoviesAsync(table, search);
        }
        
        public System.Collections.Generic.List<FilmDTOLibrary.FilmDTO> GetMoviesByActor(string id) {
            return base.Channel.GetMoviesByActor(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.FilmDTO>> GetMoviesByActorAsync(string id) {
            return base.Channel.GetMoviesByActorAsync(id);
        }
        
        public System.Collections.Generic.List<FilmDTOLibrary.ActeurDTO> SearchActors(string table, string search) {
            return base.Channel.SearchActors(table, search);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<FilmDTOLibrary.ActeurDTO>> SearchActorsAsync(string table, string search) {
            return base.Channel.SearchActorsAsync(table, search);
        }
    }
}
