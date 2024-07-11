using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerhit : MonoBehaviour
{   public bool isbala;
    public string reiniciarelnivel;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isbala && collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(reiniciarelnivel);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isbala && other.CompareTag("Player")) 
        {
            SceneManager.LoadScene(reiniciarelnivel);

        }


    }
}
