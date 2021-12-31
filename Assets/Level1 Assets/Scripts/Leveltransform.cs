using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leveltransform : MonoBehaviour
{
    private int scenetocontinue;


    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void GoTOpuzzle()
    {
        SceneManager.LoadScene("Puzzlegame");
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Playgame");
    
    }
    public void Quits()
    {
        Application.Quit();
    }

    public void Continue_game()
    {
        scenetocontinue = PlayerPrefs.GetInt("SavedScene");
        if (scenetocontinue != 0)
        {
            SceneManager.LoadScene(scenetocontinue);
        }
        else
            return;
    }
    public void Exit()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void WinScene()
    {
        SceneManager.LoadScene("Winning Scene");
    }
}
