using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int currentsceneindex;
    public void LoadMainenu()
    {
        currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentsceneindex);
        SceneManager.LoadScene("MainMenu");
    }
}
