using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yüklemek için gerekli
using UnityEngine.UI;              // UI için gerekli

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Burada sahne indexine göre yükleme yapabilirsin
        // Build Settings -> Scenes in Build kısmına eklediğin sahne indexini gir
        SceneManager.LoadScene(1);  
    }

    public void OpenOptions()
    {
        // Options menüsüne geçiş için sahne açabilirsin
        // Veya UI panelini aktif/pasif yapabilirsin
        Debug.Log("Options menüsü açıldı.");
    }

    public void QuitGame()
    {
        Debug.Log("Oyun kapatılıyor...");
        Application.Quit(); // Build’de çalışır, editörde çalışmaz
    }
}
