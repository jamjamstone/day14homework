using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day14homework
{
    class Inventory
    {
        public Item[] items;
        
        
        public Item[] CreateInvenBySize(int size)
        {
            
            Item[] items = new Item[size];
            for(int i = 0; i < size; i++)
            {
                items[i] = new Item();//c++처럼 객체 배열을 생성하면 각 배열의 들어가는 클래스를 다시 별도 할당 해야함
            }
            return items;
        }
        public bool isInvenCreated(Item[] items)
        {
            if (items == null || items.Length < 0) { 
                return false;
            }
            else
            {
                return true;
            }
        }

        public Item GetItemByIndex(int index)
        {
            if (items[index]==null) {
                Console.WriteLine("아이템이 비어있음");
                return null;
            }
            else
            {
                return items[index];
            }
        }
        public void SetItemByIndex(int index, Item item)
        {
            items[index]._price = item._price;
            items[index]._name = item._name;
            items[index]._itemType = item._itemType;
        }

    }
    
}
