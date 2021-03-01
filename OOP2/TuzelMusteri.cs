using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorporate    Tüzelin ingilizcesi

    //Tüzel Müşteri aslında bir müşteridir.

    // Inheritance veya extends TuzelMusteri
    class TuzelMusteri : Customer
    {
        
        public string CompanyName { get; set; }

        public string VergiNo { get; set; }
    }
}
