using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed = 0.05f;

    void Start()
    {
        InvokeRepeating("MoveBG", 0.5f, 0.5f);
    }

    void MoveBG()
    {
        GetComponent<Renderer>().material.mainTextureOffset =
            new Vector2(GetComponent<Renderer>().material.mainTextureOffset.x + scrollSpeed, 0);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * scrollSpeed, 0.0f);
    }
    */
}
