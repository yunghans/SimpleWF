using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWF.Models
{
    public enum BookStatus
    {
        In,
        Out
    }

    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public BookStatus Status { get; set; }

    }
}