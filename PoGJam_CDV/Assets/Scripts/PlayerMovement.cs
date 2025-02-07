using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    [SerializeField] float rotationSpeed = 1.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
