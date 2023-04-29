using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

namespace Assets.Scripts.Other
{
    public class TimerCountDown : MonoBehaviour
    {

        public float countdownTime = 900.0f; // The amount of time in seconds to count down from
        private float timeLeft; // The amount of time left in the countdown

        public TextMeshProUGUI countdownText; // Assign this in the Unity editor

        void Start()
        {
            timeLeft = countdownTime; // Set the initial time left to the countdown time
        }

        void Update()
        {
            timeLeft -= Time.deltaTime; // Subtract the time since the last frame from the time left

            if (timeLeft <= 0.0f)
            {
                // The countdown has ended
                timeLeft = 0.0f;
                // Do something when the countdown ends
                ShowGameOver();
            }

            // Calculate the number of minutes and seconds remaining
            int minutes = Mathf.FloorToInt(timeLeft / 60.0f);
            int seconds = Mathf.FloorToInt(timeLeft % 60.0f);

            // Display the time left in the TextMeshProUGUI component
            countdownText.text = string.Format("{0}:{1:00}", minutes, seconds);
        }

        private void ShowGameOver()
        {
            //dopísať
        }
    }
}