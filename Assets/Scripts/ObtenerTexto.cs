using UnityEngine;
using UnityEngine.UI;

public class ObtenerTexto : MonoBehaviour
{
    [SerializeField]
    private string key;

    private void Awake()
    {
        // Obtenemos el TextItem de List<TextItem> que se parsea del JSON
        TextItem textItem = GameManagerSingleton.Instance.GetText(this.key);

        // Si se ha encontrado texto para la clave indicada la mostramos
        if (textItem != null)
        {
            GetComponent<Text>().text = textItem.Value;
        }
    }
}
