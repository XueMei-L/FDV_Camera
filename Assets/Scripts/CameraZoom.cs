using UnityEngine;
using Unity.Cinemachine;

public class SmoothCameraZoom : MonoBehaviour
{
    public CinemachineCamera vcam;   // Arrastra tu Cinemachine Camera aquí
    public float zoomStep = 1f;      // Cuánto cambia por pulsación
    public float zoomSpeed = 5f;     // Qué tan rápido se interpola
    public float minZoom = 3f;
    public float maxZoom = 20f;

    private float targetZoom;        // Valor objetivo del zoom

    void Start()
    {
        // Guardamos el tamaño inicial
        targetZoom = vcam.Lens.OrthographicSize;
    }

    void Update()
    {
        if (vcam == null) return;

        // Detectar entrada de teclado
        if (Input.GetKey(KeyCode.W))
        {
            targetZoom -= zoomStep * Time.deltaTime * 5f; // Suave hacia adentro
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetZoom += zoomStep * Time.deltaTime * 5f; // Suave hacia afuera
        }

        // Limitar rango
        targetZoom = Mathf.Clamp(targetZoom, minZoom, maxZoom);

        // Interpolación suave hacia el valor objetivo
        float currentZoom = vcam.Lens.OrthographicSize;
        float newZoom = Mathf.Lerp(currentZoom, targetZoom, Time.deltaTime * zoomSpeed);

        // Aplicar en una sola línea
        var lens = vcam.Lens;
        lens.OrthographicSize = newZoom;
        vcam.Lens = lens;
    }
}
