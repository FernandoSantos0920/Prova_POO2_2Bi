using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
  
    public Toggle toggleMusic;
    public Slider sliderMusica;
    public Slider sliderVolume;
    public AudioSource audioSource;
    
    public int volume;
    public int sfx;
    public bool musicOn;
    public TMP_Text textoVariação;
    
    
    void Start()
    {
        musicOn = toggleMusic.isOn;
        volume = (int) sliderMusica.value;
        sfx = (int) sliderVolume.value;
        
        
        audioSource.volume = volume;
    }

  
    void Update()
    {
        
        audioSource.volume = volume;
      
        
        
        musicOn = toggleMusic.isOn;
        volume = (int) sliderMusica.value;
        sfx = (int) sliderVolume.value;
        
        
        
        if (musicOn == true)
        {
            textoVariação.text = "Ligado";
            textoVariação.color = Color.green;
          
        }
        else
        {
            textoVariação.text = "Desligado";
            textoVariação.color = Color.red;
           
        }
        
        
    }
}
