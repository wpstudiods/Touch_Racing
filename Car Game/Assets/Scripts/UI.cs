using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("Level_Select");
    }
    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void NextLevel1()
    {
        SceneManager.LoadScene("1_1");
    }
    
    public void NextLevelDeb()
    {
        SceneManager.LoadScene("Debug_Scene");
    }
    
    public void NextLevel2()
    {
        SceneManager.LoadScene("1_2");
    }
    
    public void NextLevel3()
    {
        SceneManager.LoadScene("1_3");
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
