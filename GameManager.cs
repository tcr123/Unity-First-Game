using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float delayTime = 2f;

    public GameObject gameObjectUI;

    // the game lose and restart
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            Debug.Log("Game Over");
            GameHasEnded = true;
            Invoke("Restart", delayTime);
        }
    }

    // the game win 
    public void WinGame()
    {
        gameObjectUI.SetActive(true);
    }

    // the screen reload if lose
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
