using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuQuality : MonoBehaviour
{



    public void mainX()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void highQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void mediumQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void lowQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
   
}