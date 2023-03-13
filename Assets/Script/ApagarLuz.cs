using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarLuz : MonoBehaviour
{
    public Light iluminacion;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (iluminacion.intensity >0) 
            {
                iluminacion.intensity = 0;
            }
            else if(iluminacion.intensity<=0)
            {
                iluminacion.intensity = 1;
            }
            
        }
    }
}
