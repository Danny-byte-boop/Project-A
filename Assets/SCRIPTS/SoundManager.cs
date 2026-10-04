using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        Save();
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume" ,volumeSlider.value);
    }
}
//https://www.youtube.com/watch?v=yWCHaTwVblk This is my source for the Volume Slider
//I needed a lot of help with this and was able to figure it out with this Youtuber's help