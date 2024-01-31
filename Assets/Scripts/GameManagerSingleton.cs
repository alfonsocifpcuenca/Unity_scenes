using System.Linq;
using UnityEngine;

public class GameManagerSingleton : MonoBehaviour
{
    /*
     * Variable privada que contendrá la instancia del Game Manager (static)
     * */
    private static GameManagerSingleton instance;

    /*
     * Variable pública que devolverá el contenido de instacia, si existe o 
     * creará el Game Manager -> SetupInstance
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
    /// Método para inciar el Game Manager
    /// </summary>
    private static void SetupInstance()
    {
        /*
         * Nos aseguramos, por precaución, que el objeto no existe, de este modo tenemos claro que unicamente
         * va a haber un GameManagerSinglenton en nuestra escena.
         * */
        instance = FindObjectOfType<GameManagerSingleton>();
        if (instance == null)
        {
            /*
             * Creamos un objeto en la escena y añadimos el propio componente GameManagerSingleton, de este modo 
             * tenemos acceso a todas las herramientas de MonoBehaviour
             * */
            GameObject gameObj = new GameObject();
            gameObj.name = "GameManagerSingleton";
            instance = gameObj.AddComponent<GameManagerSingleton>();

            /*
             * Marcamos el objeto para que no se destruya a lo largo de la aplicación
             * */
            DontDestroyOnLoad(gameObj);
        }
    }

    /*
     * Variable pública con el contador de vidas, podremos acceder a ella desde cualquier
     * sitio de la aplicación mediante:
     * 
     * GameManagerSingleton.Instace.Vidas
     * */
    public int Vidas = 3;


    /*
     * Método para devolver el valor en función de la clave enviada
     * obteniendo los datos de es.json
     * */

    private TextResources texts;
    public TextItem GetText(string key)
    {
        // Si no tenemos los textos en memoria los cargamos del JSON
        if (this.texts == null)
        {
            // Leemos el JSON del directorio /Resources
            TextAsset json = Resources.Load<TextAsset>("es");
            // Parseamos el JSON con la clase Texts
            this.texts = JsonUtility.FromJson<TextResources>(json.ToString());
        }

        TextItem item = texts.Items.Where(x => x.Key == key).FirstOrDefault();
        return item;
    }
}
