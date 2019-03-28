using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UI_CherryCounter ui_cherryCounter;

    private int itemCounter = 0;    // How many items I have picked up
    private int totalItemCount = 0; // How many items are in my level

    // Start is called before the first frame update
    void Start()
    {
        // GameObject.Find("UI_CherryCounter").GetComponent<UI_CherryCounter>();
        totalItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        ui_cherryCounter.UpdateUI(itemCounter, totalItemCount);
    }

    // Called when an item is picked up
    public void PickUpItem()
    {
        ui_cherryCounter.UpdateUI(++itemCounter, totalItemCount);
    }
}
