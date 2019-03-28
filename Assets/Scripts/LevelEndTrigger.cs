using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    private GameController gCont;

    void Start()
    {
        gCont = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Reserved by Unity to detect when an object enters a collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // Show my UI panel by calling a GameController method
            gCont.LevelEnd();
            
        }
    }
}
