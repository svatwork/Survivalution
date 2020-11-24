using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public string Tag;
    public Text FoodText;
    public float Increase;

    public int FoodEaten = 0;
    public static int FoodNeeded = 10;

    void Start()
    {
        FoodText.text = "Food: " + FoodEaten + "/" + FoodNeeded;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == Tag)
        {
            //transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);

            FoodEaten += 1;
            FoodText.text = "Food: " + FoodEaten + "/" + FoodNeeded;
        }
    }
}
