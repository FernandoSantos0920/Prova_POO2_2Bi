using UnityEngine;

public class Personagem : MonoBehaviour
{
   [SerializeField] private int energias;
   [SerializeField] private int vidas;
   [SerializeField] private float velocidade = 7f;


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


    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }


    public float getVelocidade()
    {
        return this.velocidade;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
