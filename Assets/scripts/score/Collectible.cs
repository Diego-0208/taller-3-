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
   
    void Collect()
    {
        gameController.AddScore(50);
        Destroy(gameObject);
    }
}
