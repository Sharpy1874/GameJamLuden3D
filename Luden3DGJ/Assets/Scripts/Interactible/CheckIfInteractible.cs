using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfInteractible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowButton();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideButton();
        }
    }
    protected virtual void ShowButton()
    {
        
    }
    protected virtual void HideButton()
    {
        
    } 
}
