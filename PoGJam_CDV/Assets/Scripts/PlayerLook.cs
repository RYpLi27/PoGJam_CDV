using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    private void Start()
    {
        transform.Rotate(1, 1, 0);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        float horizontal = horizontalSpeed * Input.GetAxis("Mouse X");
        float vertical = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-vertical, horizontal, 0);
    }
}
