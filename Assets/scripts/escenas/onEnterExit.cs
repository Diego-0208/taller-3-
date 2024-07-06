using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onEnterExit : MonoBehaviour
{
    public string filterTag;
    public UnityEvent onEnter;
    public UnityEvent onExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(filterTag))
        {
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(filterTag))
        {
            onEnter.Invoke();
        }
    }
}
