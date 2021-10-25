using UnityEngine;

public class CamPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;

    // Update is called once per frame
    // make sure main camera follow player
    void Update()
    {
        transform.position = player.position + offSet;
    }
}
