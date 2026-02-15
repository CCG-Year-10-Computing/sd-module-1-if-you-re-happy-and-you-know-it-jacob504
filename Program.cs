// Program Name: adventure of the fortnite player
// Created on: Visual Studio
// Author: Jacob Waring

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

// Player health and land zones
int playerHealth = 200;
string landZone1 = "tilted towers";
string landZone2 = "loot lake";
Console.WriteLine("Welcome to Fortnite Battle Royale 1V1");

// how much health you have still
Console.WriteLine("Health = 200");

// asking where you want to land
Console.Write("Where do you want to land? ");
Console.Write("Tilted Towers or Loot Lake? ");
string response = Console.ReadLine();

if (response.ToLower() == landZone1)
{
    Console.WriteLine("You are landing at Tilted Towers");
}
else if (response.ToLower() == landZone2)
{
    Console.WriteLine("You are landing at Loot Lake");
}
else
{
    // if the wrong input is typed in it will say this
    Console.WriteLine("That is not the correct input");
    Console.WriteLine("Please try again");
    return;
}

//asking if you want to open a chest
Console.WriteLine("You see a chest, do you want to open it?");
Console.Write("yes/no ");

string openChest = "yes";
string noChest = "no";

string response2 = Console.ReadLine();

if (response2.ToLower() == openChest)
{
    Console.WriteLine("You opened the chest and got a blue shotgun");
}
else if (response2.ToLower() == noChest)
{
    Console.WriteLine("You didnt open the chest and got 200 pumped");
    playerHealth = 0;
}
else
{
    Console.WriteLine("That is not the correct input");
    Console.WriteLine("Please try again");
    return;
}

while (true)
{
    if (playerHealth == 0) // if you die it will say you have died and then will stop the loop
    {
        Console.WriteLine("Health = 0");
        Console.WriteLine("Game over, you died");
        break;
    }
    else
    {
        //variables for if you want to shoot the player or not
        string shoot = "yes";
        string dontShoot = "no";

        //asking if you want to shoot the player
        Console.WriteLine("You see a player to your right, do you shoot him");
        Console.Write("yes/no ");
        string response3 = Console.ReadLine();

        
        if (response3.ToLower() == dontShoot)
        {
            Console.WriteLine("you didnt shoot him and got 200 pumped");
            playerHealth = 0;
        }

        else if (response3.ToLower() == shoot)
        {   
            // variables for if you want to shoot the other player
            string shoot2 = "yes";
            string dontShoot2 = "no";

            // asking if you want to shoot the other player
            Console.WriteLine("You killed him and lived");
            Console.WriteLine("Health = 200");
            Console.WriteLine("There is one player left to win and he is to your left, do you shoot him?");
            Console.Write("yes/no ");
            string response4 = Console.ReadLine();

            if (response4.ToLower() == shoot2)
            {
                Console.WriteLine("You killed him and lived");
                Console.WriteLine("You win!");
                return;
            }
            else if (response4.ToLower() == dontShoot2)
            {
                Console.WriteLine("you didnt shoot him and got 200 pumped");
                playerHealth = 0;
            }
            else
            {
                Console.WriteLine("That is not the correct input");
                Console.WriteLine("Please try again");
                return;
            }
        }
        else
        {
            Console.WriteLine("That is not the correct input");
            Console.WriteLine("Please try again");
            return;
        }
    }
}
