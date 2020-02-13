using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
    public static class UI
    {
        public static string GetStringFromUser(string prompt)
        {
            prompt = ValidPrompt(prompt);

            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetIntFromUser(string prompt)
        {
            int output = 0;
            bool validInput = false;
            while (!validInput)
            {
                string userString = GetStringFromUser(prompt);
                validInput = int.TryParse(userString, out output);

                if (!validInput)
                {
                    WriteErrorMessage("Must be a number");
                }
            }

            return output;
        }

        internal static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any Key to Continue...");
            Console.ReadKey(true);
        }

        public static void WriteErrorMessage(string errorMessage)
        {
            WriteConsoleColor($"ERROR: {errorMessage}", ConsoleColor.Red);
        }

        public static void WriteConsoleColor(string message, ConsoleColor writeColor)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = writeColor;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;
        }

        internal static bool PlayAgain()
        {
            Console.Clear();
            while (true)
            {


                Console.WriteLine("Do you want to play again? (y/n)");
                ConsoleKey reply = Console.ReadKey(true).Key;
                switch (reply)
                {
                    case ConsoleKey.Y:
                        return true;
                    case ConsoleKey.N:
                        return false;
                    default:
                        WriteErrorMessage("must press y or n");
                        break;
                }
            }
        }

        internal static void WriteGreen(string message)
        {
            WriteConsoleColor(message, ConsoleColor.Green);
        }

        internal static void WriteBlue(string message)
        {
            WriteConsoleColor(message, ConsoleColor.Blue);
        }

        private static string ValidPrompt(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                prompt = "Enter Input \n> ";
            }
            return prompt;
        }

        public static void DisplayStringListAsNumberedMenu(string menuTitle, IList<string> menuList)
        {
            Console.WriteLine(menuTitle);
            Console.WriteLine("=================");
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {menuList[i]}");
            }
            Console.WriteLine("=================");
        }

        public static int GetMenuSelection(string menuTitle, IList<string> menuList)
        {
            bool validMenuChoice = false;
            int choice = -1;
            while (!validMenuChoice)
            {
                if (choice == -1)
                {
                    Console.Clear();
                    DisplayStringListAsNumberedMenu(menuTitle, menuList);
                }

                choice = GetIntFromUser("> ") - 1;

                if (choice > -1 && choice < menuList.Count)
                {
                    validMenuChoice = true;
                }
                else if (choice != -1)
                {
                    WriteErrorMessage($"Must be a number between 1 & {menuList.Count}");
                }

            }

            return choice;
        }

        public static Roshambo GetRoshamboFromUser(string name)
        {
            string[] RPSList = Enum.GetNames(typeof(Roshambo));

            int playerChoice = UI.GetMenuSelection($"{name}, what would you like to throw?", RPSList);

            return (Roshambo)playerChoice;
        }
        
        public static int GetNumberOfHumanPlayers()
        {
            List<string> playerOptionsList = new List<string>();
            playerOptionsList.Add("Computer vs Computer");
            playerOptionsList.Add("Computer vs Human");
            playerOptionsList.Add("Human vs Human");

            return UI.GetMenuSelection("What type of game do you want to play?", playerOptionsList);
        }

    }
}
