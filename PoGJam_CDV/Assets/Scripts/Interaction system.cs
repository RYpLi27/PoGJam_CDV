using UnityEngine;

public class Interactionsystem : MonoBehaviour
{
    [SerializeField] private CursedCounter _CursedCounter;

    // stats
    public float timeBetweenClicking, range, timeBetweenClicks;
    public bool allowButtonHold;

    bool clicking, readyToClick;

    //reference
    public Camera playerCam;
    public Transform attackPoint;
    public RaycastHit RaycastHit;
    public LayerMask whatIsCursed;

    private void Awake()
    {
        readyToClick = true;
    }
    private void Update()
    {
        MyInput();
        //click();
    }
    private void MyInput()
    {
        //if (allowButtonHold) clicking = Input.GetMouseButton(0);
        if (Input.GetMouseButtonDown(0))
        {
            click();
        }
        //else clicking = Input.GetKeyDown(KeyCode.Mouse0);
    }
    //click();
    
    private void click()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
            
        Debug.DrawRay(playerCam.transform.position, playerCam.transform.forward * range, Color.red);

        if (Physics.Raycast(ray, out RaycastHit, range, whatIsCursed))
        {
            Debug.Log(RaycastHit.collider);

            if (RaycastHit.collider.CompareTag("CursedObjects"))
            {
                RaycastHit.collider.gameObject.SetActive(false);
                _CursedCounter.MinusCursedObjects(1);                 
                Debug.Log("whatIsCursed");

            }
        }
                //RaycastHit.collider.GetComponent<>().Funkcja(instanity);
        if (readyToClick = false){
            Invoke("ResetShot", timeBetweenClicking);
            Invoke("click", timeBetweenClicks); }
    }
    private void ResetShot()
    {
        readyToClick = true;
    }
}
