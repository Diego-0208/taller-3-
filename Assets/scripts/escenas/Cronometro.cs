using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float tiempoInicial = 60f; // Tiempo inicial en segundos
    private float tiempoRestante;
    public TextMeshProUGUI textoCronometro;

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
            // Aquí puedes añadir lógica para lo que ocurre cuando el tiempo se acaba
        }
    }

    void ActualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
