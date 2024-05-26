using System;
namespace AdvancedOOP.Buildings
{
abstract class Building  //base class[class inherit from parent class]
{
public String material;  //Field
public String postcode;
public bool insured;
public Building(string material, string postcode, bool insured)  //Constructor
{
this.material = material;
this.postcode = postcode;
this.insured = insured;
}
public void Bulldoze()  //method
{
Console.WriteLine($"Building at {postcode} has been bulldozed.");
}

public void Insulate()
{
Console.WriteLine($"Building at {postcode} has been insulated.");
}

}
}