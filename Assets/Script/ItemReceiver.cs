using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemReceiver : MonoBehaviour
{
    public GameObject itemNeeded;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.GetComponent<Inventory>().inventory.Contains(itemNeeded))
            {
                other.GetComponent<Inventory>().RemoveObjectFromInventory(itemNeeded);
                gameObject.SetActive(false);
            }
            
        }
    }
}
