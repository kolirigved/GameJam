using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public float minTime = 5f;  // Minimum time in seconds
    public float maxTime = 10f; // Maximum time in seconds

    private float timer;
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        // Set the game over canvas to be inactive at the start
        gameOverCanvas.gameObject.SetActive(false);

        // Set a random time between minTime and maxTime
        timer = Random.Range(minTime, maxTime);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!isGameOver)
        {
            // Decrease the timer
            timer -= Time.deltaTime;

            // Check if the timer has reached zero
            if (timer <= 0)
            {
                // Trigger game over
                TriggerGameOver();
            }
        }
    }

    void TriggerGameOver()
    {
        // Set game over flag
        isGameOver = true;

        // Display the game over canvas
        gameOverCanvas.gameObject.SetActive(true);

        // Stop all other running codes
        Time.timeScale = 0;
    }
}
