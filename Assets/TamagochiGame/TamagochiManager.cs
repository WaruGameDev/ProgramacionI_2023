using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum STATS
{
    HUNGRY, CLEAN, HAPPY
}

public class TamagochiManager : MonoBehaviour
{
    public Image barHungry, barClean, barHapiness;
    public float hungry;
    public float clean;
    public float happiness;
    public float happinessThreshold;
    public float cleanThreshold;
    public float hungryThreshold;

    public static TamagochiManager instance;
    private void Awake()
    {
        instance= this;
    }
    private void Feed(float amount)
    {
        hungry+= amount;
        if(hungry > hungryThreshold) 
        { 
            hungry = hungryThreshold;
        }
    }
    private void CleanPet(float amount)
    {
        clean+= amount;
        if(clean > cleanThreshold)
        {
            clean = cleanThreshold;
        }
    }
    private void GiveHapy(float amount)
    {
        happiness += amount;
        if(happiness > happinessThreshold)
        {
            happiness = happinessThreshold;
        }
    }
    public void ChangeStat(float amount, STATS statToAdd)
    {
        switch(statToAdd)
        {
            case STATS.HUNGRY:
                Feed(amount);
                break;
            case STATS.CLEAN:
                CleanPet(amount);
                break;
            case STATS.HAPPY:
                GiveHapy(amount);
                break;
        }
    }
    private void Update()
    {
        barHungry.fillAmount = hungry / hungryThreshold;
        barClean.fillAmount = clean / cleanThreshold;
        barHapiness.fillAmount = happiness / happinessThreshold;
    }
}
