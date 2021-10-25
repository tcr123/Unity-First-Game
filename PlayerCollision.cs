using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // if collide with block trigger lose condition
    void OnCollisionEnter (Collision info)
    {
        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
