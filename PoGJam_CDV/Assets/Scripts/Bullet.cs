using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3.0f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
