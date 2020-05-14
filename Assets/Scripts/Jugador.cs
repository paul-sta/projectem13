using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float Velocitat = 4.0f;
    public Rigidbody rb;
    private float Xmovement = 0.0f;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        Vector3 Direction = new Vector3(Xmovement, 0, 0);
        //rb.AddForce(Direction.normalized * Velocitat);
    
        if (Direction.y !=0 || Direction.x != 0)
        {
            rb.AddForce(Direction.normalized * Velocitat);
           
        } else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        rb.velocity = new Vector2(
            Mathf.Clamp(rb.velocity.x, -Velocitat, Velocitat),
            Mathf.Clamp(rb.velocity.y, -Velocitat, Velocitat));
        
        

    }
    


    public void XMOVEMENT(float X)
    {
        Xmovement = X;

    }
}
