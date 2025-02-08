using UnityEngine;

public class Interaction : MonoBehaviour
{
    //[SerializeField] float rzecz = 5.0f;
    [SerializeField] Transform interactTransform;
    [SerializeField] float interactRate = 1.0f;
    [SerializeField] float _nextInteract = 0.0f;
    [SerializeField] LayerMask cursedLayerMask;

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 5.0f;

    private void Awake()
    {
        if (interactTransform == null)
        {
            interactTransform = GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint.forward * bulletspeed; 
            interact();

            //Debug.Log("dupa");
            //RaycastHit hit;
        }
    }
    private void interact()
    {
        if (Time.timeSinceLevelLoad < _nextInteract)
        {
            return;
        }
        Physics.Raycast(interactTransform.position, interactTransform.forward, out RaycastHit hitinfo, cursedLayerMask);
            {
                Debug.Log(hitinfo.collider)    ;
            }
            _nextInteract = Time.timeSinceLevelLoad + 1.0f / interactRate;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(interactTransform.position, interactTransform.forward);
    }













}
