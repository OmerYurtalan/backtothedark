using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Text volumeAmount1;
    public Text volumeAmount2;

    public Slider slider1;
    public Slider slider2;

    public Sounds[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    private void Start()
    {
        PlayMusic("DarkAtmosphere");
        LoadAudio();
    }
    public void PlayMusic(string name)
    {
        Sounds s = Array.Find(musicSounds, x => x.name == name);

        if(s==null)
        {
            Debug.Log("Sound Not Found");

        }
        else
        {
            musicSource.clip=s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sounds s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");

        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute= !musicSource.mute;
    }
    public void ToggleSFX()
    {
        sfxSource.mute= !sfxSource.mute;
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume= volume;
        volumeAmount2.text = ((int)(volume * 100)).ToString();
        SaveAudio(1);
    }
    public void SFXVolume(float volume)
    {
        sfxSource.volume= volume;
        volumeAmount1.text=((int)(volume*100)).ToString();
        SaveAudio(2);
        
    }

    private void SaveAudio(int x)
    {
        if(x==1)
        {
            PlayerPrefs.SetFloat("musicVolume", musicSource.volume);
        }
        else if(x==2)
        {
            PlayerPrefs.SetFloat("sfxVolume", sfxSource.volume);
        }
    }

    private void LoadAudio()
    {
        if(PlayerPrefs.HasKey("sfxVolume") || PlayerPrefs.HasKey("musicVolume"))
        {
            sfxSource.volume = PlayerPrefs.GetFloat("sfxVolume");
            slider1.value = PlayerPrefs.GetFloat("sfxVolume");
            musicSource.volume = PlayerPrefs.GetFloat("musicVolume");
            slider2.value = PlayerPrefs.GetFloat("musicVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            sfxSource.volume = PlayerPrefs.GetFloat("sfxVolume");
            slider1.value = PlayerPrefs.GetFloat("sfxVolume");
            musicSource.volume = PlayerPrefs.GetFloat("musicVolume");
            slider2.value = PlayerPrefs.GetFloat("musicVolume");

        }

        
    }
}
