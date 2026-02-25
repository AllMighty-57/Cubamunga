using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public float minX, maxX;

    void Update()
    {
        // Clamp the player's position within the defined boundaries
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            transform.position.y,
            transform.position.z
        );
    }
}
