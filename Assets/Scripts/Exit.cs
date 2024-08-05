using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void Update()
    {
        // Find all game objects with the tag "Key"
        GameObject[] keys = GameObject.FindGameObjectsWithTag("Key");

        // Check if the number of keys is zero
        if (keys.Length == 0)
        {
            // Destroy the game object this script is attached to
            Destroy(gameObject);
        }
    }
}
