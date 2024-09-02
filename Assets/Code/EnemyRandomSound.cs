using UnityEngine;

public class EnemyRandomSound : MonoBehaviour
{
    public AudioClip[] soundClips;    // Arreglo para almacenar los clips de sonido
    public AudioSource audioSource;   // AudioSource para reproducir los sonidos
    public float soundInterval = 10f; // Intervalo de tiempo entre sonidos
    private float timeSinceLastSound; // Temporizador para rastrear el tiempo transcurrido

    void Start()
    {
        timeSinceLastSound = 0f;  // Inicializa el temporizador
    }

    void Update()
    {
        // Actualiza el temporizador con el tiempo transcurrido desde el último cuadro
        timeSinceLastSound += Time.deltaTime;

        // Comprueba si ha pasado suficiente tiempo para reproducir un sonido
        if (timeSinceLastSound >= soundInterval)
        {
            PlayRandomSound();  // Reproduce un sonido aleatorio
            timeSinceLastSound = 0f;  // Reinicia el temporizador
        }
    }

    void PlayRandomSound()
    {
        int randomIndex = Random.Range(0, soundClips.Length);  // Selecciona un índice aleatorio
        AudioClip clipToPlay = soundClips[randomIndex];         // Obtiene el clip de sonido correspondiente
        audioSource.PlayOneShot(clipToPlay);                   // Reproduce el sonido
    }
}
