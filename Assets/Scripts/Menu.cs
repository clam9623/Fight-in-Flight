using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Agent has left");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}