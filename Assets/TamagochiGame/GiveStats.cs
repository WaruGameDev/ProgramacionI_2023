using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveStats : MonoBehaviour
{
    public STATS stat;
    public float amount;

    public void Give()
    {
        TamagochiManager.instance.ChangeStat(amount, stat);
    }    
}
