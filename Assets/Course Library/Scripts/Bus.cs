using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class
public class Bus : Vehicle
{
    void Start()
    {
        // POLYMORPHISM - overloading
        base.Init("White", 4500, 60);
    }

    // POLYMORPHISM - overriding
    public override string Move()
    {
        string result = base.Move();  // call parent class method

        // class-specific code
        result += "\nBut I can't move so fast.";

        return result;
    }

    public override string Honk()
    {
        return "Honk!";
    }

    public override string Description()
    {
        return $"I am {Color} and {Weight} KGs, and my max speed is {MaxSpeed} KM/h, and I am a {gameObject.name}";
    }

    public override string ShowYourself()
    {
        string result = base.Description();

        result += Honk();

        return result;
    }
}
