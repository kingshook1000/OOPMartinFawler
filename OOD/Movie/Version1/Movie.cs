using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Version1
{
    class Movie
    {
        public static readonly int CHILDRENS = 2;
        public static readonly int REGULAR = 0; 
        public static readonly int NEW_RELEASE = 1;

        private string _title;
        private int _priceCode;

        public Movie(string title, int priceCode)
        { 
            _title = title;
            _priceCode = priceCode;
        }

        public int getPriceCode() { return _priceCode; }
        public void setPriceCode(int arg) { _priceCode = arg; }

        public String getTitle() { return _title; }

    }
}
