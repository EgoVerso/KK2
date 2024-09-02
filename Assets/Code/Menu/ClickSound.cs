using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;  // El clip de sonido que se reproducirá al hacer clic
    private AudioSource audioSource;

    void Start()
    {
        // Obtener el componente AudioSource del objeto
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Si no hay un componente AudioSource, agregar uno
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Detectar clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Reproducir el sonido
            audioSource.PlayOneShot(clickSound);
        }
    }
}
