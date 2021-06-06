using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicPlay : MonoBehaviour
{ 
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public float MusicVolume = 0f;

    private void Start()
    {
        volumeSlider.value = MusicVolume;
    }
    private void Update()
    {
        audioMixer.SetFloat("volume", MusicVolume);
    }
    public void SetVolume(float volume)
    {
        MusicVolume = volume;
    }
}
