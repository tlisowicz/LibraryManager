using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LibraryManager.Database;

namespace FilterBooks
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IFilterBooksService
    {
        [OperationContract]
        List<int> FilterByCategories(List<string> categories);

        [OperationContract]
        List<int> FilterByPrice(double startRange, double endRange, string currency);

        [OperationContract]
        List<int> FilterByState(bool includeBorrowed);

        [OperationContract]
        List<int> FilterByAuthor(string author);
    }

}
