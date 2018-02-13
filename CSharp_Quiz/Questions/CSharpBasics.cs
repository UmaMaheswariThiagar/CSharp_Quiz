namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    class CSharpBasics
    {

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 
            public void ToFindLandscapeOrPortrait()
            {
            int Length;
            int Breath;

            Console.WriteLine("Enter length of your image:");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breath of your image:");
            Breath = int.Parse(Console.ReadLine());
            if (Length < Breath)
            {
                Console.WriteLine("Your image is Landscape");
            }
            else if (Length > Breath)
            {
                Console.WriteLine("Your image is Portrait");
            }
            else
            {
                Console.WriteLine("Your image is square");
            }
            }



        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
         static void Main(string[] args)

        {

            int i, number, fact;

            Console.WriteLine("Enter the Number");

            number = int.Parse(Console.ReadLine());

            fact = number;

            for (i = number - 1; i >= 1; i--)

            {

                fact = fact * i;

            }

            Console.WriteLine("\n Factorial is " + fact);

            Console.ReadLine();



        }
        
        /// </summary>
        /// 




        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
       
        static void Main(string[] args)

        {

        string Str, reversestring = "";

        int Length;

        Console.Write("Enter A String : ");

        Str = Console.ReadLine();

        Length = Str.Length - 1;

        while (Length >= 0)

        {

            reversestring = reversestring + Str[Length];

            Length--;

        }

        Console.WriteLine("Reverse  String  Is  {0}", reversestring);

        Console.ReadLine();

    }

}
        /// </summary>
        /// 



        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
            static void Main(string[] args)
             {
            Console.WriteLine("Input a few numbers separated by a hyphen : ");

            string input = Console.ReadLine();

            string[] split = input.Split('-');

            string temp = split[0];

            for (int i = 1; i < split.Length; i++)
            {
                 Console.WriteLine(temp);

                  if (temp == split[i])
                {
                    Console.WriteLine("Consecutive");
                }
            }
        /// </summary>
        /// 



    }
}
