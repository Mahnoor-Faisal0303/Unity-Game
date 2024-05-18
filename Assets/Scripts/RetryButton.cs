using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public string gameSceneName = "Scene"; // Replace with your actual game scene name

    private void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
        // Add any additional initialization code here
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Call this method when you want to start the game (e.g., from a button click)
    public void StartButtonClicked()
    {
        StartGame();
    }

    // Call this method when you want to restart the game (e.g., from a button click)
    public void RestartButtonClicked()
    {
        RestartGame();
    }
}
