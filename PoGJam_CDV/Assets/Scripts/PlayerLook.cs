using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Transform _transform;
    //[SerializeField] float xSensitivity = 4.0f;
    //[SerializeField] float ySensitivity = 4.0f;
    [SerializeField] float mouseSensitivity = 4.0f;
    private Transform _cameraTransform;
    private float _cameraPitch = 45.0f;
    private void Awake()
    {
        _transform = GetComponent<Transform>();

        Camera camera = GetComponentInChildren<Camera>();
        _cameraTransform = camera.GetComponent<Transform>();
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _transform.Rotate(Vector3.up, mouseX * mouseSensitivity);
        _cameraPitch += mouseY * mouseSensitivity;

        // To cos robi, ze kamera sie limituje na max pion i poziom
        _cameraPitch = Mathf.Clamp(_cameraPitch, -90.0f, 90.0f);

        Quaternion xRotation = Quaternion.Euler(-_cameraPitch, 0.0f, 0.0f);
        _cameraTransform.localRotation = xRotation;
        //_cameraTransform.Rotate(Vector3.right, -mouseY * mouseSensitivity);
    }
}
