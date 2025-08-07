using UnityEngine;

public class PlayerMovement : Personagem
{


  
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }
        
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            int vidas = getVidas() - 1;
            setVidas(vidas);
        }
    }
    
    
}
