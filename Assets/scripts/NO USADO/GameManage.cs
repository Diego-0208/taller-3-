using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
/*
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;

    public GameObject canvasGameover;

    public int PuntosTotales { get; private set; }

    private int vidas = 3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Debug.Log("Cuidado! Mas de un GameManager en escena.");
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (hud == null)
        {
            hud = FindAnyObjectByType< HUD >();
            canvasGameover = FindAnyObjectByType<GameOver>().gameObject;
        }
    }
    public void SumarPuntos(int puntosASumar)
    {
        PuntosTotales += puntosASumar;
        hud.ActualizarPuntos(PuntosTotales);
    }

    public void PerderVida(int daño)
    {
        vidas -= daño;

        if (vidas == 0)
        {
            canvasGameover.SetActive(true);
            vidas = 3;
        }

        hud.DesactivarVida(vidas);
    }

    public bool RecuperarVida()
    {
        if (vidas == 3)
        {
            return false;
        }

        hud.ActivarVida(vidas);
        vidas += 1;
        return true;
    }
}
*/