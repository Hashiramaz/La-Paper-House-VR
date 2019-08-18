using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
   public float health = 100f;

   public float loseAmount  = 20f;

    public Vector3 originalPosition;
   
   private void Start() {
       originalPosition = transform.position;
   }
   
   private void OnCollisionEnter(Collision other) {
       if(other.gameObject.CompareTag("Enviroment"))
        TakeDamage(loseAmount);
   }
   public void TakeDamage(float amount){
       health -= amount;

        if(health <=0)
            Die();
   }

   public void Die(){
       Invoke("Respawn" , 5f);
       gameObject.SetActive(false);
   }
   public void Respawn(){
       gameObject.SetActive(true);
       transform.position = originalPosition;
   }
}
