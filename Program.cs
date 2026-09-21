using System.Security.AccessControl;

namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //I'm Travis I'm Travis

            //Part1();

            //Part2();

            Part3();

            //Part4();
        }

        public static void Part1()
        {
            string name = "";
            int age = 0;
            double salary = 0;

            Console.WriteLine("Your name is...?");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Is that so? Well, " + name + ", how old are ya?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("");
            Console.WriteLine(age + ", Huh? That's only one year younger than me! Say, " + name + ", how much do ya make an hour?");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out salary));
            Console.WriteLine("");
            Console.WriteLine("You make " + salary.ToString("C") + " an hour? That's more than me!");
        }

        public static void Part2()
        {
            string firstName = "", lastName = "", login = "";
            int studentGrade = 0, studentID = 0;
            double studentAvgMark = 0;

            Console.WriteLine("Hey, hey! Can you give me your student information pretty pleeaaaseee? :)");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentGrade));
            Console.Write("ID: ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentID));
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average Mark: ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out studentAvgMark));
            Console.WriteLine("");
            Console.WriteLine("Thanks! Now I can use this information for evil, you idiot! I'll let you look at it one last time! >:)");
            Console.WriteLine("Name: \t\t" + firstName + " " + lastName);
            Console.WriteLine("Grade: \t\t" + studentGrade);
            Console.WriteLine("ID: \t\t" + studentID);
            Console.WriteLine("Login: \t\t" + login);
            Console.WriteLine("Average Mark: \t" + studentAvgMark);

        }

        public static void Part3()
        {
            string name = "";
            int age = 0;

            Console.WriteLine("What's your name bud?");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(name + ", eh? How old might you be there?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("");
            Console.WriteLine(age + ", hm? Well that ain't too bad! Did ya know that you were " + (age - 5) + " years old five years ago, and you'll be " + (age + 5) + " years old in five years! Well... given you don't die of course.");

        }

        public static void Part4()
        {

        }


       

        
    }
}
