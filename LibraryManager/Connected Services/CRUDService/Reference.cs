﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManager.CRUDService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRUDService.ICRUDService")]
    public interface ICRUDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/AddBook", ReplyAction="http://tempuri.org/ICRUDService/AddBookResponse")]
        bool AddBook(string author, string title, double price, string currency, int pages, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/AddBook", ReplyAction="http://tempuri.org/ICRUDService/AddBookResponse")]
        System.Threading.Tasks.Task<bool> AddBookAsync(string author, string title, double price, string currency, int pages, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/AddBooksFormJson", ReplyAction="http://tempuri.org/ICRUDService/AddBooksFormJsonResponse")]
        bool AddBooksFormJson(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/AddBooksFormJson", ReplyAction="http://tempuri.org/ICRUDService/AddBooksFormJsonResponse")]
        System.Threading.Tasks.Task<bool> AddBooksFormJsonAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/UpdateBook", ReplyAction="http://tempuri.org/ICRUDService/UpdateBookResponse")]
        bool UpdateBook(string title, string newTitle, string author, double price, string currency, int pages, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/UpdateBook", ReplyAction="http://tempuri.org/ICRUDService/UpdateBookResponse")]
        System.Threading.Tasks.Task<bool> UpdateBookAsync(string title, string newTitle, string author, double price, string currency, int pages, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/DeleteBook", ReplyAction="http://tempuri.org/ICRUDService/DeleteBookResponse")]
        bool DeleteBook(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDService/DeleteBook", ReplyAction="http://tempuri.org/ICRUDService/DeleteBookResponse")]
        System.Threading.Tasks.Task<bool> DeleteBookAsync(string title);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRUDServiceChannel : LibraryManager.CRUDService.ICRUDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRUDServiceClient : System.ServiceModel.ClientBase<LibraryManager.CRUDService.ICRUDService>, LibraryManager.CRUDService.ICRUDService {
        
        public CRUDServiceClient() {
        }
        
        public CRUDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRUDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddBook(string author, string title, double price, string currency, int pages, string category) {
            return base.Channel.AddBook(author, title, price, currency, pages, category);
        }
        
        public System.Threading.Tasks.Task<bool> AddBookAsync(string author, string title, double price, string currency, int pages, string category) {
            return base.Channel.AddBookAsync(author, title, price, currency, pages, category);
        }
        
        public bool AddBooksFormJson(string filePath) {
            return base.Channel.AddBooksFormJson(filePath);
        }
        
        public System.Threading.Tasks.Task<bool> AddBooksFormJsonAsync(string filePath) {
            return base.Channel.AddBooksFormJsonAsync(filePath);
        }
        
        public bool UpdateBook(string title, string newTitle, string author, double price, string currency, int pages, string category) {
            return base.Channel.UpdateBook(title, newTitle, author, price, currency, pages, category);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateBookAsync(string title, string newTitle, string author, double price, string currency, int pages, string category) {
            return base.Channel.UpdateBookAsync(title, newTitle, author, price, currency, pages, category);
        }
        
        public bool DeleteBook(string title) {
            return base.Channel.DeleteBook(title);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBookAsync(string title) {
            return base.Channel.DeleteBookAsync(title);
        }
    }
}