using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWindWeapon : MonoBehaviour
{
    public PlayerInputs playerInputs;
    public GameObject bulletPrefab;

    public Transform[] bulletpoints;

    public float firingRate;

    public float nextTimeToFire;


     private void Update() {
        UpdateShooting();
    }
    public void UpdateShooting(){
        if(playerInputs.buttonShootActive){

            if(Time.time> nextTimeToFire)
                Shoot();
        }
        
    }

    public void Shoot(){
//        Debug.Log("Atirando");
        for (int i = 0; i < bulletpoints.Length; i++)
        {
            
        Instantiate(bulletPrefab,bulletpoints[i].position,bulletpoints[i].rotation);
        }

        nextTimeToFire = Time.time + firingRate;

    }
}
