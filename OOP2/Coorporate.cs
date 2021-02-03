using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel müşteri
    // Miras- Inheritance
    //Customer'da olan her şey Coorporate'de de vardır.
    class Coorporate:Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }

    }
}
