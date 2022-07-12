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
        // _input에 값 할당
        _input = GetComponent<PlayerInput>();
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xSpeed = _input.X * speed;
        float zSpeed = _input.Y * speed;
        if(UseSpeed)
        {
            _playerRigidBody.velocity = new Vector3(xSpeed, 0f, zSpeed); // 어느 방향으로 속도를 줄 것인가?
        }
        else
        {
            _playerRigidBody.AddForce(xSpeed, 0f, zSpeed);
        }
        
        // if(_input.UP)
        // {
        //     _playerRigidBody.AddForce(0f, 0f, -speed);
        // }
        // if(_input.DOWN)
        // {
        //     _playerRigidBody.AddForce(0f, 0f, speed);
        // }
        // if(_input.LEFT)
        // {
        //     _playerRigidBody.AddForce(speed, 0f, 0f);
        // }
        // if(_input.RIGHT)
        // {
        //     _playerRigidBody.AddForce(-speed, 0f, 0f);
        // }
    }
}
