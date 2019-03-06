using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerPosition;
    public Transform moveThreshold;

    // Update is called once per frame
    void Update()
    {
        if(playerPosition.position.x > moveThreshold.position.x)
        {
            // Move the camera with the player
            transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(moveThreshold.position, new Vector2(moveThreshold.position.x, moveThreshold.position.y + 10));
        Gizmos.DrawLine(moveThreshold.position, new Vector2(moveThreshold.position.x, moveThreshold.position.y - 10));
    }
}
