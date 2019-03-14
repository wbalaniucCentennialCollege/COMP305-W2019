using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int cherryCounter = 0;
    public GameObject itemFeedbackPref;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if 'other' is a tagged an item
        if(other.CompareTag("Item"))
        {
            // Pick up the item
            cherryCounter++;
            // Instantiate the item feedback object
            Instantiate(itemFeedbackPref, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }

    public void ABC()
    {

    }
}
