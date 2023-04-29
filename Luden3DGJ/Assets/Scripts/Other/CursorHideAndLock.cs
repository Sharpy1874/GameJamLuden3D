using Assets.Scripts.Other;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHideAndLock : MonoBehaviour
{
    public TimerCountDown timerCountDown;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerCountDown.timeLeft == 0.0f || Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
