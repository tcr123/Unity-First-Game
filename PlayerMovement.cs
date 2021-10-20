using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float MovementSpeed = 2000f;
    public float SidewaySpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        
        if (horizontalInput != 0)
        {
            rb.position = rb.position + new Vector3(SidewaySpeed * Time.deltaTime * horizontalInput, 0, 0);

            if (rb.position.x < -7.6f)
                rb.position = new Vector3(-7.6f, rb.position.y, rb.position.z);
            
            if (rb.position.x > 10f)
                rb.position = new Vector3(10f, rb.position.y, rb.position.z);
        }
    }
}
