using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    void Start()
    {
        // Ocultar el mensaje de Game Over al inicio
        gameOverUI.SetActive(false);
    }

    // M�todo para mostrar el mensaje de Game Over
    public void ShowGameOver()
    {
        gameOverUI.SetActive(true);
    }

    // M�todo para reiniciar la escena cuando se presiona Enter
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartScene();
        }
    }

    // M�todo para reiniciar la escena
    public void RestartScene()
    {
        // Cargar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
