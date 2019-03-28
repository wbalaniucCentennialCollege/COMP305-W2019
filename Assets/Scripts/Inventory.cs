using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject itemFeedbackPref;

    private GameController gCont;

    void Start()
    {
        gCont = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if 'other' is a tagged an item
        if(other.CompareTag("Item"))
        {
            // Pick up the item
            // cherryCounter++;
            gCont.PickUpItem();
            // Instantiate the item feedback object
            Instantiate(itemFeedbackPref, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
