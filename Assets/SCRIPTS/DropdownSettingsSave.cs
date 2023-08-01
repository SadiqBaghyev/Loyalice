using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownSettingsSave : MonoBehaviour
{
    public Dropdown graphicsDropdown;
    private string graphicsQualityKey = "GraphicsQuality";

    private void Start()
    {
        // Kaydedilen değeri yükle
        if (PlayerPrefs.HasKey(graphicsQualityKey))
        {
            int savedQuality = PlayerPrefs.GetInt(graphicsQualityKey);
            graphicsDropdown.value = savedQuality;
        }

        // Dropdown'da değişiklik olduğunda kaydet
        graphicsDropdown.onValueChanged.AddListener(SaveGraphicsQuality);
    }

    private void SaveGraphicsQuality(int value)
    {
        PlayerPrefs.SetInt(graphicsQualityKey, value);
        PlayerPrefs.Save();
    }
}
