using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;
    public Transform player;
    private bool _canTurretAttack = false;
    private float _elapsedTime = 0.0f;
    private float _stdTime = 0.5f;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _canTurretAttack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _canTurretAttack = false;
        }
    }
    private void TurretAttack()
    {
        transform.LookAt(player.transform);
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= _stdTime)
        {
            _elapsedTime = 0.0f;
            GameObject bullet = Instantiate(bulletPrefab, bulletPos.position, bulletPos.rotation);
        }
    }

    void TurretSpin()
    {
        transform.Rotate(0f, _stdTime, 0f);
        _elapsedTime = _stdTime;
    }
    
    void Update()
    {
        if(_canTurretAttack && player.gameObject.activeSelf)
        {
            TurretAttack();
        }
        else
        {
            TurretSpin();
        }
        
    }
}
