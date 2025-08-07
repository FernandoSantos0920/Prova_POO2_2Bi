using UnityEngine;
using UnityEngine.UI;

public class BarraStatus : MonoBehaviour
{
    
    
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergias;
    
    
    void Start()
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getVidas();
        
        sliderEnergias.minValue = 0;
        sliderEnergias.maxValue = personagem.getEnergias();
    }

   
    void Update()
    {
        sliderVidas.value = personagem.getVidas();
        sliderEnergias.value = personagem.getEnergias();
    }
}
