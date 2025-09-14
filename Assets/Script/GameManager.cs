using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Chicken chicken = new Chicken("KFC", 20, 20, 0);
        Cow cow = new Cow("Beef", 20, 20, 0);

        Debug.Log("-------------- Chicken --------------");

        chicken.GetStats();
        chicken.MakeSound();
        chicken.Feed();
        chicken.Sleep();
        chicken.GetStats();

        Debug.Log("-------------- Cow --------------");

        cow.GetStats();
        cow.MakeSound();
        cow.Feed();
        cow.Moo();
        cow.GetStats();

        Debug.Log("-------------- End --------------");
    }
}
