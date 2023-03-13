using UnityEngine;

public class ExamplesVariables : MonoBehaviour
{
    public float numeroDecimal;
    public string miTexto;
    public bool miBoolean;
    public int miInt;
    public Transform theTransform;
    public ExamplesVariables examples;
    public Rigidbody rb;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(rb.isKinematic)
            {
                rb.isKinematic = false;
            }
            else if(!rb.isKinematic)
            {
                rb.isKinematic = true;
            }
            
        }
    }
}
