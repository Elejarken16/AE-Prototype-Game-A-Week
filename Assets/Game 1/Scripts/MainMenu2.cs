using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public GameObject ControlsDisplay;

    public void BackToGame()
    {
        SceneManager.LoadScene(0);
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
