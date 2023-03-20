using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int puntaje;

    public TextMeshProUGUI textPuntaje;

    private void Awake()
    {
        instance= this;
    }
    // esta función lo que realiza suma puntaje al ser llamada desde otra clase.
    public void AddPuntaje(int ptj)
    {
        puntaje += ptj;
        if(puntaje <= 0)
        {
            puntaje= 0;
        }
    }
    private void Update()
    {
        textPuntaje.text = puntaje.ToString();
    }
}
