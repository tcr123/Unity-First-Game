using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float delayTime = 2f;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            Debug.Log("Game Over");
            GameHasEnded = true;
            Invoke("Restart", delayTime);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
