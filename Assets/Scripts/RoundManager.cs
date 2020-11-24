using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public Text RoundText;
    public static int RoundCount = 0;

    void Awake()
    {
        RoundCount += 1;
        RoundText.text = "Round: " + RoundCount;
    }

    void OnDestroy()
    {
        //GameObject Player = GameObject.Find("Player");
        //Eat eat = Player.GetComponent<Eat>();
        //if (eat.FoodEaten >= Eat.FoodNeeded)
        {
            //RoundCount += 1;
        }
    }
    
   
}
