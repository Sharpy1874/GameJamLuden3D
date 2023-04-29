using Assets.Scripts.Other;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGame : MonoBehaviour
{
    public bool hasWon = false;
    public HandleInGameUI WonGame;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        hasWon = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasWon = true;
            WonGame.WonUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
