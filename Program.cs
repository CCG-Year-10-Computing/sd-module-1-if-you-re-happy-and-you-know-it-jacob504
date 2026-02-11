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
Console.WriteLine("Welcome to Fortnite Battle Royale");


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
}

Console.WriteLine("You see a chest, do you want to open it?");



