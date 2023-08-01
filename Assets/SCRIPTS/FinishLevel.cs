using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public void level1Finish()
    {
        ManagerLevel.level2 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level2Finish()
    {
        ManagerLevel.level3 = true;
        SceneManager.LoadScene("levelsMenu");

    }
    public void level3Finish()
    {
        ManagerLevel.level4 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level4Finish()
    {
        ManagerLevel.level5 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level5Finish()
    {
        ManagerLevel.level6 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level6Finish()
    {
        ManagerLevel.level7 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level7Finish()
    {
        ManagerLevel.level8 = true;
        SceneManager.LoadScene("levelsMenu");
    }   
    public void level8Finish()
    {
        ManagerLevel.level9 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level9Finish()
    {
        ManagerLevel.level10 = true;
        SceneManager.LoadScene("levelsMenu");
    }
    public void level11Finish()
    {
        ManagerLevel.level12 = true;
        SceneManager.LoadScene("levelsMenu");
    }

}
