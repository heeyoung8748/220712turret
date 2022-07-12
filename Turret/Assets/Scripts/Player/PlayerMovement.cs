using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    public Rigidbody _playerRigidBody;
    public float speed = 8f;
    public bool UseSpeed = false;
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float xSpeed = _input.X * speed;
        float zSpeed = _input.Y * speed;
        if(UseSpeed)
        {
            _playerRigidBody.velocity = new Vector3(xSpeed, 0f, zSpeed); 
        }
        else
        {
            _playerRigidBody.AddForce(xSpeed, 0f, zSpeed);
        }
        
    }
}
