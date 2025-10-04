using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayDrivingGame()
    {
        SceneManager.LoadScene("Challenge 1");
    }

    public void PlayFlyingGame()
    {
        SceneManager.LoadScene("Challenge 3");
    }

    public void PlaySumoGame()
    {
        SceneManager.LoadScene("Challenge 4");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit game pressed! (won’t show in editor)");
    }
}
