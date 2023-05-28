using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;

public class BillboardObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 camerita = Camera.main.transform.eulerAngles;
        
        
        transform.eulerAngles = new Vector3(camerita.x, camerita.y, 0);
    }
}
