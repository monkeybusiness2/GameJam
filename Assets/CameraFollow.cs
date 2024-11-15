using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign the player in the Inspector
    public float smoothspd = 1.2f; // Adjust this to control smoothness
    private Vector2 offset; // Offset for camera position

    void Start()
    {
        offset = transform.position - player.position; // Calculate initial offset based on start position
    }

    void Update()
    {
        if (player != null)
        {
            // Target position based on player's position plus offset
            Vector2 targetPosition = (Vector2)player.position + offset;

            // Smoothly transition to target position
            Vector2 smoothPosition = Vector2.Lerp((Vector2)transform.position, targetPosition, smoothspd * Time.deltaTime);

    }
    }
}
    

