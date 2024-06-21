using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    [SerializeField] float delay;
    private GameManager gameManager;
    private void Start()
    {
      gameManager = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.PerderVida(3);
            Destroy(collision.gameObject, delay);
        }
        
    }
}
