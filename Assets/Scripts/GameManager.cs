using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // This function will be called by our UI Buttons
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Shows in editor since app won't close there
    }
}