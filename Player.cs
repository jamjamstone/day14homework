using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14homework
{
    class Player
    {
        public string _name;
        public int _hp;
        public int _dmg;
        struct Pos
        {
            public short _x;
            public short _y;
        }
        public Inventory _inventory;
        public void MakeInven()
        {
            _inventory = new Inventory();
            
        }
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
        public int Dmg
        {
            get;set;
        }
        public int HP
        {
            get;set;
        }


    }
}
