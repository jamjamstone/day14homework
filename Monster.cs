using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14homework
{
    class Monster
    {
        public int _atk;
        public int _hp;
        struct Vector2
        {
            public int x;
            public int y;
        }
        public int Atk
        {
            get { return _atk; }
            set { if (value < 0) {
                    Console.WriteLine("음수로 세팅할 수 없습니다.");
                    _atk = 0;
                }
                else{ 
                    _atk = value;
                }
            }
        }
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("음수로 세팅할 수 없습니다.");
                    _hp = 0;
                }
                else
                {
                    _hp = value;
                    
                }
            }
        }
        public void AttackCar(Car car)
        {
            car.CarHp -= Atk;
            Console.WriteLine($"{Atk}만큼의 데미지를 {car.ShowCarName()}에 주었습니다.");
        }
    }
}
