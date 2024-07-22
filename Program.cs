using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 김의성_플밍1기__객체지향과_클래스
{
    internal class Program
    {
        class Chracter
        {
            public int level = 1;
            private int hp = 100;
            private float speed;
            public int attack;

            public void MoveUp()
            {
                Console.WriteLine("앞으로 전진합니다.");
            }
            public void MoveBack()
            {
                Console.WriteLine("뒤로 후진합니다.");
            }
            public void MoveRightTrun()
            {
                Console.WriteLine("오른쪽으로 좌회전 합니다.");
            }
            public void MoveleftTrun()
            {
                Console.WriteLine("왼쪽으로 우회전 합니다.");
            }
            public void TakeDamage(int damage)
            {
                Console.WriteLine($"{damage}만큼 데미지를 받습니다.");
                hp -= damage;
                Console.WriteLine($"{hp}체력남았습니다.");
            }
            public void Attack(int attack)
            {
                Console.WriteLine($"{attack}만큼 공격했습니다.");
            }
        }
        static void Main(string[] args)
        {
            Chracter chracter = new Chracter();
            chracter.MoveUp();
            chracter.MoveBack();
            chracter.MoveRightTrun();
            chracter.MoveleftTrun();
            chracter.Attack(10);
            chracter.TakeDamage(30);
        }
    }
}
