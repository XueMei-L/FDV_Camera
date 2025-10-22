using UnityEngine;

public class PlayerMovementRight : MonoBehaviour
{
    public float speed = 10.0f; // Movement speed (units per second)

    void Update()
    {
        // Move continuously to the right when the game starts
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}