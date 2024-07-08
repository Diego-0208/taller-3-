using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class KillZone : MonoBehaviour
{
    [SerializeField] float delay = 0f;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.Log("GameManager not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.PerderVida(1);
            StartCoroutine(RespawnPlayer(collision.gameObject));
        }
    }

    private IEnumerator RespawnPlayer(GameObject player)
    {
        // Optional: add a delay before respawning
        yield return new WaitForSeconds(delay);

        Player playerScript = player.GetComponent<Player>();
        if (playerScript != null)
        {
            playerScript.Respawn();
        }
        else
        {
            Debug.LogError("Player script not found on the player object!");
        }
    }
}
*/