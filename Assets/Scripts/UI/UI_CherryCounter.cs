using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CherryCounter : MonoBehaviour
{
    private Text cherryText;

    // Start is called before the first frame update
    void Awake()
    {
        cherryText = GetComponent<Text>();
    }

    public void UpdateUI(int qty, int maxItemInLevel)
    {
        cherryText.text = qty + " / " + maxItemInLevel;
    }
}
