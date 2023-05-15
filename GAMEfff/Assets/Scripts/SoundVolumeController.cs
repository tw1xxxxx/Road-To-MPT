using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolumeController : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField] private string saveVolumeKey;
    [SerializeField] private string sliderTag;
    [SerializeField] private string textVolumeTag;
    [SerializeField] float volume;
private void Awake(){
    if (PlayerPrefs.HasKey(this.saveVolumeKey)){
        this.volume = PlayerPrefs.GetFloat(this.saveVolumeKey);
        this.audio.volume = this.volume;
        GameObject sliderObg = GameObject.FindWithTag(this.sliderTag);
        if(sliderObg != null){
            this.slider = sliderObg.GetComponent<Slider>();
            this.slider.value = this.volume;
        }
    }
    else
    {
        this.volume = 0.5f;
        PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
        this.audio.volume = this.volume;
        
    }
}

private void LateUpdate(){
    GameObject sliderObg = GameObject.FindWithTag(this.sliderTag);
    if(sliderObg != null)
    {
        this.slider= sliderObg.GetComponent<Slider>();
        this.volume = slider.value;
        
        if(this.audio.volume != this.volume){
            PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
        }
        
        GameObject textObg = GameObject.FindWithTag(this.textVolumeTag);
        
        if(textObg != null){
            this.text = textObg.GetComponent<Text>();
            this.text.text = Mathf.Round(this.volume * 100) + "%";
        }
    }
    
    this.audio.volume = this.volume;
}}
//layerPrefsSetAudioSource(this.audio);