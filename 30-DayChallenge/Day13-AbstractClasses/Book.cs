﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_AbstractClasses
{
    public abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
}
