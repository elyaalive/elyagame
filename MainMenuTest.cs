using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTest : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
