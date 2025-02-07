using UnityEngine.UI;
using UnityEngine;

public class Lambdy : MonoBehaviour
{
    // Lambdy to krótkie funkcje anonimowe:

    private int[] liczby = new[] { 1, 2, 3, 4, 5 };
    private int sumaLiczb => liczby[1] + liczby[2]; // W³aœciwoœæ obliczaj¹ca sumê wybranych elementów tablicy (5 = liczby[1] + liczby[2])
    private int suma => 1 + 2; // W³aœciwoœæ obliczaj¹ca prost¹ sumê (3 = 1 + 2)

    // Przydaj¹ siê do szybkich wykonywania funkcji anonimowych:
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(() => Debug.Log("Klikniêto przycisk!")); // Tak samo jak w JavaScripcie.
    }
}
