using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerMenu : MonoBehaviour
{
    public static bool isGameActive = false;
    public Button hardButton;
    public Button easyButton;
    public TextMeshProUGUI mejorPuntaje;


    private void Start()
    {
        ActualizacionPuntaje();
    }

    private void Awake()
    {
        SceneMyGame.isSpawnManagerHardActive = false;
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

    public void HardMode()
    {
        SceneMyGame.isSpawnManagerHardActive = true;
        hardButton.gameObject.SetActive(false);
        easyButton.gameObject.SetActive(true);
        
    }

    public void EasyMode()
    {
       SceneMyGame.isSpawnManagerHardActive = false;
       easyButton.gameObject.SetActive(false);
       hardButton.gameObject.SetActive(true);
       
    }

    public void ActualizacionPuntaje()
    {
        mejorPuntaje.text = "Mejor Tiempo: " + AlmacenamientoDatos.instance.maximoPuntaje.ToString("f0") + " segundos";
    }
}
