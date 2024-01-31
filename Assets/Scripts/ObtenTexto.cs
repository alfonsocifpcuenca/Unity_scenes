using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenTexto : MonoBehaviour
{
    [SerializeField]
    private string key;

    private void Awake()
    {
        TextItem myText = GameManagerSingleton.Instance.GetText(this.key);
        
        GetComponent<Text>().text = myText.value;
    }
}
