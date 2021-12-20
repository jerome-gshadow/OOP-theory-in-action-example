using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class
public class Car : Vehicle
{
    void Start()
    {
        // POLYMORPHISM - overloading
        base.Init("Blue", 2500, 150);
    }

    // POLYMORPHISM - overriding
    public override string Move()
    {
        string result = base.Move();  // call parent class method

        // class-specific code
        result += "\nAnd I can go faster than other vehicles.";

        return result;
    }

    public override string Honk()
    {
        return "Beep!";
    }

    // Description() remains the same as parent's method

    public override string ShowYourself()
    {
        string result = "";

        result += Honk();
        result += Description();
        result += Honk();

        return result;
    }
}
