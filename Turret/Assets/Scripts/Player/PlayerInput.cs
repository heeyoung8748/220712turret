using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool UP { get; private set; }
    public bool DOWN { get; private set; }
    public bool LEFT { get; private set; }
    public bool RIGHT { get; private set; }
    
    public float X {get; private set;}
    public float Y {get; private set;}

    void Update()
    {
        X = Y = 0f;

            X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Vertical");
            UP = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            DOWN = Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S);
            RIGHT = Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D);
            LEFT = Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A);
        
    }
}
