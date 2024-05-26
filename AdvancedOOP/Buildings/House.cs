using AdvancedOOP.Rooms;
namespace AdvancedOOP.Buildings
{
class House : Building          //child class
{
public double gardenWidth;      //Field
public double gardenLength;     //Field
public Bathroom bathroom;       //declaration of a public field named bathroom of type Bathroom within a class.

//Constructor
public House(Bathroom bathroom, double gardenWidth, double gardenLength,string material, string postcode, bool insured) : base(material, postcode, insured)
//Why initialize base class members:When you derive a class from a base class, the derived class inherits all the fields, properties, 
//and methods of the base class. However, the base class might have some members that need to be initialized properly.
 //By calling the base class constructor, you ensure that all necessary initialization defined in the base class is executed.
{
this.gardenWidth = gardenWidth;
this.gardenLength = gardenLength;
this.bathroom = bathroom;
}
public void MowTheLawn()
{
Console.WriteLine($"The lawn at {postcode} has been mowed.");  //Message
}

}
}