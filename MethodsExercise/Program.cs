namespace MethodsExercise
{
    public class Program
    {

        public static int sum (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        public static int divide (int num1, int num2)
        {
            return num1 / num2;
        }
         public static int subtract (int num1, int num2)
        {
            return num1 - num2;
        }


        static void Main(string[] args)
        

        {
            int workHours = sum(8, 12);

            int plain = multiply(22, 3);

            int Blep = divide(8, 2);

            int sub = subtract(20, 12);


            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
           
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine("And finally, what is your favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"This future coders name is {userName}, his favorite color is {favColor}, his favorite animal is a {favAnimal}, and lastly, his favorite band is {favBand}");


        }
    }
}
