using UnityEngine;

public class MovementBasket : MonoBehaviour
{
    public float speedBasket = 20;
    public float min = -8, max = 8;
    public Transform canasto;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            canasto.Translate(Vector3.right* speedBasket * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            canasto.Translate(Vector3.left * speedBasket * Time.deltaTime);
        }
        Vector3 pos = canasto.position;
        pos.x = Mathf.Clamp(pos.x, min, max);
        canasto.position = pos;
    }
}
