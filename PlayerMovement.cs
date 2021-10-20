using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float MovementSpeed = 2000f;
    public float SidewaySpeed = 200f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
            rb.AddForce(SidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rb.AddForce(-SidewaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
