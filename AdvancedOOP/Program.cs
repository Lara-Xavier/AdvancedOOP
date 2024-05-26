
// See https://aka.ms/new-console-template for more information
using AdvancedOOP.Buildings;
using AdvancedOOP.Rooms;


Console.WriteLine("Building simulator:");

House building1 = new House(new Bathroom(true, true), 80, 60, "Brick", "RT3 7TW", true);
Flat building2 = new Flat(true,2,123,"Brick", "RT3 7TW", true);

building1.Bulldoze();
Console.WriteLine("Building Insured:" + building1.insured);
Console.WriteLine("Building 1 - Garden Length: " + building1.gardenLength + " Garden Width: " + building1.gardenWidth);

Console.WriteLine("Building Insured:" + building2.insured);
Console.WriteLine("Building 2 - Balcony: " + building2.balcony + " Floor: " + building2.floor);

