using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Interface olduğunu anlamak için I ile başlanır
    // Interface Şablon Demek
    // Interface implementasyon denir 
    // Onu implemente eden classlar bunları barındırmak zorundadır
    // Interface'ler operasyonel methodlarda kullanılır genellikle.

    // Interfaceleri birbirin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    
    interface ICreditBaseManager
    {
        void Calculate();
        void DoSomething();
    }
}
