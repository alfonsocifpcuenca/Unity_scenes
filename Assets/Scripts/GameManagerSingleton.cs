using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSingleton : MonoBehaviour
{
    /*
     * Variable privada que contendr� la instancia del Game Manager (static)
     * */
    private static GameManagerSingleton instance;

    /*
     * Variable p�blica que devolver� el contenido de instacia, si existe o 
     * crear� el Game Manager -> SetupInstance
     * */
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

    /// <summary>
    /// M�todo para inciar el Game Manager
    /// </summary>
    private static void SetupInstance()
    {
        /*
         * Nos aseguramos, por precauci�n, que el objeto no existe, de este modo tenemos claro que unicamente
         * va a haber un GameManagerSinglenton en nuestra escena.
         * */
        instance = FindObjectOfType<GameManagerSingleton>();
        if (instance == null)
        {
            /*
             * Creamos un objeto en la escena y a�adimos el propio componente GameManagerSingleton, de este modo 
             * tenemos acceso a todas las herramientas de MonoBehaviour
             * */
            GameObject gameObj = new GameObject();
            gameObj.name = "GameManagerSingleton";
            instance = gameObj.AddComponent<GameManagerSingleton>();

            /*
             * Marcamos el objeto para que no se destruya a lo largo de la aplicaci�n
             * */
            DontDestroyOnLoad(gameObj);
        }
    }

    /*
     * Variable p�blica con el contador de vidas, podremos acceder a ella desde cualquier
     * sitio de la aplicaci�n mediante:
     * 
     * GameManagerSingleton.Instace.Vidas
     * */
    public int Vidas = 3;
}
