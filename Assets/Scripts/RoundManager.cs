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
}
