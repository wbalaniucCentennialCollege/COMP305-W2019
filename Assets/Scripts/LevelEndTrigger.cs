using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject ui_endLevelPanel;

    // Reserved by Unity to detect when an object enters a collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // Show my UI panel
            ui_endLevelPanel.SetActive(true);
        }
    }
}
