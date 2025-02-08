using UnityEngine;
using UnityEngine.UI;

public class insanityLevelBar : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Insanity _insanity;
    private void Start()
    {
        _insanity = GetComponent<Insanity>();
    }
    void Update()
    {
        scoreText.text = _insanity.currentInsanity.ToString;
    }
}
