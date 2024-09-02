using UnityEngine;
using System.Collections; // Asegúrate de incluir este namespace

public class FadeOut : MonoBehaviour
{
    public float fadeDuration = 5f; // Duración del fade-out en segundos
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

        // Comienza en negro
        spriteRenderer.color = Color.black;

        // Inicia la corrutina para el fade-out
        StartCoroutine(FadeOutCoroutine());
    }

    IEnumerator FadeOutCoroutine()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / fadeDuration;
            spriteRenderer.color = Color.Lerp(Color.black, originalColor, t);
            yield return null;
        }

        // Asegurarse de que el color final sea el original
        spriteRenderer.color = originalColor;
    }
}
