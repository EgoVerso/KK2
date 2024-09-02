using UnityEngine;

public class RandomSoundOnClick : MonoBehaviour
{
    public AudioClip[] soundClips;   // Arreglo para almacenar los clips de sonido
    public AudioSource audioSource;  // AudioSource para reproducir los sonidos
    public int clicksBeforeSound = 3; // N�mero de clics antes de que suene un sonido
    private int clickCount = 0;       // Contador de clics

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Verifica si se hace clic izquierdo
        {
            clickCount++;  // Incrementa el contador de clics

            if (clickCount >= clicksBeforeSound)  // Comprueba si se alcanz� el n�mero de clics requerido
            {
                PlayRandomSound();  // Reproduce un sonido aleatorio
                clickCount = 0;      // Reinicia el contador de clics
            }
        }
    }

    void PlayRandomSound()
    {
        int randomIndex = Random.Range(0, soundClips.Length);  // Selecciona un �ndice aleatorio
        AudioClip clipToPlay = soundClips[randomIndex];         // Obtiene el clip de sonido correspondiente
        audioSource.PlayOneShot(clipToPlay);                   // Reproduce el sonido
    }
}
