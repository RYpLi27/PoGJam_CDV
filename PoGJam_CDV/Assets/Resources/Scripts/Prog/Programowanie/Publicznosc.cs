using UnityEngine;

// public class Publicznosc - to klasa
public class Publicznosc : MonoBehaviour
{
    public void FunkcjaPubliczna()
    {
        // Funkcja bez parametrów
        // Public - dostêpna w innych klas (czyli np w Funkcje2)
    }

    private void FunkcjaPrywatna()
    {
        // Funkcja prywatna
        // Private - dostêpna tylko w tej klasie (niedostêpne w Funkcje2)
    }
}

public class Funkcje2 : MonoBehaviour
{
    Publicznosc funkcje = new Publicznosc(); // Tworzy nowy obiekt klasy Funkcje

    private void Start()
    {
        funkcje.FunkcjaPubliczna(); // Wywo³anie funkcji publicznej z klasy Funkcje
    }
}