﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} , {Title} , {Author} , {Price}";
        }
    }
}
