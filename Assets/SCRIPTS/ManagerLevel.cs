using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerLevel : MonoBehaviour
{
    
    public static bool level1, level2, level3, level4, level5, level6, level7, level8, level9, level10, level11, level12;
    public Button level1Button, level2Button, level3Button, level4Button, level5Button, level6Button, level7Button, level8Button, level9Button, level10Button, level11Button, level12Button;
    private void Start()
    {
        level1 = true;
    }
    private void Update()
    {
        if (level2 == true)
        {
            level2Button.interactable = true;
        }
        if (level3 == true)
        {
            level3Button.interactable = true;
        }
        if (level4 == true)
        {
            level4Button.interactable = true;
        }
        if (level5 == true)
        {
            level5Button.interactable = true;
        }
        if (level6 == true)
        {
            level6Button.interactable = true;
        }
        if (level6 == true)
        {
            level6Button.interactable = true;
        }
        if (level7 == true)
        {
            level7Button.interactable = true;
        }
        if (level8 == true)
        {
            level8Button.interactable = true;
        }
        if (level9 == true)
        {
            level9Button.interactable = true;
        }
        if (level10 == true)
        {
            level10Button.interactable = true;
        }
        if (level11 == true)
        {
            level11Button.interactable = true;
        }
        if (level12 == true)
        {
            level12Button.interactable = true;
        }
    }
}
