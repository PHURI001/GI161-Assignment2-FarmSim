using UnityEngine;

class Chicken
{
    private string name;
    public string Name { 
        get => name; 
        set => name = string.IsNullOrEmpty(value) ? "No Name" : value; }
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
    private int eggs;
    public int Eggs
    {
        get => eggs;
        set => eggs = Mathf.Max(0, value);
    }

    // Feed, Sleep
    int hungerWhenFed = -20;
    
    int hugerWhenSlept = 10;
    int happinessWhenSlept = 10;


    public Chicken(string newName, int newHunger, int newHappiness, int newEggs)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Eggs = newEggs;
    }

    public void GetStats()
    {
        Debug.Log($"Chicken Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {eggs}");
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name}: Cluck Cluck!");
    }

    public void Feed()
    {
        AdjustHunger(hungerWhenFed);
        Debug.Log($"{Name} is fed. Hunger decreased by { -hungerWhenFed }.");
    }

    public void Sleep()
    {
        AdjustHunger(hugerWhenSlept);
        AdjustHappiness(happinessWhenSlept);
        Debug.Log($"{Name} is sleeping. Hunger increased by {hugerWhenSlept}, Happiness increased by {happinessWhenSlept}.");
    }

    /*public void Play()
    {
    }
    public void LayEgg()
    {
    }*/
}
