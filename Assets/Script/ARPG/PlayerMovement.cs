using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum PLAYER_STATES
{
    IDLE, RUNNING, RUNNING_TO_ATTACK, ATTACKING
}
public class PlayerMovement : MonoBehaviour
{
    //public Transform target;
    public NavMeshAgent theAgent;
    public Animator anim;
    public LayerMask groundMask, enemyMask;
    public PLAYER_STATES state;

    private bool moving;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Create a ray from the mouse cursor on screen in the direction of the camera
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Perform the raycast
            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "Ground":
                        state = PLAYER_STATES.RUNNING;
                        theAgent.SetDestination(hit.point);
                        moving = true;
                        break;
                    case  "Enemy":
                        state = PLAYER_STATES.RUNNING_TO_ATTACK;
                        theAgent.SetDestination(hit.transform.position);
                        moving = true;
                        break;
                        
                }
            }
            
        }
        float playerSpeed = theAgent.velocity.magnitude / theAgent.speed;
        anim.SetFloat("mov", playerSpeed);
        anim.SetBool("attack", state == PLAYER_STATES.ATTACKING);
        if (theAgent.remainingDistance <= theAgent.stoppingDistance && state == PLAYER_STATES.RUNNING && moving )
        {
            state = PLAYER_STATES.IDLE;
            moving = false;
        }
        if (theAgent.remainingDistance <= theAgent.stoppingDistance  && state == PLAYER_STATES.RUNNING_TO_ATTACK && moving)
        {
            moving = false;
            state = PLAYER_STATES.ATTACKING;
        }
    }
}
