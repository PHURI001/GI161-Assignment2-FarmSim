using UnityEngine;

public class Whale : Animal
{
    // Whale-specific properties or methods can be added here
    public new void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
    }

    // Override MakeSound method
    public override void MakeSound()
    {
        Debug.Log($"{Name}: Whoooaaaa… oooooooo… wooooaaah…");
    }
}