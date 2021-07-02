using System;

namespace GravityApp
{
    class Program
    {
        public double Mass1
        {
            get;set;
        }

        public double Mass2
        {
            get;set;
        }

        public double Distance
        {
            get;set;
        }

        public double Force
        {
            private set
            {

            }
            get
            {
                double g = 6.67408E-11;
                double f = Mass1 * Mass2;
                f /= (Distance * Distance);
                return g*f;
            }
        }
        static void Main()
        {
            
            bool goingOn = true;
            while (goingOn)
            {
                Program gravity = new Program();
                Console.WriteLine("This is an app for calculating the force of gravity on each mass in a 2 body system!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter the mass of the 1st body (in the form of a double, please), here:");
                gravity.Mass1 = GetUserDouble();
                Console.WriteLine("Now, enter the mass of the 2nd body:");
                gravity.Mass2 = GetUserDouble();
                Console.WriteLine("What is the distance between the 2?");
                gravity.Distance = GetUserDouble();
                Console.WriteLine("So, then the gravitational they would exert on one another would be: "+
                    gravity.Force+"!");
                Console.WriteLine("Would you like to try it for some other values (masses & distances)?");
                bool notValid;
                do
                {
                    string yesOrNo = Console.ReadLine();
                    yesOrNo = yesOrNo.ToLower();
                    switch (yesOrNo)
                    {
                        case "y":
                        case "yes":
                            goingOn = true;
                            notValid = false;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "no":
                        case "n":
                            goingOn = false;
                            notValid = false;
                            break;
                        default:
                            notValid = true;
                            Console.WriteLine("Please write yes, no, or the letters y or n.");
                            break;
                    }
                } while (notValid);
                

                
            }
        }

        static double GetUserDouble()
        {
            while (true)
            {
                double trouble;
                string strung = Console.ReadLine();
                if (Double.TryParse(strung,out trouble))
                { return trouble; }
                Console.WriteLine("Please enter a number in the form of a double!");
            }
        }

    }
}
