using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMyGame : MonoBehaviour
{
    public GameObject skydome;
    public GameObject spawnManager;
    public GameObject spawnManagerHard;
    public TextMeshProUGUI gameOverTextScene1;
    public static TextMeshProUGUI gameOverTextScene;
    public Button restartButton1;
    public static Button restartButton;
    public static bool isSpawnManagerHardActive = false;


    //timer
    public TextMeshProUGUI PuntajeTiempo;
    public float timer = 0;

    private void Update()
    {
        UpdateTiempo();
        movimientoSky();
        GuardarMaximoPuntaje();

    }
    private void Awake()
    {
        gameOverTextScene = gameOverTextScene1;
        restartButton = restartButton1;

        if(isSpawnManagerHardActive == true)
        {
            spawnManagerHard.SetActive(true);
            spawnManager.SetActive(false);
        }
        else
        {
            spawnManagerHard.SetActive(false);
            spawnManager.SetActive(true);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    void UpdateTiempo()
    {
        if (SceneManagerMenu.isGameActive == true)
        {
            timer += Time.deltaTime;
            PuntajeTiempo.text = "Tiempo: " + timer.ToString("f0");
        }
    }

    void movimientoSky()
    {
        skydome.transform.Rotate(Vector3.up * Time.deltaTime * 10);
    }

    public void GuardarMaximoPuntaje()
    {
        if (timer > AlmacenamientoDatos.instance.maximoPuntaje)
        {
            AlmacenamientoDatos.instance.maximoPuntaje = timer;
            AlmacenamientoDatos.instance.SavePuntajeMayor();
        }
    }
}
