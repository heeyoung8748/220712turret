using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletPos;
    public GameObject playerObject;
    public Transform player;
    public bool canTurretAttack = false;
    public float elapsedTime = 0.0f;

    public GameObject Target { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canTurretAttack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            canTurretAttack = false;
        }
    }
    private void TurretAttack()
    {
        elapsedTime += Time.deltaTime;
        this.transform.LookAt(playerObject.transform);
        if(elapsedTime >= 0.5f)
        {
            elapsedTime = 0.0f;
            GameObject bullet = Instantiate(BulletPrefab, BulletPos.position, BulletPos.rotation);
            bullet.transform.LookAt(player);
        }
    }

    void TurretSpin()
    {
        elapsedTime = 0.5f;
        transform.Rotate(0f, 0.5f, 0f);
    }
    
    void Update()
    {
        if(canTurretAttack)
        {
            TurretAttack();
        }
        else
        {
            TurretSpin();
        }
        
    }
}
