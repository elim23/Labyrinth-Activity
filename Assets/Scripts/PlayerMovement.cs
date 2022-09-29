using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    Camera cam;
    public CharacterController controller;
    public float turnSpeed = 10f;

    void Start ()
    {
        cam = Camera.main;
    }

    void FixedUpdate ()
    {

    }

    void Update ()
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * turnSpeed * Time.deltaTime);
    }
}
