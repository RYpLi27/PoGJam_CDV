using System;
using UnityEngine;
using UnityEngine.UI;
public class Insanity : MonoBehaviour
{
    [SerializeField] float initialInsanity = 0.0f;
    [SerializeField] public float maxInsanity = 100.0f;
    [SerializeField] public float currentInsanity = 1.0f;
    [SerializeField] private Slider playerSanityBar;
    public Image insanityBar;


    public void ChangeInsanityValue(float amountToChange = 15.0f)
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
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                Suffer(20);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Sanity(5);
            }
        }
    }

public void Suffer(float insaneDamage)
    {
        currentInsanity -= insaneDamage;
        insanityBar.fillAmount = currentInsanity / 100.0f;
    }
    public void Sanity(float SaneAmount)
    {
        currentInsanity += SaneAmount;
        currentInsanity = Mathf.Clamp(currentInsanity, 0, 100);
        insanityBar.fillAmount *= currentInsanity / 100.0f;
    }
}
