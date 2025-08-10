using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
  
    public Toggle toggleMusic;
    public Slider sliderVolume;
    public Slider sliderSFX;
    
    public int volume;
    public int sfx;
    public bool musicOn;
    public TMP_Text textoVariação;
    
    
    void Start()
    {
        musicOn = toggleMusic.isOn;
        volume = (int) sliderVolume.value;
        sfx = (int) sliderSFX.value;
    }

  
    void Update()
    {
        
        musicOn = toggleMusic.isOn;
        volume = (int) sliderVolume.value;
        sfx = (int) sliderSFX.value;
        
        
        
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
