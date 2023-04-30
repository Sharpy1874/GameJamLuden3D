using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject WinUI;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WinUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
