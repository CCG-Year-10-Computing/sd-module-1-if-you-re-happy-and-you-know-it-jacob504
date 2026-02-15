// Program Name: adventure of the fortnite player
// Created on: Visual Studio
// Author: Jacob Waring

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

// Player lives, health and land zones
int playerLives = 1;
int playerHealth = 200;
string landZone1 = "tilted towers";
string landZone2 = "loot lake";
Console.WriteLine("Welcome to Fortnite Battle Royale 1V1");

// how much health you have still
Console.WriteLine("Health = 200");


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
    Console.WriteLine("That is not the correct input");
    Console.WriteLine("Please try again");
    return;
}

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
    if (playerHealth == 0)
    {
        Console.WriteLine("Health = 0");
        Console.WriteLine("Game over, you died");
        playerLives = 0;
        break;
    }
    else
    {
        string shoot = "yes";
        string dontShoot = "no";

        Console.WriteLine("You see a player to your right, do you shoot him");
        Console.Write("yes/no ");
        string response3 = Console.ReadLine();

        if (response3.ToLower() == shoot)
        {
            Console.WriteLine("You killed him and lived");
            Console.WriteLine("Health = 200");
        }
        else if (response3.ToLower() == dontShoot)
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
}




