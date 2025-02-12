using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] float speed = 5.0f;
    //[SerializeField] float rotationSpeed = 1.0f;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
        //_transform = this.transform;
    }

    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 moveVector = verticalMove * _transform.forward + horizontalMove * _transform.right;
        _rb.MovePosition(_rb.position + moveVector * speed * Time.deltaTime);
        //_transform.position = _transform.position + moveVector * speed * Time.deltaTime;
    }
}
