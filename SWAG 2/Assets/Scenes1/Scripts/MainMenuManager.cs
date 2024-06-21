using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject settingsPanel;

    public void PlayGame()
    {
        Application.LoadLevel("GAME2(0.1)");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
    }
    
    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}
