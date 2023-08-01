using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    // Oyuncu ilerlemesini saklamak için kullanılacak değişken
    private int completedLevelIndex = 0;

    private void Start()
    {
        // Oyuncu ilerlemesini PlayerPrefs'ten yükle
        completedLevelIndex = PlayerPrefs.GetInt("CompletedLevel", 0);

        // Oyuncu ilerlemesine göre bölümü yükle
        LoadLevel(completedLevelIndex + 1);
    }

    // Bölüm yükleme fonksiyonu
    public void LoadLevel(int levelIndex)
    {
        // Burada belirli bir bölümü yüklemek için gerekli kodları yazabilirsiniz
        // Örneğin, belirli bir scene (sahne) yüklemek için SceneManager.LoadScene() fonksiyonunu kullanabilirsiniz.
    }

    // Bölümü tamamlandığında çağrılacak fonksiyon
    public void CompleteLevel()
    {
        // Oyuncunun tamamladığı son bölümü PlayerPrefs'e kaydet
        PlayerPrefs.SetInt("CompletedLevel", completedLevelIndex);
        PlayerPrefs.Save(); // Verileri kaydet

        // Bir sonraki bölümü yükle
        LoadLevel(completedLevelIndex + 1);
    }
}
