using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmacenamientoDatos : MonoBehaviour
{
    public static AlmacenamientoDatos instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this; 
        DontDestroyOnLoad(gameObject);
    }
}
