using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;
    private bool alreadyPlaying = false;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destory on load: " + name);
    }

    void Start()
    {
            audioSource = GetComponent<AudioSource>();
            audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }

    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip: " + thisLevelMusic);

    if (alreadyPlaying = true)
        {

        }
    else if (!alreadyPlaying && thisLevelMusic)
        { // If there's some music attached
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
            alreadyPlaying = true;
        }
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }

}