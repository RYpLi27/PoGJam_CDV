using UnityEngine;

// public class Publicznosc - to klasa
public class Publicznosc : MonoBehaviour
{
    public void FunkcjaPubliczna()
    {
        // Funkcja bez parametrów
        // Public - dostępna w innych klas (czyli np w Funkcje2)
    }

    private void FunkcjaPrywatna()
    {
        // Funkcja prywatna
        // Private - dostępna tylko w tej klasie (niedostępne w Funkcje2)
    }
}

public class Funkcje2 : MonoBehaviour
{
    Publicznosc funkcje = new Publicznosc(); // Tworzy nowy obiekt klasy Funkcje

    private void Start()
    {
        funkcje.FunkcjaPubliczna(); // Wywołanie funkcji publicznej z klasy Funkcje
    }
}