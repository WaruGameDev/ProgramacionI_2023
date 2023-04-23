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
    public ParticleSystem sickParticles;
    public Animator anim;

    public static TamagochiManager instance;
    private void Awake()
    {
        instance= this;
    }
    private void Feed(float amount)
    {
        hungry+= amount;
        anim.SetBool("Comiendo", true);
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
        barHungry.fillAmount = GetHungry();
        barClean.fillAmount = GetClean();
        barHapiness.fillAmount = GetHappy();
        if (GetClean() < 0.25f)
        {
            if(sickParticles.isStopped)
            {
                sickParticles.Play();
            }
           
        }
        else if(!sickParticles.isStopped)
        {
            sickParticles.Stop();
        }
        if (GetClean() < .25f || GetHungry() < .25f || GetHappy() < .25f)
        {
            anim.SetBool("Triste", true);
        }
        else
        {
            anim.SetBool("Triste", false);
        }
        if (GetClean() > .75f || GetHungry() > .75f || GetHappy() > .75f)
        {
            anim.SetBool("Contento", true);
        }
        else
        {
            anim.SetBool("Contento", false);
        }
    }
    public float GetHungry()
    {
        return hungry/hungryThreshold;
    }
    public float GetClean()
    {
        return clean/cleanThreshold;
    }
    public float GetHappy()
    {
        return happiness/happinessThreshold;
    }
    public void SetComiendo()
    {
        anim.SetBool("Comiendo", false);
    }
}
