using UnityEngine;

public class PlayerMovementLeft : MonoBehaviour
{
    public float speed = 10.0f; // Movement speed (units per second)

    void Update()
    {
        // Move continuously to the left when the game starts
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

