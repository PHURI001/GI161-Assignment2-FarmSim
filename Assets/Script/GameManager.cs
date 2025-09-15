using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Chicken chicken = new Chicken("KFC", 20, 20, 0);
        Cow cow = new Cow("Beef", 20, 20, 0);

        string chickenFood = "corn";
        string cowFood = "grass";

        Debug.Log("-------------- Chicken --------------");

        // Chicken actions
        chicken.GetStats();
        chicken.MakeSound();
        chicken.Feed(chickenFood);
        chicken.Sleep();
        chicken.GetStats();

        Debug.Log("-------------- Cow --------------");

        // Cow actions
        cow.GetStats();
        cow.MakeSound();
        cow.Feed(cowFood);
        cow.Moo();
        cow.GetStats();

        Debug.Log("-------------- End --------------");
    }
}
