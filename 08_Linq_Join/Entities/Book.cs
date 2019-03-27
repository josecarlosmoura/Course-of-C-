using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Linq_Join.Entities
{
    class Book
    {
        public int Id { get; set; }
        public int IdAuthor { get; set; }
        public string Title { get; set; }
        public string YearOfPublication { get; set; }
    }
}
