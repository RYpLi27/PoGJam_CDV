using UnityEngine;

public class Funkcje : MonoBehaviour
{
    private void Start()
    {
        Oblicz(2, 3); // Wykonuje funkcjê Oblicz gdzie oblicza wynik i go wyœwietla w konsoli

        int suma = ObliczAleZwroc(1, 2); // Wykonuje funkcjê ObliczAleZwroc gdzie oblicza wynik i go zwraca
        Debug.Log($"ObliczAleZwroc | Suma: {suma}"); // Wyœwietla wynik w konsoli osobno
    }

    private void Oblicz(int p_liczba1, int p_liczba2) // W Funkcjach mo¿na przekazywaæ parametry. BARDZO PRZYDATNE!!!
    {
        int suma = p_liczba1 + p_liczba2; // Oblicza sumê dwóch liczb i przypisuje do tymczasowej zmiennej suma
        Debug.Log($"Oblicz | Suma: {suma}"); // Wyœwietla wynik w konsoli
    }

    private int ObliczAleZwroc(int p_liczba1, int p_liczba2)
    {
        int suma = p_liczba1 + p_liczba2;
        return suma;
    }

    // Funkcje publiczne zazwyczaj nie powinny przyjmowaæ parametrów poniewa¿ mog¹ byæ modyfikowane poza gr¹!
    // Jedynie publiczne powinny byæ funkcje które zwracaj¹ wartoœæ lub wywo³uj¹ inne funkcje.
    // W normalnym programowanie to trzeba wszystko zabezpieczaæ ale w Unity jest to niepotrzebne bo ludzie lubi¹ modyfikowaæ gry.
    // Jedynie przy multiplayerze trzeba zabezpieczaæ funkcje publiczne.
}
