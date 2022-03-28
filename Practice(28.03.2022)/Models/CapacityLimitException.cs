using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_28._03._2022_.Models
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
            //Console.WriteLine("Isci sayi 50 neferden cox ola bilmez");
        }
    }
}
