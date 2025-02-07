using System.Collections;
using UnityEngine;

public class MetodyUnity : MonoBehaviour
{
    private void Awake()
    {
        // Aktywuje siê przed startem
        // Najlepsze do wczytywania zasobów
    }
    private void Start()
    {
        // Aktywuje siê na pocz¹tku
        // Najlepsze do inicjalizacji
    }

    private void OnEnable()
    {
        // Aktywuje siê gdy skrypt jest aktywny
        // Je¿eli obiekt zostanie aktywowany to skrypt z OnEnable na tym obiekcie siê aktywuje
    }

    private void OnDisable()
    {
        // Aktywuje siê gdy skrypt jest nieaktywny 
        // Je¿eli obiekt zostanie wy³¹czony to skrypt z OnDisable na tym obiekcie siê aktywuje
    }

    private void OnDestroy()
    {
        // Aktywuje siê gdy skrypt jest niszczony
        // Je¿eli obiekt zostanie zniszczony to skrypt z OnDestroy na tym obiekcie siê aktywuje
    }

    private void Update()
    {
        // Aktywuje siê co klatkê
    }

    private void FixedUpdate()
    {
        // Aktywuje siê co klatkê fizyczn¹
    }

    private IEnumerator Coroutine()
    {
        // Aktywuje siê gdy Coroutine jest aktywny
        // Coroutine to funkcja która dzia³a w tle
        yield return null;
    }

    // Wykrywa kolizjê z innym obiektem gdy obiekt wszed³ w kolizjê
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    gameObject.SetActive(false);
        //}
    }

    // Wykrywa kilizjê z innym obiektem gdy obiekt jest w kolizji
    private void OnTriggerStay(Collider other)
    {
        
    }

    // Wykrywa kolizjê z innym obiektem gdy obiekt wyszed³ z kolizji
    private void OnTriggerExit(Collider other)
    {
        
    }

    // Wykrywa kolizjê z innym obiektem gdy obiekt dotkie kolizji
    private void OnCollisionEnter(Collision collision)
    {
        //if (other.CompareTag("Player"))
        //{
        //    Funkcja BOOM!
        //    gameObject.SetActive(false);
        //}
    }
}
