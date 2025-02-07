using UnityEngine;

[CreateAssetMenu(fileName = "PrzechowywanieDanychj", menuName = "Scriptable Objects/PrzechowywanieDanychj")]
// To po prostu tworzy nowy obiekt w Unity (zak³adka Create->Scriptable Objects->PrzechowywanieDanychj)
// fileName - nazwa pliku (PrzechowywanieDanychj.asset)
// menuName - nazwa w menu (zak³adka Create->Scriptable Objects->PrzechowywanieDanychj) mo¿esz co kolwiek tam wpisaæ
public class PrzechowywanieDanych : ScriptableObject // dziedziczy po ScriptableObject
{
    // ScriptableObject mo¿e przechowywaæ jedynie dane. Nie mo¿e wykonywaæ ¿adnych funkcji.
    // Mo¿na go u¿ywaæ do przechowywania danych które maj¹ byæ dostêpne w wielu miejscach w grze.
    // Np do przechowywania ustawieñ gry, zapusu gry, parametrów przeciwników itp.

    // Mo¿esz podstawowo stworzyæ zmienne:
    public int liczba1;
    public int liczba2;

    // Lub te¿ mo¿esz stworzyæ strukturê danych:
    // Struktóra danych zawsze musi byæ [System.Serializable]

    public Dane dane;

    [System.Serializable]
    public struct Dane // Struktura danych
    {
        public int liczba1;
        public int liczba2;
    }

    // Mo¿esz te¿ stworzyæ tablicê danych i dynamicznie dodawaæ elmenty które potem odczytujesz:

    public Dane[] daneTablica; // Tablica danych
}
