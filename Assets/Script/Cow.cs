using UnityEngine;
using System.Collections.Generic;
public class Cow : Animal
{

    // Encapsulated field with property
    private float milk;
    public float Milk
    {
        get => milk;
        set => milk = Mathf.Max(0, value);
    }

    int happinessWhenMoo = 20;

    // Initialization method
    public void Init(string newName, int newHunger, int newHappiness, int newMilk)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = newMilk;
    }

    // Override MakeSound method
    public override void MakeSound()
    {
        Debug.Log($"{Name}: Moo!");
    }

    // Method to simulate mooing
    public void Moo()
    {
        AdjustHappiness(happinessWhenMoo);
        Debug.Log($"{Name} says Muooooo! and feels happier.");
    }
}