using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public bool isPlayer = true;
    public AudioSource sfx;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fruta")  )
        {
            if(isPlayer)
            {
                FrutasDetails fd = other.GetComponent<FrutasDetails>();
                GameManager.instance.AddPuntaje(fd.scoreToAdd);
                sfx.clip = fd.sfxClip;
                sfx.Play();
            }            
            Destroy(other.gameObject);
        }
    }
}
