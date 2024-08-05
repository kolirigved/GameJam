using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Vector2 resetPosition; // The position to reset the player to
    /*public Transform resetTransform; // The transform to reset the player to

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the player
        //if (collision.gameObject.CompareTag("Player"))
        //{
            // Reset the player's transform
            collision.transform.position = resetTransform.position;
            collision.transform.rotation = resetTransform.rotation;
            collision.transform.localScale = resetTransform.localScale;
        //}
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with portal. Resetting position.");
            
            // Reset the player's transform to the origin (0,0,0)
            collision.transform.position = resetPosition;
        }
    }
}
