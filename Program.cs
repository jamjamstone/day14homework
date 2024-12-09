using System.Drawing;

namespace day14homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car = new Car();
            Monster monster = new Monster();
            monster.Atk = 20;
            monster.Hp = 2;
            car.CarHp = 100;
            monster.AttackCar(car);
            Console.WriteLine(car.CarHp); 
            */

            /*
            Item itemPrint = new Item();
            Item item = new Item();
            item._name = "발뭉";
            item._itemType = "무기";
            item._price = 156;
            
            Player player = new Player();
            player.MakeInven();
            player._inventory.items=player._inventory.CreateInvenBySize(6);
            if (player._inventory.isInvenCreated(player._inventory.items) == true)
            {
                Console.WriteLine("인벤토리 제작 완료");
            }
            else
            {
                Console.WriteLine("인벤토리 제작 실패");
            }
            player._inventory.SetItemByIndex(3, item);
            itemPrint = player.Inventory.GetItemByIndex(3);
            Console.WriteLine(itemPrint._name);
            Console.WriteLine(itemPrint._itemType);
            Console.WriteLine(itemPrint._price);
            */

            /*
            Inventory inventory = new Inventory();
            inventory.items=inventory.CreateInvenBySize(3);
            if (inventory.isInvenCreated(inventory.items) == true)
            {
                Console.WriteLine("인벤토리 제작 완료");
            }
            else
            {
                Console.WriteLine("인벤토리 제작 실패");
            }
            inventory.SetItemByIndex(1, item);
            itemPrint = inventory.GetItemByIndex(1);
            Console.WriteLine(itemPrint._name);
            Console.WriteLine(itemPrint._itemType);
            Console.WriteLine(itemPrint._price);


            */
            Player player = new Player();
            Monster monster = new Monster();
            monster.Atk = 10;
            monster.Hp = 100;
            player.HP = 200;
            player.Dmg = 20;
            while (true) { 
                monster.Hp-=player.Dmg;
                Console.WriteLine($"몬스터의 공격! {monster.Atk}데미지를 입었다!");
                Console.WriteLine($"플레이어의 체력이 {player.HP}남았다!");
                player.HP-=monster.Atk;
                Console.WriteLine($"플레이어의 공격! {player.Dmg}데미지를 입었다!");
                Console.WriteLine($"몬스터의 체력이 {monster.Hp}남았다!");
                if (monster.Hp <= 0 || player.HP <= 0)
                {
                    break;
                }



            }





        }
    }
}
