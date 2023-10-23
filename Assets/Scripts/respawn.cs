using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public Transform respawnPoint; // Assign the respawn point in the Inspector
    public Rigidbody playerRigidbody;


    // Update is called once per frame
    void Update()
    {
        // Check the player's Y position
        if (transform.position.y < -120)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Reset the player's position to the respawn point
        transform.position = new Vector3(0, 0.5f, 0);

        // You can also add additional logic here, such as resetting player's health or other properties.
    }
}
