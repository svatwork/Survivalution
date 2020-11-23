using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public Text RoundText;
    public int RoundCount = 1;

    void OnDestroy()
    {
        GameObject Player = GameObject.Find("Player");
        Eat eat = Player.GetComponent<Eat>();
        if (eat.FoodEaten >= eat.FoodNeeded)
        {
            RoundCount += 1;
            RoundText.text = "Round: " + RoundCount;
        }
    }
    
   
}
