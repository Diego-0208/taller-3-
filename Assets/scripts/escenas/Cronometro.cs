using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float tiempoInicial = 60f; // Tiempo inicial en segundos
    private float tiempoRestante;
    public TextMeshProUGUI textoCronometro;
    public GameObject enemigo; // Referencia al objeto enemigo

    void Start()
    {
        tiempoRestante = tiempoInicial;
    }

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            ActualizarTextoCronometro();
        }
        else
        {
            // El tiempo ha terminado
            tiempoRestante = 0;
            // Desactivar al enemigo
            if (enemigo != null)
            {
                enemigo.SetActive(false); // Desactivar el enemigo
            }
            // Aqu� puedes agregar m�s l�gica para lo que ocurre cuando el tiempo se acaba
        }
    }

    void ActualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
