using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMenu : MonoBehaviour
{
    public static bool isGameActive = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarJuego()
    {
        isGameActive = true;
        SceneManager.LoadScene(1);
    }

    public static void GameOver()
    {
       isGameActive = false;
       SceneMyGame.gameOverTextScene.gameObject.SetActive(true);
       SceneMyGame.restartButton.gameObject.SetActive(true);
    }
}
