using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // References to the current instances
    Chicken currentChicken;
    Cow currentCow;
    Whale currentWhale;

    // Reference to the base class
    Animal currentAnimal;
    public List<Animal> AnimalPrefab;
    public List<Animal> animals = new List<Animal>();

    void Start()
    {
        // Instantiate animals from prefabs and initialize them
        currentChicken = (Chicken)Instantiate(AnimalPrefab[0]);
        currentChicken.Init("KFC", 10, 10, 0);
        animals.Add(currentChicken);

        currentCow = (Cow)Instantiate(AnimalPrefab[1]);
        currentCow.Init("Beef", 20, 20, 0);
        animals.Add(currentCow);

        currentWhale = (Whale)Instantiate(AnimalPrefab[2]);
        currentWhale.Init("Big Blue", 15, 5);
        animals.Add(currentWhale);

        // Log initial
        Debug.Log($"FarmSim Game! \nWe have {animals.Count} animals!");
        Debug.Log("Animal List / Stats:");

        animals.ForEach(animal => animal.GetStats());

        Debug.Log("-------------------------------------------------");

        animals.ForEach(animal => {
            animal.MakeSound();
            animal.Feed(2);
        });

        Debug.Log("-------------------------------------------------");

        currentChicken.Feed("corn", 4);
        currentChicken.Sleep();
        currentChicken.GetStats();

        currentCow.Feed("Hay", 6);
        currentCow.Moo();

        currentWhale.Feed("plankton", 999);

        Debug.Log("-------------------------------------------------");

        animals.ForEach(animal => animal.GetStats());
    }
}