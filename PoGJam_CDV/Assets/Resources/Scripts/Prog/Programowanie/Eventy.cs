using System;
using UnityEngine;

public class Eventy : MonoBehaviour
{
    // Eventy umo¿liwiaj¹ nam przypisaæ jak¹œ funkcjê do zdarzenia, które wywo³a siê w odpowiednim momencie.

    // Deklaracja delegata, który bêdzie przechowywa³ funkcje, które chcemy wywo³aæ.
    // public delegate void OnPlayerJump();

    // Deklaracja zdarzenia, które bêdzie wywo³ywane w momencie skoku gracza.
    // public static event OnPlayerJump PlayerJump;

    // ALE NAJLEPIEJ PISAÆ TAK PONIEWA¯ TO JEST TO SAMO CO WY¯EJ:
    // To automatycznie tworzy delegata i event w jednym.
    public static Action PlayerJump; // muszi byc zawsze publiczne

    public void Jump()
    {
        // Wykonuje zdarzenie skoku gracza któr zosta³o przypisane.
        // '?' oznacza czy zdarzenie nie jest puste. Je¿eli jest puste to nie wywo³uje zdarzenia.
        PlayerJump?.Invoke();
    }
}

// Aby to zadzia³a³o w innych skryptach musimy podpi¹æ funkcjê do zdarzenia.
// Przyk³ad w innym skrypcie:
public class PrzypisanieEventu : MonoBehaviour
{
    // Subskrybujemy zdarzenie w momencie aktywacji skryptu.
    private void OnEnable()
    {
        Eventy.PlayerJump += Jump;
    }

    // Odsubskrybujemy zdarzenie w momencie deaktywacji skryptu.
    private void OnDisable()
    {
        Eventy.PlayerJump -= Jump;
    }

    // Funkcja z logik¹ skoku gracza.
    private void Jump()
    {
        Debug.Log("Skok gracza.");
    }
}

// Aby wykonaæ event wystarczy siê odnieœæ tylko do Eventy i wykonaæ z tamt¹d funkcjê w tym przypadku 'Jump'.
// Przyk³ad w innym skrypcie:
public class  WykonanieEventu : MonoBehaviour
{
    private Eventy eventy = new();

    private void Start()
    {
        eventy.Jump();
    }
}
