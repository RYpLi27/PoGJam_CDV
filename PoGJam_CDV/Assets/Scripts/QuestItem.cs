using UnityEngine;

public class QuestItem : MonoBehaviour
{
        private Renderer objectRenderer;
        private Color originalColor;
        public Color highlightColor = Color.magenta; // Kolor podświetlenia
        public bool disappearOnClick = true; // Czy obiekt ma znikać po kliknięciu?

        void Start()
        {
            objectRenderer = GetComponent<Renderer>();
            if (objectRenderer != null)
            {
                originalColor = objectRenderer.material.color;
            }
        }

        void OnMouseDown()
        {
        
            if (disappearOnClick)
            {
                gameObject.SetActive(false); // Ukrycie obiektu
            }
            else if (objectRenderer != null)
        {
            objectRenderer.material.color = highlightColor; // Podświetlenie obiektu
        }
    }
}

