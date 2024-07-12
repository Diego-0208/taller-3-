using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenacreditos : MonoBehaviour
{
    public string nombreDeEscena; // Nombre de la escena a la que quieres cambiar

    void Update()
    {
        // Verifica si se presiona la tecla Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Carga la escena con el nombre especificado
            SceneManager.LoadScene(nombreDeEscena);
        }
    }
}
