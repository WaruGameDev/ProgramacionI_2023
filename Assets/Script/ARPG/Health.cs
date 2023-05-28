using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Feedback feedback;
    public Image bar;
    public Animator anim;

    private void Start()
    {
        health = maxHealth;
        bar.fillAmount = health / maxHealth;
    }
    public void TakeDamage(float damage)
    {
        
       
        health-=damage;
        if(health <= 0)
        {
            Die();
        }
        else
        {
            feedback.FeedbackScale();
        }
        bar.fillAmount = health / maxHealth;
    }
    private void Die()
    {
        anim.SetBool("Die",true);
        Destroy(gameObject,5);
    }
}
