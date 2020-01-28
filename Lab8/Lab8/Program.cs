using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        bool restart = true;
        while (restart == true)
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (Enter a number 1-5)");

            List<string> students = new List<string>() { "", "Obi-Wan Kenobi", "Captain America", "Gandalf", "Batman", "Thanos, The Mad Titan" };

            string studentnum = Console.ReadLine();

            int input;

            bool parse = int.TryParse(studentnum, out input);

            if (parse == false)
            {
                Console.WriteLine("That was not a number. Please try again.");
            }
            else
            {

                try
                {
                    Console.WriteLine("You have chosen to learn more about " + students[input] + ". What would you like to learn about " + students[input] + "? (Enter home or weapon)");
                }

                catch (Exception)
                {
                    Console.WriteLine("The number entered must be between 1-5. Please try again.");

                }
            }
            bool test = true;
            while (test)
            {
                string input2 = Console.ReadLine();


                List<string> homes = new List<string>() { "", "The planet, Stewjon", "Brooklyn, NY", "The Gardens of Lórien in Aman", "Gotham", "The planet, Titan" };
                List<string> weapons = new List<string>() { "", "Lightsaber and the Force", "Vibranium Shield", "Wizard Staff", "Batarang", "Infinity Gauntlet" };



                if (input2 == "home")
                {
                    string home = homes[input];
                    Console.WriteLine(home);
                    test = false;

                }
                else if (input2 == "weapon")
                {
                    string weapon = weapons[input];
                    Console.WriteLine(weapon);
                    test = false;
                }
                else if (input2 != "home" && input2 != "weapon")
                {
                    Console.WriteLine("I didn't understand that. Please try again. (Enter home or weapon)");

                }


            }

            restart = ContinueLoop();


        }
    }



    public static bool ContinueLoop()
    {
        Console.WriteLine("Would you like to learn about another student?");
        string response = Console.ReadLine().ToLower();

        if (response == "y")
        {
            return true;
        }

        else if (response == "n")
        {
            Console.WriteLine("Have a nice day!");
            return false;
        }
        else
        {
            Console.WriteLine("Hey, I didn't understand that. Let's try again.");
            return ContinueLoop();
        }
    }




}