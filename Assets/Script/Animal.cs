using JetBrains.Annotations;
using UnityEngine;

// Base class for all animals
public abstract class Animal : MonoBehaviour
{
    // Encapsulated fields with properties
    private new string name;
    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "No Name" : value;
    }
    private int hunger;
    public int Hunger
    {
        get => hunger;
        set => hunger = Mathf.Clamp(value, 0, 50);
    }
    private int happiness;
    public int Happiness
    {
        get => happiness;
        set => happiness = Mathf.Clamp(value, 0, 50);
    }

    // Initialization method
    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    // Method to display animal stats
    public void GetStats()
    {
        Debug.Log($"Animal Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}");
    }

    // Method to adjust hunger
    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    // Method to adjust happiness
    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    // Virtual method for making sound
    public virtual void MakeSound() { }

    // Overloaded Feed methods
    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} is fed with {amount} food.");
    }

    // Overloaded Feed method with food type
    public void Feed(string food, int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} is fed with {amount} of {food}.");
    }
}