﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.BookService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/SimpleWF.Models")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibraryApp.BookService.BookStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((object.ReferenceEquals(this.BookIdField, value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibraryApp.BookService.BookStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookStatus", Namespace="http://schemas.datacontract.org/2004/07/SimpleWF.Models")]
    public enum BookStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        In = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Out = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookService.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        LibraryApp.BookService.Book GetBook(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        System.Threading.Tasks.Task<LibraryApp.BookService.Book> GetBookAsync(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetAllBooks", ReplyAction="http://tempuri.org/IBookService/GetAllBooksResponse")]
        LibraryApp.BookService.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetAllBooks", ReplyAction="http://tempuri.org/IBookService/GetAllBooksResponse")]
        System.Threading.Tasks.Task<LibraryApp.BookService.Book[]> GetAllBooksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : LibraryApp.BookService.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<LibraryApp.BookService.IBookService>, LibraryApp.BookService.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibraryApp.BookService.Book GetBook(string bookId) {
            return base.Channel.GetBook(bookId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.BookService.Book> GetBookAsync(string bookId) {
            return base.Channel.GetBookAsync(bookId);
        }
        
        public LibraryApp.BookService.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<LibraryApp.BookService.Book[]> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
    }
}
