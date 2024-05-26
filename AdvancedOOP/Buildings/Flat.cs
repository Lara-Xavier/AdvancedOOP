using System;
using AdvancedOOP.Buildings;
using AdvancedOOP.Rooms;

    class Flat : Building         //child class
    {
        public bool balcony;    //field
        public int floor;       //field
        public int flatno;      //field
    

    public Flat (bool balcony,int floor,int flatno,string material, string postcode, bool insured) : base(material, postcode, insured)     //Constructor
    {
    this.balcony = balcony;
    this.floor = floor;
    this.flatno = flatno;
    }

    public void ForSale()
    {
        Console.WriteLine("This flat for sale.");
    }
    
}
