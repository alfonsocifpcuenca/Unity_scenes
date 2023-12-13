using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnRestarVida : MonoBehaviour
{
    public void RestarVida()
    {
        var gameManagerScript = GameObject.Find("GameManager")?.GetComponent<GameManaer>();

        if (gameManagerScript != null )
        {
            gameManagerScript.QuitarVida();
        }
    }
}
