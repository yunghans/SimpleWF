using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SimpleWF.Models;

namespace SimpleWF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        Book GetBook(string bookId);

        [OperationContract]
        IEnumerable<Book> GetAllBooks();

    }
}
