using System.Security.AccessControl;

namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //I'm Travis I'm Travis

            Part1();

            Part2();

            Part3();

            Part4();

            Part5();
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
            Console.WriteLine("");
            Console.WriteLine("");
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
            Console.WriteLine("");
            Console.WriteLine("");
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
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Part4()
        {
            double numberOne = 0, numberTwo = 0, numberThree = 0;
            Console.Write("Give me a number! ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out numberOne));
            Console.Write("Give me a number again! ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out numberTwo));
            Console.Write("Give me a number one more time! ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out numberThree));
            Console.WriteLine("Your super duper secret number is " + (numberOne + numberTwo + numberThree)/2 + "!");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Part5()
        {
            string item1 = "", item2 = "";
            double item1Price = 0, item2Price = 0, flatTotal = 0, discountCut = 0, subTotal = 0, taxAdd = 0, total = 0;
            const double discount = .2, tax = .13;

            Console.Write("Item 1: ");
            item1 = Console.ReadLine();
            Console.Write("Item 1 Price: ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out item1Price));
            Console.Write("Item 2 : ");
            item2 = Console.ReadLine();
            Console.Write("Item 2 Price: ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out item2Price));
            Console.WriteLine("");

            flatTotal = item1Price + item2Price;
            discountCut = flatTotal * discount;
            subTotal = flatTotal - discountCut;
            taxAdd = subTotal * tax;
            total = subTotal + taxAdd;

            Console.WriteLine("Your Receipt:");
            Console.WriteLine("");
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: " + item1Price.ToString("C"));
            Console.WriteLine("Item 2:" + item2);
            Console.WriteLine("Price: " + item2Price.ToString("C"));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Flat Total: " + flatTotal.ToString("C"));
            Console.WriteLine("Discount (20%): " + discountCut.ToString("C"));
            Console.WriteLine("Subtotal: " + subTotal.ToString("C"));
            Console.WriteLine("Tax (13%): " + taxAdd.ToString("C"));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Total: " + total.ToString("C"));


        }




    }
}
