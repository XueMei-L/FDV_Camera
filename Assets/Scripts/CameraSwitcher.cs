using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    private GameObject activeCamera;

    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        activeCamera = camera1;
    }

    void Update()
    {
        // Cambiar cámara con la tecla C
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        if (activeCamera == camera1)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            activeCamera = camera2;
        }
        else
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            activeCamera = camera1;
        }
    }
}

