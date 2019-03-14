using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPosition;

    public float cameraSafeOffsetSizeX = 5.0f;
    public float cameraSafeOffsetSizeY = 5.0f;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPosition != null)
        {
            if(playerPosition.position.x < transform.position.x - (0.5f * cameraSafeOffsetSizeX))
            {
                // Start following the player
                transform.position = new Vector3(
                    playerPosition.position.x + (0.5f * cameraSafeOffsetSizeX), // X
                    transform.position.y,                                       // Y
                    transform.position.z);                                      // Z
            }
            else if(playerPosition.position.x > transform.position.x + (0.5f * cameraSafeOffsetSizeX))
            {
                transform.position = new Vector3(
                    playerPosition.position.x - (0.5f * cameraSafeOffsetSizeX), // X
                    transform.position.y,                                       // Y
                    transform.position.z);                                      // Z
            }
        }
    }

    void OnDrawGizmos()
    {
        Vector3 thresholdL = new Vector3(
            transform.position.x - (0.5f * cameraSafeOffsetSizeX),
            transform.position.y,
            transform.position.z);

        Vector3 thresholdR = new Vector3(
            transform.position.x + (0.5f * cameraSafeOffsetSizeX),
            transform.position.y,
            transform.position.z);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(
            new Vector3(thresholdL.x, thresholdL.y - 10, thresholdL.z),
            new Vector3(thresholdL.x, thresholdL.y + 10, thresholdL.z));
        Gizmos.DrawLine(
            new Vector3(thresholdR.x, thresholdR.y - 10, thresholdR.z),
            new Vector3(thresholdR.x, thresholdR.y + 10, thresholdR.z));
    }
}
