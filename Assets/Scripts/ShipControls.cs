using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float rotation;
    float speedLimit;
    float acceleration=0.1f;
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
        float vertical = Input.GetAxis("Vertical");

        if (vertical > 0) velocity += acceleration;
        else if (vertical < 0) velocity -= acceleration;

        Vector2 position = rigidbody2D.position;
        position.y += velocity * Time.deltaTime;
        rigidbody2D.MovePosition(position);

    }
}
