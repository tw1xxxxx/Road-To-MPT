using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoCache
{
    public string volumeParameter = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;
    private const float _multiplier = 20f;

    private void Awake() => slider.onValueChanged.AddListener(HandleSliderValueChanged);
    
    private void HandleSliderValueChanged(float value)
    {
    PlayerPrefs.SetFloat("volumeParameter", Mathf.Log10(value) * _multiplier);
    mixer.SetFloat(volumeParameter, PlayerPrefs.GetFloat("volumeParameter", Mathf.Log10(slider.value) * _multiplier));
    }
    private void OnDisable() => PlayerPrefs.SetFloat(volumeParameter, PlayerPrefs.GetFloat("volumeParameter", Mathf.Log10(slider.value) * _multiplier));
    
    void Start()
    {
        PlayerPrefs.GetFloat("volumeParameter", Mathf.Log10(slider.value) * _multiplier); 
        slider.value = Mathf.Pow(10f, PlayerPrefs.GetFloat("volumeParameter", Mathf.Log10(slider.value) * _multiplier) / _multiplier);
    }

    public override void OnTick() => PlayerPrefs.GetFloat("volumeParameter", Mathf.Log10(slider.value) * _multiplier);
    
}
