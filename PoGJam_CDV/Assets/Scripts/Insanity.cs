using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Insanity : MonoBehaviour
{
    [SerializeField] float initialInsanity = 0.0f;
    [SerializeField] public float maxInsanity = 100.0f;
    [SerializeField] public float currentInsanity = 1.0f;
    [SerializeField] private SliderS playerSanityBar;
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
        if (currentInsanity < maxInsanity)
        {
            currentInsanity += 0.02f;
            //currentInsanity += 0.02f * roomNumber;

        } else if (currentInsanity >= maxInsanity) SceneManager.LoadScene("CRAZY");
    }
}
