using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Obtener el componente PlayerHealth del jugador
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // Restaurar toda la vida del jugador
                playerHealth.RestoreHealth();

                Collect();

                // Destruir el objeto "GreenHeart" después de ser recogido
                Destroy(gameObject);
            }
        }
    }
    void Collect()
    {
        gameController.AddScore(50);
        Destroy(gameObject);
    }
}
