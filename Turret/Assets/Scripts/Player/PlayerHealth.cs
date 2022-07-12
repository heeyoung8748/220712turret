using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Bullet")
        {
            Die();
            Debug.Log($"[OnTriggerEnter] Me: {gameObject.name}, Other : {other.name}");
        }
    }
}
