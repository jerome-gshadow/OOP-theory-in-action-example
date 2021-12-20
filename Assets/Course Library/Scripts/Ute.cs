using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class
public class Ute : Vehicle
{
    // ENCAPSULATION
    public int CrateCount { get; private set; }

    void Start()
    {
        // POLYMORPHISM - overloading
        base.Init("Red", 6500, 120);
        CrateCount = 30;
    }

    // POLYMORPHISM - overriding
    public override string Move()
    {
        string result = base.Move();  // call parent class method

        // class-specific code
        result += "\nMy max speed is OK.";

        return result;
    }

    public override string Honk()
    {
        return "Honk! Honk! Beep! Beep!";
    }

    public override string Description()
    {
        return $"Well, I am a {gameObject.name}. I am {Color} and {Weight} KGs. My max speed is {MaxSpeed} KM/h, and I am carrying {CrateCount} Crates.";
    }

    public override string ShowYourself()
    {
        string result = base.Description();

        result += "\nI always have many crates.";
        result += Honk();

        return result;
    }
}
