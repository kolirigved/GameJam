using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public Canvas gameWinCanvas;
    void Start()
    {
        // Set the game win canvas to be inactive at the start
        gameWinCanvas.gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Display the game win canvas
            gameWinCanvas.gameObject.SetActive(true);

            // Stop the game by setting time scale to 0
            Time.timeScale = 0;
        }
    }
}
