using UnityEngine;

public class Loosable : MonoBehaviour
{
    private Insanity _insanity;

    public void InsanityLoss(float amount)
    { _insanity.ChangeInsanityValue(-amount); }

    private void Awake()
    {
        _insanity = GetComponent<Insanity>();
    }
}
