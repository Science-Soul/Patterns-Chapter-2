using UnityEngine;

public class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                T[] singletons = Resources.LoadAll<T>("");

                if (singletons == null || singletons.Length < 1)
                {
                    throw new System.Exception("No " + typeof(T).Name + " singleton objects found...");
                }
                else if (singletons.Length > 1)
                {
                    Debug.LogWarning("More than one " + typeof(T).Name + " singleton objects found...");
                }

                _instance = singletons[0];
                Debug.Log(typeof(T).Name + " singleton instance fetched!");
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
