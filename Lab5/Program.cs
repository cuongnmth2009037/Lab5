using System;
using Lab5.Exercise2;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // Exercise1:
            // while (true)
            // {
            //     Console.WriteLine("1.Grocery");
            //     Console.WriteLine("2.Bakery");
            //     Console.WriteLine("3.Exit");
            //     Console.WriteLine("Please enter (1-3): ");
            //     var choice = Convert.ToInt32(Console.ReadLine());
            //     if (choice == 1)
            //     {
            //         Console.WriteLine("Enter custumer name: ");
            //         var name = Console.ReadLine();
            //         var customer = new Customer();
            //         var nameResult = customer.AcceptsCustomerName(name);
            //         var grocery = new Order.Grocery();
            //         Console.WriteLine(nameResult + " " + grocery.ChoiceGrocery());
            //     }
            //     else if (choice == 2)
            //     {
            //         Console.WriteLine("Enter custumer name: ");
            //         var name = Console.ReadLine();
            //         var customer = new Customer();
            //         var nameResult = customer.AcceptsCustomerName(name);
            //         var bakery = new Order.Bakery();
            //         Console.WriteLine(nameResult + " " + bakery.ChoiceBakery());
            //     }
            // }
            
            
            
            // Exercise2:
            Console.WriteLine("Enter Fullname: ");
            var namme = Console.ReadLine();
            Console.WriteLine("Enter BaseSalary: ");
            var basesalary = Console.ReadLine();
            Console.WriteLine("Enter SkillLevel: ");
            var skilllever = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SeniorLecture: ");
            var seniorlecture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bonus: ");
            var bonus = Convert.ToInt32(Console.ReadLine());
            UniversityTeacher universityTeacher = new UniversityTeacher();
            universityTeacher.CalculateSalary();
            Console.WriteLine(universityTeacher);





        }
    }
}