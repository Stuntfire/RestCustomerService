using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestCustomerService
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Customer(int id, string first, string last, int year)
        {
            this.Id = id;
            this.FirstName = first;
            this.LastName = last;
            this.Year = year;
        }

        public Customer()
        {
            
        }
    }
}