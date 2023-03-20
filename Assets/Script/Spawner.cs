using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objetos;
    public float actualTime, totalTime = 2f;

    // Update is called once per frame
    void Update()
    {
        if(actualTime < totalTime)
        {
            actualTime += 1 * Time.deltaTime;
            if(actualTime > totalTime)
            {
                actualTime = Random.Range(0.2f,0.8f);
                // spawnear fruta
                Instantiate(objetos[Random.Range(0, objetos.Length)], 
                    transform.position, Quaternion.identity);
            }
        }
    }
}
