using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleInGameUI : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject PauseUI;
    public GameObject WonUI;
    public GameObject LoseUI;

    private void Start()
    {
        PauseUI.SetActive(false);
        WonUI.SetActive(false);
        LoseUI.SetActive(false);
    }
    public void SetTimeScale()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); ;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); ;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
