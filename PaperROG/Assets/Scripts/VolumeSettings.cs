using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixerGroup Mixer;

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
        if(enabled)
            Mixer.audioMixer.SetFloat("Music", 0);
        else  
            Mixer.audioMixer.SetFloat("Music", -80);
    }
    public void ChangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("Master", Mathf.Lerp(-80, 0, volume));
    }
    public void ToggleSounds(bool volume)
    {
        if(enabled)
            Mixer.audioMixer.SetFloat("Sounds", 0);
        else   
            Mixer.audioMixer.SetFloat("Sounds", -80);
    }
}
