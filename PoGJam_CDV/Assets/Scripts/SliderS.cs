using UnityEngine;
using UnityEngine.UI;

public class SliderS : MonoBehaviour
{
    [SerializeField] private Slider m_Slider;
    [SerializeField] private Insanity _insanity;

    private void Start()
    {
        m_Slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (m_Slider != null)
        {
            m_Slider.value = Mathf.Clamp(_insanity.currentInsanity / 100, 0, 100);
            DontDestroyOnLoad(m_Slider);
        }
    }
}
