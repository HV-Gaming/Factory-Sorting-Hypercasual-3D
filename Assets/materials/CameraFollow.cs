using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // the transform of the player character
    public Vector3 offset; // the offset of the camera from the player

    void Update()
    {
        transform.position = player.position + offset;
    }
}
