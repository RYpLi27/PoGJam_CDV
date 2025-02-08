using UnityEngine;

public class Insanity : MonoBehaviour
{
    [SerializeField] float initialInsanity = 0.0f;
    [SerializeField] float maxInsanity = 100.0f;
    [SerializeField] float currentInsanity = 1.0f;



    public void ChangeInsanityValue(float amountToChange)
    {
        currentInsanity += amountToChange;
        if (currentInsanity > maxInsanity)
        {
            currentInsanity = maxInsanity;
        }
        if (currentInsanity > initialInsanity)
        {
            if (currentInsanity >= 100.0f)
            {
                Debug.Log("oszalałem");
            }
        }
    }
    private void Start()
    {
        currentInsanity = initialInsanity;
    }
    private void FixedUpdate()
    {
        if (currentInsanity < 100.0f)
        {
            currentInsanity += 0.02f;
            //currentInsanity += 0.02f * roomNumber;
            Debug.Log(currentInsanity);
        }
    }
}
