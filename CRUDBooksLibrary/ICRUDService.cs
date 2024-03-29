﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUDBooksLibrary
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface ICRUDService
    {
        [OperationContract]
        bool AddBook(string author, string title, double price, string currency, int pages, string category);

        [OperationContract]
        bool AddBooksFormJson(string filePath);

        [OperationContract]
        bool UpdateBook(string title, string newTitle, string author, double price, string currency, int pages, string category);

        [OperationContract]
        bool DeleteBook(string title);

        [OperationContract]
        bool AddBookToBorrowed(string user, string book);

        [OperationContract]
        bool DeleteBookFromBorrowed(string user, string book);

        [OperationContract]
        string GenerateSHA256Hash(string input);

        [OperationContract]
        bool AddUser(string userName, string password);

        // TODO: dodaj tutaj operacje usługi
    }
}
