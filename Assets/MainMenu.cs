using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SceneMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Keluar dari game....");
    }
    public void OpenStudio()
    {
        Application.OpenURL("https://rafiantara.github.io/Shirai-Ryuu-Project/");
    }

}
