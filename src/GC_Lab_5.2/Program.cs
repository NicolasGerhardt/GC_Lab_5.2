using System;
using System.Collections.Generic;



namespace GC_Lab_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play some Rock/Paper/Scissors!!");
            int numOfHumanPlayers = UI.GetNumberOfHumanPlayers();
            List<Player> players = new List<Player>();
            

            for (int i = 1; i <= numOfHumanPlayers; i++)
            {
                string userName = UI.GetStringFromUser($"Enter name for player {i}: ");
                players.Add(new Human(userName));
            }

            for (int i = players.Count; i < 2; i++)
            {
                
                string NPCname = UI.GetStringFromUser($"Enter name for player {i + 1}: ");
                Player NPC = GetSpecificNPC(NPCname);
                players.Add(NPC);
            }


            do
            {
                Dictionary<Player, Roshambo> playerChoices = new Dictionary<Player, Roshambo>();
                // Get each players choices
                foreach (Player player in players)
                {
                    playerChoices[player] = player.GenerateNextRoshambo();
                }

                Console.Clear();
                foreach (Player player in players)
                {
                    Console.WriteLine($"{player} picked {playerChoices[player]}.");
                }

                if (playerChoices[players[0]] == playerChoices[players[1]])
                {
                    UI.WriteBlue("Tie");
                }
                else if (playerChoices[players[0]] == playerChoices[players[1]] - 1 || playerChoices[players[0]] == playerChoices[players[1]] + 2)
                {
                    UI.WriteGreen($"{players[1]} Wins!!");
                }
                else
                {
                    UI.WriteGreen($"{players[0]} Wins!!");
                }
                UI.PressAnyKeyToContinue();

            } while (UI.PlayAgain());
        }

        private static Player GetRandomNPC(string npcName)
        {
            Random random = new Random();

            if (random.Next(2) == 0)
            {
                return new Rando(npcName);
            }

            return new Rocky(npcName);
        }

        private static Player GetSpecificNPC(string npcName) 
        {
            while (true)
            {
                string type = UI.GetStringFromUser("What type of NPC is this player?\n Rando or Rocky: ").ToLower();

                if (type == "rando")
                {
                    return new Rando(npcName);
                }
                else if (type == "rocky")
                {
                    return new Rocky(npcName);
                }
                else
                {
                    UI.WriteErrorMessage("Must type Rando or Rocky");
                }
            }
        
        }
    }
}
