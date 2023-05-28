using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyARPG : MonoBehaviour
{
    public PLAYER_STATES states;
    public Health playerHealth;
    public Animator anim;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth = other.GetComponent<Health>();
            states = PLAYER_STATES.ATTACKING;
            player = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth = null;
            states = PLAYER_STATES.IDLE;
           
        }
    }

    private void Update()
    {
        anim.SetBool("Attack", states == PLAYER_STATES.ATTACKING);
        if (states == PLAYER_STATES.ATTACKING)
        {
            Vector3 directionToTarget = player.position - transform.position;
            directionToTarget.y = 0;
            Quaternion rotation = Quaternion.LookRotation((directionToTarget));

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*2);
        }
    }

    public void Attack()
    {
        playerHealth.TakeDamage(10);
    }
}
