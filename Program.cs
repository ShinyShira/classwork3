
namespace Lesson1
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Health = 64;
            student1.Happiness = 2;
            student1.Inellegence = 50;
            student1.Knowlege = 20;
            student1.Fun();
        } 
    }
    public class Student
    {
        public int Health;
        public int Inellegence;
        public int Happiness;
        public int Knowlege;

        public void Fun()
        {
           Health -= 1;
            Happiness += 5;
            Knowlege -= 2;
            Console.WriteLine($"Студент потусил, его Здоровье: {Health} Интеллект: {Inellegence} Счастье: {Happiness} Знание: {Knowlege}");
        }

    }
}
