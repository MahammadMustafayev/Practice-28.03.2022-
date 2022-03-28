using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_28._03._2022_.Models
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo(string Name, int Age)
        {
            return "";
        }
        
    }
}
