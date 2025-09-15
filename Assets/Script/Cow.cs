using UnityEngine;

class Cow
{

    private string name;
    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "No Name" : value;
    }
    private int hunger;
    public int Hunger
    {
        get => hunger;
        set
        {
            hunger = Mathf.Clamp(value, 0, 50);
            Debug.Log($"{Name}'s hunger is now {hunger}.");
        }
    }
    private int happiness;
    public int Happiness
    {
        get => happiness;
        set
        {
            happiness = Mathf.Clamp(value, 0, 50);
            Debug.Log($"{Name}'s happiness is now {happiness}.");
        }
    }
    private float milk;
    public float Milk
    {
        get => milk;
        set => milk = Mathf.Max(0, value);
    }

    // Feed, Moo values
    int hungerWhenFed = -20;

    int happinessWhenMoo = 10;

    // Constructor
    public Cow(string newName, int newHunger, int newHappiness, int newMilk)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = newMilk;
    }

    public void GetStats()
    {
        Debug.Log($"Cow Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }

    void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name}: Moo!");
    }

    public void Feed(string food)
    {
        AdjustHunger(hungerWhenFed);
        Debug.Log($"{Name} is fed with {food}. Hunger decreased by {-hungerWhenFed}.");
    }

    public void Moo()
    {
        AdjustHappiness(happinessWhenMoo);
        Debug.Log($"{Name} moos. Happiness increased by {happinessWhenMoo}.");
    }

    /*public void Play()
    {
    }
    public void ProduceMilk()
    {
    }*/
}