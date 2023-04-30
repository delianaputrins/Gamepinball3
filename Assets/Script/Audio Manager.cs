using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;

    // Start is called before the first frame update
    private void Start()
    {
        PlayBGM();
    }

    public void PlayBGM() 
    {
        bgmAudioSource.Play();
    }
    public void PlaySFX() 
    {

    }

}
