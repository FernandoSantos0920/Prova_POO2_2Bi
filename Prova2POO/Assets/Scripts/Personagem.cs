using UnityEngine;

public class Personagem : MonoBehaviour
{
    private int energias;
    private int vidas;



    public void setVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getVidas()
    {
        return this.vidas;
    }

    public void setEnergias(int energias)
    {
        this.energias = energias;
    }

    public int getEnergias()
    {
        return this.energias;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
