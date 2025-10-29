using UnityEngine;
using Unity.Cinemachine;

public class CamaraTransition : MonoBehaviour
{
    public CinemachineCamera camConfinada;
    public CinemachineCamera camLibre;

    public int activePriority = 10;
    public int inactivePriority = 5;

    // Si true → activa la cámara confinada, si false → activa la cámara libre
    public bool activateConfinada = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (activateConfinada)
        {
            camConfinada.Priority = activePriority;
            camLibre.Priority = inactivePriority;
        }
        else
        {
            camConfinada.Priority = inactivePriority;
            camLibre.Priority = activePriority;
        }
    }
}
