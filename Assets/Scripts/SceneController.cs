using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button start;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start.onClick.AddListener(GenericManager.Instance.StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
