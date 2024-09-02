using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taunt : MonoBehaviour
{
    public AudioClip[] tauntClips; // Array de clips de audio para las burlas
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Obtiene el componente AudioSource
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayRandomTaunt();
        }
    }

    void PlayRandomTaunt()
    {
        if (tauntClips.Length > 0)
        {
            int randomIndex = Random.Range(0, tauntClips.Length); // Selecciona un clip aleatorio
            audioSource.clip = tauntClips[randomIndex];
            audioSource.Play();
        }
    }
}
