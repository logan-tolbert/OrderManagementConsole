using Bogus;
using OrderManagementConsole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementConsole.Data;

public class CustomerData
{
    public List<Customer> Customers = new List<Customer>
    { 
            new ( 0, "Sonny", "Hammes", "Sonny97@gmail.com", new DateTime(1993, 4, 23, 4, 12, 20) ),
            new ( 1, "Clementine", "Boehm", "Clementine_Boehm@gmail.com", new DateTime(1995, 9, 16, 16, 26, 13) ),
            new ( 2, "Jacquelyn", "Pfannerstill", "Jacquelyn.Pfannerstill22@gmail.com", new DateTime(2000, 9, 11, 1, 59, 7) ),
            new ( 3, "Reagan", "Auer", "Reagan15@yahoo.com", new DateTime(2006, 3, 30, 7, 13, 10) ),
            new ( 4, "Kadin", "Zieme", "Kadin.Zieme80@gmail.com", new DateTime(1995, 6, 11, 5, 32, 59) ),
            new ( 5, "Berniece", "Bayer", "Berniece_Bayer@yahoo.com", new DateTime(2007, 7, 28, 22, 31, 43) ),
            new ( 6, "Kurt", "Deckow", "Kurt_Deckow@hotmail.com", new DateTime(1975, 12, 27, 14, 14, 18) ),
            new ( 7, "Lavern", "Lehner", "Lavern96@gmail.com", new DateTime(1974, 2, 7, 23, 26, 11) ),
            new ( 8, "Mateo", "Lubowitz", "Mateo13@gmail.com", new DateTime(1976, 7, 27, 7, 42, 10) ),
            new ( 9, "Bria", "Dietrich", "Bria.Dietrich6@hotmail.com", new DateTime(1986, 10, 25, 17, 10, 28) ),
            new ( 10, "Colin", "Rolfson", "Colin.Rolfson65@hotmail.com", new DateTime(1957, 10, 7, 21, 45, 55) ),
            new ( 11, "Eliseo", "Schulist", "Eliseo_Schulist@gmail.com", new DateTime(1983, 5, 16, 15, 12, 27) ),
            new ( 12, "Anita", "Weissnat", "Anita.Weissnat58@hotmail.com", new DateTime(1960, 11, 27, 12, 39, 5) ),
            new ( 13, "Elisabeth", "Reinger", "Elisabeth.Reinger96@hotmail.com", new DateTime(1990, 2, 19, 11, 27, 7) ),
            new ( 14, "Sydney", "Beier", "Sydney1@gmail.com", new DateTime(1965, 4, 21, 21, 10, 52) ),
            new ( 15, "Lurline", "Wunsch", "Lurline_Wunsch16@gmail.com", new DateTime(2004, 6, 18, 11, 53, 51) ),
            new ( 16, "Percy", "O'Keefe", "Percy65@gmail.com", new DateTime(1961, 9, 28, 22, 0, 38) ),
            new ( 17, "Dimitri", "Mills", "Dimitri28@yahoo.com", new DateTime(1965, 9, 22, 15, 30, 9) ),
            new ( 18, "Annamae", "Howell", "Annamae_Howell51@yahoo.com", new DateTime(1981, 5, 12, 15, 1, 28) ),
            new ( 19, "Alessia", "Quigley", "Alessia_Quigley@yahoo.com", new DateTime(1995, 4, 16, 1, 42, 35) )
        };
}
