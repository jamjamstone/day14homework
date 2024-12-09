using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14homework
{
    class Car
    {
        private string _carName = "bughati";
        
        private int _carNum=5423;
        public int CarHp
        {
            get; set;
        }
        public string ShowCarName()
        {
            return _carName;
        }
    }
}
