using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; // cuando empieza la escena este valor es null 
    // cuando copias cambiar lo de soundManager
    public AudioSource source; 

    public void Awake()
    {
        if (Instance != null && Instance != this) //si ya hay algo
        {
            Destroy(this.gameObject); // destruirme
        }

        else // entonces esta vacio
        {
            Instance = this; // asigno que instance es this
        }

        DontDestroyOnLoad(this); // no destruir el objeto cuando cambie la escena

        source = GetComponent<AudioSource>();

    }
    public void PlaySound(AudioClip clip)
    {
        // source.Stop();
        source.loop = false;
        source.PlayOneShot(clip);
    }
 
}
