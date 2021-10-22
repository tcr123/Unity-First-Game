using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float delayTime = 2f;

    public GameObject gameObjectUI;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            Debug.Log("Game Over");
            GameHasEnded = true;
            Invoke("Restart", delayTime);
        }
    }

    public void WinGame()
    {
        gameObjectUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
