using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class
public class ArmorCar : Vehicle
{
    // ENCAPSULATION
    public int BulletCount { get; private set; }

    void Start()
    {
        // POLYMORPHISM - overloading
        base.Init("Green", 9000, 40);
        BulletCount = 100;
    }

    // POLYMORPHISM - overriding
    public override string Move()
    {
        string result = base.Move();  // call parent class method

        // class-specific code
        result += "\nI have armor but I just move slowly.";

        return result;
    }

    public override string Honk()
    {
        return "Nah, I can't do that.";
    }

    public override string Description()
    {
        return $"I am {Color} and {Weight} KGs and my max speed is {MaxSpeed} KM/h. I am with armor and carrying {BulletCount} bullets.";
    }

    // ABSTRACTION
    public override string ShowYourself()
    {
        string result = base.Description();

        result += Honk();
        result += "But I can shoot!";
        result += Shoot();

        return result;
    }

    public string Shoot()
    {
        return $"{gameObject.name} is shooting bullets...";
    }
}
