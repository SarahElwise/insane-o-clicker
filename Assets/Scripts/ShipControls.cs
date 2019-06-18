using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float rotationSpeed = 200.0f;
    float rotation;
    public float speedLimit = 4f;
    public float acceleration=.1f;
    public int maxHealth = 100;
    int currentHealth;
    Vector2 velocityV;
    public int Health
    {
        get {return currentHealth;}
        set {currentHealth = value;}
    }

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

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //change direction
        float rotation = rigidbody2D.rotation;
        rotation -= rotationSpeed * Time.deltaTime * horizontal;
        rigidbody2D.SetRotation(rotation);


        //position controls
        Vector2 position = rigidbody2D.position;
        Vector2 forward = transform.up;
        velocityV += vertical * forward * acceleration;
        position += velocityV * Time.deltaTime;
        rigidbody2D.MovePosition(position);


        if (vertical != 1 && (velocityV.x != 0 || velocityV.y != 0))
        {
            Vector2 slowdownFactor = velocityV * .01f;


            if (Mathf.Abs(slowdownFactor.x) > Mathf.Abs(velocityV.x))
                slowdownFactor.x = velocityV.x;

            if (Mathf.Abs(slowdownFactor.y) > Mathf.Abs(velocityV.y))
                slowdownFactor.y = velocityV.y;

            velocityV = velocityV - slowdownFactor;
        }
        Debug.Log(velocityV);
        
    }
    
}
