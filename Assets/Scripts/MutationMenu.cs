using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutationMenu : MonoBehaviour
{
    [SerializeField]
    private Text healthText;

    [SerializeField]
    private Text speedText;

    [SerializeField]
    private Text healthRegenText;

    [SerializeField]
    private float healthMultiplier = 1.1f;

    [SerializeField]
    private float speedMultiplier = 1f;

    [SerializeField]
    private float healthRegenRateMultiplier = 10f;

    //private PlayerStats stats;

    void Start()
    {
        //stats = PlayerStats.instance;

        UpdateValues();
    }

    void UpdateValues()
    {
        healthText.text = "Health: " + PlayerStats.maxHealth.ToString();
        speedText.text = "Speed: " + PlayerStats.movementSpeed.ToString();
        healthRegenText.text = "Health regen: " + PlayerStats.healthRegenRate.ToString();
    }

    public void UpgradeHealth()
    {
        PlayerStats.maxHealth = (int)(PlayerStats.maxHealth * healthMultiplier);
        UpdateValues();
    }
    
    public void UpgradeSpeed()
    {
        PlayerStats.movementSpeed = (int)(PlayerStats.movementSpeed + speedMultiplier);
        UpdateValues();
    }
    
    public void UpgradeHealthRegenRate()
    {
        PlayerStats.healthRegenRate = (int)(PlayerStats.healthRegenRate + healthRegenRateMultiplier);
        UpdateValues();
    }
}
