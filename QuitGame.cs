using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // game quit after clicking the button
    public void Quit() 
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
