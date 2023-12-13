using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaer : MonoBehaviour
{
    [SerializeField]
    private int vidas;

    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    void Start()
    {
        Debug.Log("Tenemos " + this.vidas + " vidas");
    }

    public void QuitarVida()
    {
        this.vidas--;
        Debug.Log("Nos quedan " + this.vidas + " vidas");
    }

    
}
