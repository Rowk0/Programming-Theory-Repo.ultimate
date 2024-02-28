using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AlmacenamientoDatos : MonoBehaviour
{
    public static AlmacenamientoDatos instance;

    public float maximoPuntaje;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this; 
        DontDestroyOnLoad(gameObject);

        CargarPuntajeMayor();
    }

    [Serializable]
    class SaveData
    {
        public float mayorPuntaje;
    }

    public void SavePuntajeMayor()
    {
        SaveData data = new SaveData();
        data.mayorPuntaje = maximoPuntaje;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void CargarPuntajeMayor()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            maximoPuntaje = data.mayorPuntaje;
        }
    }
}
