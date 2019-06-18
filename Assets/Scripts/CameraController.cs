using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; //z will always be 0, still needs to be a vector 3


    private void Start()
    {
        offset = transform.position - player.transform.position;
    }


    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
