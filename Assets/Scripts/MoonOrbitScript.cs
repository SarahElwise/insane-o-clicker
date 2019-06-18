using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbitScript : MonoBehaviour
{
    public float speed;
    public GameObject originatorPlanet;
    private Vector3 center;

    private void Start()
    {
        center = originatorPlanet.transform.position;
    }

    void Update()
    {
        transform.RotateAround(center,transform.forward, speed*Time.deltaTime);
    }
}
