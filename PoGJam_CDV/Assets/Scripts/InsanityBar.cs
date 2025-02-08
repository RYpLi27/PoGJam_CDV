using UnityEngine;
using UnityEngine.UI;
public class InsanityBar : MonoBehaviour
{
    public Text scoreText;
    public Insanity _insanity;

    private void Start()
    {
        _insanity = GetComponent<Insanity>();
    }
    void Update()
    {
        //scoreText.text = _insanity.currentInsanity.ToString();
    }
}
