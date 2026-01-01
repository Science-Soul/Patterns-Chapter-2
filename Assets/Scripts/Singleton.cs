using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<T>();

                if (_instance == null)
                {
                    var singletonGO = new GameObject();
                    singletonGO.name = typeof(T).Name + " Persists";
                    _instance = singletonGO.AddComponent<T>();

                    DontDestroyOnLoad(singletonGO);
                    Debug.Log("New instance created!");
                }

            }
            return _instance;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
