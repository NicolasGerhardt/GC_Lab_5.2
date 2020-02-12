# Lab 5.2: Rock, Paper, Cissors
## Task
Create a rock, paper, scissors game.

## What will the application do?
* The application prompts the player to enter a name and select an opponent.
* The application prompts the player to select rock, paper, or scissors. Then, the application displays the player’s choice, the opponent’s choice, and the result of the match.
* The application continues until the user doesn’t want to play anymore.
* If the user makes an invalid selection, the application should display an appropriate error message and prompt the user again until the user makes a valid selection.

## Build Specifications/Grading Standards (Graded out of 10)
1. Use the Roshambo enumeration started for you. It stores three values: rock, paper, and scissors.
1. Create an abstract class named Player that stores a name and a Roshambo value. This class should include a method named GenerateRoshambo that allows an inheriting class to generate and return a Roshambo value.
	* Fields and properties: 1 point
	* Abstract method GenerateRoshambo: 1 point
1. Create and name two player classes, each of which implements GenerateRoshambo differently. One player should always select rock. The other player should randomly select rock, paper, or scissors (a 1 in 3 chance of selecting each).
	* Rock class implements GenerateRoshambo correctly: 1 point
	* Random player class implements GenerateRoshambo correctly: 1 point
1. Create a third player class that inherits the Player class and implements the GenerateRoshambo method. The method for this class takes input from the user and returns the value they choose.
	* Human player class implements GenerateRoshambo:
		* Takes user input correctly: 1 point
		* Overrides abstract method and returns correctly: 1 point
1. Create a Main() that allows the user to play against either of your first two player classes.
	* Takes user choice of players and instantiates correct player class: 1 point
	* Instantiates human player: 1 point
	* Calls GenerateRoshambo from each player: 1 point
	* Decides winner correctly: 1 point

## Extended Challenges
* Create a Validator class to handle validation of all console input. It could have methods like GetYN (gets Y/y or N/n), GetOtherPlayer (accepts the names of your two players), GetRoshambo (accepts r/p/s and/or rock/paper/scissors).
* Keep track of wins and losses, and display them at the end of each session.