using UnityEngine;
using UnityEngine.SceneManagement;

public class btnCambioEscena : MonoBehaviour
{
    [SerializeField]
    string nextEscene;

    public void loadScene()
    {
        SceneManager.LoadScene(nextEscene);
    }
}
