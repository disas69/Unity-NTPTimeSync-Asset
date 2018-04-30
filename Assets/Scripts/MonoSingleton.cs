using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T) FindObjectOfType(typeof(T));

                if (_instance == null)
                {
                    _instance = new GameObject().AddComponent<T>();
                    _instance.gameObject.name = typeof(T).Name;
                }

                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
    }
}