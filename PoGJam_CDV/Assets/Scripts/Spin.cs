using UnityEngine;
using UnityEngine.InputSystem;

public class Spin : MonoBehaviour
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
        //_transform.Rotate(0, 0, 1);
            _cameraTransform.transform.Rotate(0, 0, 50 * Time.deltaTime); //rotates 50 degrees per second around z axis
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        }
    
}
