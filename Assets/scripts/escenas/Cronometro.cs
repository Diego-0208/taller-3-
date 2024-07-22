using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Cronometro : MonoBehaviour
{
    public float tiempoInicial = 60f; // Tiempo inicial en segundos
    private float tiempoRestante;
    public TextMeshProUGUI textoCronometro;
    public GameObject enemigo; // Referencia al objeto enemigo
    public UnityEvent cronometroend;
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
            cronometroend.Invoke();
            
        }
    }

    void ActualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);

        if (tiempoRestante <= 0)
        {
            textoCronometro.text = ""; // Si el tiempo restante es 0 o menos, oculta el texto
        }
        else
        {
            textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
    }

}
