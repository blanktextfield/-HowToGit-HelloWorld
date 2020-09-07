using System;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {/*create an app 
          * 1. App asks the user`s name and greets the user by their name;
          * 2. App asks the user`s age and calculates what year the user was born;
          * 3. App displays the result to the user
          
            */
            Console.WriteLine("Welcome User");
            Console.WriteLine("please insert user`s name");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("what is user´s age");
            string Userinput;
            Userinput = Console.ReadLine();
            int Yearofbirth;
            //parsing string to interger (number)
            Yearofbirth = Int32.Parse(Userinput);
            int Age = 2020 - Yearofbirth;
            Console.WriteLine("you were born in" + Age + ".");







            
        }
    }
}
