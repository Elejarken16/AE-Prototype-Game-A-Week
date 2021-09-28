using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public GameObject ControlsDisplay;

    public void PlayTheGame()
    {
        SceneManager.LoadScene(1);
    }

    public void whenButtonClicked()
    {
        if (ControlsDisplay.activeInHierarchy == true)
            ControlsDisplay.SetActive(false);
        else
            ControlsDisplay.SetActive(true);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}
