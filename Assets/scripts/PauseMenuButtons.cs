using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public GameObject pauseMenu;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);

            if (pauseMenu.activeInHierarchy)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        // Reanudar el juego
        Time.timeScale = 0f;
        gameObject.transform.parent.gameObject.SetActive(true); // Desactivar el menú de pausa
    }

    public void ResumeGame()
    {
        // Reanudar el juego
        Time.timeScale = 1f;
        gameObject.transform.parent.gameObject.SetActive(false); // Desactivar el menú de pausa
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
