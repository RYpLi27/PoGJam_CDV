using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    [SerializeField] float rotationSpeed = 1.0f;
    [SerializeField] GameObject player;
    [SerializeField] float turnSpeed;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;
    // Update is called once per frame
    void FixedUpdate()
    {
        //float yMouse = Input.GetAxis("Mouse X");
        //float xMouse = Input.GetAxis("Mouse Y");

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.position = player.transform.position;
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Rotate(Vector3.right, turnSpeed * horizontalInput * Time.deltaTime);

    }

                                                          //Best wishes, -Lincoln Green 
}
