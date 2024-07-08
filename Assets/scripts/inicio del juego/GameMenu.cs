using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Cargar la escena del juego (aseg�rate de que esta sea la correcta)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void ExitGame()
    {
        // Salir de la aplicaci�n (esto funciona en build, no en el editor)
        Application.Quit();
        Debug.Log("afuera");
    }
}

