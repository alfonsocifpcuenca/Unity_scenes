using UnityEngine;

public class btnRestarVida : MonoBehaviour
{
    public void RestarVida()
    {
        GameManagerSingleton.Instance.Vidas--;
        Debug.Log("Quedan " + GameManagerSingleton.Instance.Vidas + " vidas");
    }
}
