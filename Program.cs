
namespace Lesson1
{
    public class Program
    {
       
        static void Main(string[] args)
        {

            Demon demon1 = new Demon();
            Demon demon2 = new Demon(12);
            /*Swordsman swordsman1 = new Swordsman();*/

            do
            {

                demon2.AttackFoe(demon1);
                Console.WriteLine($"Demon2 атаковал Demon1 , у него осталось: {demon1.Health} здоровья.");
                demon1.AttackFoe(demon2);
                Console.WriteLine($"Demon1 атаковал Demon2 , у него осталось: {demon2.Health} здоровья.");
            }
            while (demon1.Health > 0 || demon2.Health > 0) ;
            { 
                Console.WriteLine($"конец"); 
            }

        } 
    }
   
    public class Demon
    {
        public double Health;
        public double Attack;
        public double Defence;
        public double Speed;
        public double Damage;

        public Demon()
        {
            Health = 35;
            Attack = 10;
            Defence = 10;
            Speed = 5;
            Damage = 8;
        }
        public Demon(double defence)
        {
            Health = 35;
            Attack = 10;
            Defence = defence;
            Speed = 5;
            Damage = 8;
        }
        public void AttackFoe(Demon otherDemon)
        {
            if (Attack < otherDemon.Defence)
            { otherDemon.Health -= Damage * (1 / (1 + (Attack - otherDemon.Defence) * 0.05)); }
            else
            { otherDemon.Health -= Damage * (1 + (Attack - otherDemon.Defence) * 0.05); }
            
        }
    }
    //    public class Swordsman
    //    {
    //        public double Health;
    //        public double Attack;
    //        public double Defence;
    //        public double Speed;
    //        public double Damage;

    //        public Swordsman()
    //        {
    //            Health = 35;
    //            Attack = 10;
    //            Defence = 12;
    //            Speed = 5;
    //            Damage = 8;
    //        }
    //        public void AttackFoe(Swordsman otherDemon)
    //        {
    //            otherDemon.Health -= Damage * (1 + (Attack - otherDemon.Defence) * 0.05);
    //            Console.WriteLine($"Мечник атаковал демона, у него осталось: {Health} здоровья.");
    //        }
    //    }
}
