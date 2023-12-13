using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSingleton : MonoBehaviour
{
    private static GameManagerSingleton instance;
    public static GameManagerSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                SetupInstance();
            }
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindObjectOfType<GameManagerSingleton>();
        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "GameManagerSingleton";
            instance = gameObj.AddComponent<GameManagerSingleton>();


            DontDestroyOnLoad(gameObj);
        }
    }

    public int Vidas = 3;
}
