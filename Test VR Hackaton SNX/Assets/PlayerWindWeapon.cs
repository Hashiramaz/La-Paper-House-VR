using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWindWeapon : MonoBehaviour
{
    public PlayerInputs playerInputs;
    public GameObject bulletPrefab;

    public Transform bulletpoint;

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

        Instantiate(bulletPrefab,bulletpoint.position,bulletpoint.rotation);

        nextTimeToFire = Time.time + firingRate;

    }
}
