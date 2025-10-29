using UnityEngine;
using Unity.Cinemachine;

public class SimpleTimeZone : MonoBehaviour
{
    public CinemachineCamera effectCam; // Cámara que se activa
    public float timeScale = 1f;        // <1 lento, >1 rápido

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            effectCam.gameObject.SetActive(true);
            Time.timeScale = timeScale;
        }
    }
}
