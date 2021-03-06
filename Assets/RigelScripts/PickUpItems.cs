﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public enum pickUpObject{AMMO, Health};
    public pickUpObject currentObject;
    //TODO: Pick up health and/or ammo
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (currentObject == pickUpObject.AMMO)
            {
                collision.GetComponent<PlayerAmmoScript>().changeAmmo(RandomQuantity());
            }
            else if (currentObject == pickUpObject.Health)
            {
                if(collision.GetComponent<PlayerHealth>().health >= 100)
                {
                    //do nothing
                }
                else
                {
                    collision.GetComponent<PlayerHealth>().PlayerGainHealth(25);
                }
                
            }
            Destroy(this.gameObject);
        }
    }

    public int RandomQuantity()
    {
        //random value between 1-5
        int count = Random.Range(1,5);
        Debug.Log(count);
        return count;
    }
}
