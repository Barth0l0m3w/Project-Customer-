using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmusik : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip backgroundmusic;

    [Range(0f, 1f)]
    public float volume;

    private void Awake()
    {
        audioSource.clip = backgroundmusic;
        audioSource.Play();
        DontDestroyOnLoad(gameObject);
        audioSource.volume = volume;
    }
}
