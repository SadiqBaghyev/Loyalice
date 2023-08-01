using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    
    public void levelOne()
    {
        SceneManager.LoadScene("1");
        //SceneManager.LoadScene("1");

    }
    public void levelTwo()
    {
        SceneManager.LoadScene("2");
    }
    public void levelThree()
    {
        SceneManager.LoadScene("3");
    }
    public void levelFour()
    {
        SceneManager.LoadScene("4");
    }
    public void levelFive()
    {
        SceneManager.LoadScene("5");
    }
    public void levelSix()
    {
        SceneManager.LoadScene("6");
    }
    public void exitMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void finishMenu()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
}