using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    
    public Vector3 distance;
    public Vector3 playerDistance;

    void Start()
    {
        distance = transform.position - player.transform.position; 
    }

    void FixedUpdate()
    {
        playerDistance = player.transform.position;
        transform.position = distance + player.transform.position;
    }
}
