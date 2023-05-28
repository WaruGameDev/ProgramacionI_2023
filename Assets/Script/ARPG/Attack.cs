using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    public string tagToAttack = "Enemy";
    public Health targetHealth;
    public float damage = 10;
    public PlayerMovement pMov;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tagToAttack) && targetHealth == null)
        {
            targetHealth = other.GetComponent<Health>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagToAttack) && targetHealth != null)
        {
            targetHealth = null;
        }
    }
    public void AttackMelee()
    {
        if(targetHealth != null) 
        {
            targetHealth.TakeDamage(damage);
            if (targetHealth.health <= 0)
            {
                pMov.state = PLAYER_STATES.IDLE;
            }
        }
    }
    public void CheckKill()
    {
        if (targetHealth == null)
        {
            // hacer que el personaje deje de atacar
            pMov.state = PLAYER_STATES.IDLE;
        }
    }


}
