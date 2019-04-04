using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameController : MonoBehaviour
{
    [Header("User Interface")]
    public UI_CherryCounter ui_cherryCounter;
    public GameObject ui_EndLevelPanel;

    [Header("Audio")]
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    private int itemCounter = 0;    // How many items I have picked up
    private int totalItemCount = 0; // How many items are in my level

    // Start is called before the first frame update
    void Start()
    {
        // GameObject.Find("UI_CherryCounter").GetComponent<UI_CherryCounter>();
        totalItemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        ui_cherryCounter.UpdateUI(itemCounter, totalItemCount);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) // Pause or unpause
        {
            // Set my audio snapshot to the pause or unpause snapshot
            // Pause my game.
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
            
            if(Time.timeScale == 0) // Paused
            {
                paused.TransitionTo(0.01f);
            }
            else // Unpaused
            {
                unpaused.TransitionTo(0.01f);
            }
        }
    }

    // Called when an item is picked up
    public void PickUpItem()
    {
        ui_cherryCounter.UpdateUI(++itemCounter, totalItemCount);
    }

    public void LevelEnd()
    {
        ui_EndLevelPanel.SetActive(true);
        ui_EndLevelPanel.GetComponentInChildren<UI_CherryCounter>().UpdateUI(itemCounter, totalItemCount);
    }
}
