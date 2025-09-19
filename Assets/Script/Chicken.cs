using UnityEngine;
using System.Collections.Generic;

public class Chicken : Animal
{
    // Encapsulated field with property
    private int eggs;
    public int Eggs { get; set; }

    int HappinessWhenSleep = 5;
    int HungerWhenSleep = 3;

    // Initialization method
    public void Init(string newName, int newHunger, int newHappiness, int newEggs)
    {
        base.Init(newName, newHunger, newHappiness);
        Eggs = newEggs;
    }

    // Override MakeSound method
    public override void MakeSound()
    {
        Debug.Log($"{Name}: Cluck! Cluck!");
    }

    // Method to simulate sleeping
    public void Sleep()
    {
        base.AdjustHunger(HungerWhenSleep);
        base.AdjustHappiness(HappinessWhenSleep);
        Debug.Log($"{Name} is sleeping. Hunger increased little and very happy.");
    }
}
