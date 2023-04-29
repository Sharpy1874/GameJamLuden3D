using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CheckIfInteractible : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowButton();
        }
    }

    protected virtual void OnTriggerExit(Collider other)
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
