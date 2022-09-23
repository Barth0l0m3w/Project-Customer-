using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmusik : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip backgroundmusic;

    private void Awake()
    {
        audioSource.clip = backgroundmusic;
        audioSource.Play();
        DontDestroyOnLoad(gameObject);
    }
}
