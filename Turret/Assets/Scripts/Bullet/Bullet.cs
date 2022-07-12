using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 0.05f;
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
           transform.Translate(0f, 0f, bulletSpeed);
    }

}
