using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float rotationSpeed = 200.0f;
    float rotation;
    float speedLimit;
    float acceleration=.1f;
    public int maxHealth = 100;
    int currentHealth;
    Vector2 velocityV;
    public int Health
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }
    float velocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rigidbody2D = GetComponent<Rigidbody2D>();
        velocityV.x = 0.0f;
        velocityV.y = 0.0f;
    }

    
    
   

    // Update is called once per frame
    void Update()
    {
        //change direction
        float rotation = rigidbody2D.rotation;
        float horizontal = Input.GetAxis("Horizontal");
        rotation -= rotationSpeed * Time.deltaTime * horizontal;
        rigidbody2D.SetRotation(rotation);

        //change position
        Vector2 vector = rigidbody2D.position;
        float v = Input.GetAxis("Vertical");
        //velocity += acceleration * v;
        Vector2 forward = transform.up;
        //vector = vector + forward * velocity * Time.deltaTime;
        //rigidbody2D.MovePosition(vector);

        velocityV += v * forward * acceleration;
        vector += velocityV * Time.deltaTime;
        rigidbody2D.MovePosition(vector);



    }

   
}
