using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixerGroup Mixer;

    public void Start()
    {
        // GetComponentInChildren<Toggle>().isOn = PlayerPrefs.GetInt("MusicEnabled", 1) == 1;
        // GetComponentInChildren<Slider>().value = PlayerPrefs.GetFloat("Master", 1);
    }
    
    private void OnEnable()
    {
        Time.timeScale = 0;
    }
    private void OnDisable()
    {
        Time.timeScale = 1;
    }
    public void ToggleMusic(bool enabled)
    {
        if (enabled)
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
        else  
            Mixer.audioMixer.SetFloat("MusicVolume", -80);

        // PlayerPrefs.SetInt("Music", enabled ? 1 : 0);    
    }
    public void ChangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));

        // PlayerPrefs.SetFloat("Master", volume);
    }
    public void ToggleSounds(bool enabled)
    {
        if (enabled)
            Mixer.audioMixer.SetFloat("SoundsVolume", 0);
        else   
            Mixer.audioMixer.SetFloat("SoundsVolume", -80);
    }
}
