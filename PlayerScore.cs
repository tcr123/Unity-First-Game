using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    // score update with the increasing of player position
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
