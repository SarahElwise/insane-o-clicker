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
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = rigidbody2D.rotation;
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0) rotation -= rotationSpeed * Time.deltaTime;
        else if (horizontal < 0) rotation += rotationSpeed * Time.deltaTime;
        rigidbody2D.SetRotation(rotation);

        Vector2 vector = rigidbody2D.position;


        float v = Input.GetAxis("Vertical");
        if (v > 0) velocity += acceleration;
        else if (v < 0) velocity -= acceleration;
        Vector2 forward = transform.up;
        vector = vector + forward * velocity * Time.deltaTime;
        rigidbody2D.MovePosition(vector);

    }

   
}
