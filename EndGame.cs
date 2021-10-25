using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager gameManager;

    // trigger win game function
    void OnTriggerEnter()
    {
        gameManager.WinGame();
    }
}
