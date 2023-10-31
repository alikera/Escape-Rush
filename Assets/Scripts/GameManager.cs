using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameOver = false;
    public float invokeDelay = 2f;
    public GameObject completeLevelUI;

    public void CompletedGame()
    {
        completeLevelUI.SetActive(true);
    }
    public void GameOver()
    {
        if (_gameOver == false)
        {
            _gameOver = true;
            Debug.Log("Game Over!");
            Invoke(nameof(Restart), invokeDelay);
        }

        ;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
