
namespace Lesson1
{
    public class Program
    {
       
        static void Main(string[] args)
        {

            Demon demon1 = new Demon();
            Swordsman swordsman1 = new Swordsman();
            
            do
                {
                if (demon1.Health >= 0) 
                swordsman1.AttackFoe(swordsman1);
                else if (demon1.Health >= 0) 
                demon1.AttackFoe(demon1); 
                }
            while (swordsman1.Health >= 0 || demon1.Health >= 0) ;
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
        public void AttackFoe(Demon otherSwordsman)
        {
            otherSwordsman.Health -= Damage*(1/(1+(Attack-otherSwordsman.Defence)*0.05));
            Console.WriteLine($"Демон атаковал мечника, у него осталось: {Health} здоровья.");
        }
    }
    public class Swordsman
    {
        public double Health;
        public double Attack;
        public double Defence;
        public double Speed;
        public double Damage;

        public Swordsman()
        {
            Health = 35;
            Attack = 10;
            Defence = 12;
            Speed = 5;
            Damage = 8;
        }
        public void AttackFoe(Swordsman otherDemon)
        {
            otherDemon.Health -= Damage * (1 + (Attack - otherDemon.Defence) * 0.05);
            Console.WriteLine($"Мечник атаковал демона, у него осталось: {Health} здоровья.");
        }
    }
}
