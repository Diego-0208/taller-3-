using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerhit : MonoBehaviour
{   public bool isbala;
    public string reiniciarelnivel;
    private PlayerController playerController;
    private void Start()
    {
        playerController =FindAnyObjectByType<PlayerController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isbala && collision.gameObject.CompareTag("Player")&&!playerController.isInvisible)
        {
            SceneManager.LoadScene(reiniciarelnivel);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isbala && other.CompareTag("Player") && !playerController.isInvisible)  
        {
            SceneManager.LoadScene(reiniciarelnivel);

        }


    }
}
