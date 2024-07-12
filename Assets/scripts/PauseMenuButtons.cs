using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        bool isPaused = !pauseMenu.activeInHierarchy;
        pauseMenu.SetActive(isPaused);

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        // Pausar el juego
        Time.timeScale = 0f;
        pauseMenu.SetActive(true); // Activar el men� de pausa
    }

    public void ResumeGame()
    {
        // Reanudar el juego
        Time.timeScale = 1f;
        pauseMenu.SetActive(false); // Desactivar el men� de pausa
    }

    public void RestartGame()
    {
        // Reiniciar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // Asegurar que el tiempo se reanude al reiniciar la escena
    }

    public void ExitGame()
    {
        // Salir del juego (funciona solo en builds, no en el editor de Unity)
        Application.Quit();
    }
}
