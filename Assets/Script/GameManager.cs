using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int puntaje;

    private void Awake()
    {
        instance= this;
    }
    public void AddPuntaje(int ptj)
    {
        puntaje += ptj;
    }
}
