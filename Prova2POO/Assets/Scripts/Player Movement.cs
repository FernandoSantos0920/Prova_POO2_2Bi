using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    private int velocidade = 7;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(velocidade * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
        }
        
        
    }
}
