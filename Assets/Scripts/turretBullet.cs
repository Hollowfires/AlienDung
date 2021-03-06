﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretBullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Player")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            collision.gameObject.GetComponent<PlayerHealth>().PlayerTakeDamage(damage);
            //Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }
}
