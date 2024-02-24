using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMyGame : MonoBehaviour
{
    public TextMeshProUGUI gameOverTextScene1;
    public static TextMeshProUGUI gameOverTextScene;
    public Button restartButton1;
    public static Button restartButton;
    public TextMeshProUGUI PuntajeTiempo;

    private void Update()
    {
        UpdateTiempo();
    }
    private void Awake()
    {
        gameOverTextScene = gameOverTextScene1;
        restartButton = restartButton1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    void UpdateTiempo()
    {
        PuntajeTiempo.SetText("Tiempo: " + Time.deltaTime);
    }
}
