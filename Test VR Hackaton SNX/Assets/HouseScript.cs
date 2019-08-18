using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
   public float health = 100f;

   public float loseAmount  = 20f;

    public Vector3 originalPosition;
    public Quaternion originalRotation;

   public Renderer rende{
       get{
           if(m_rend == null)
           m_rend = GetComponent<Renderer>();
           return m_rend;
       }
   }
   public Renderer m_rend;

   public bool isVisible;
   private void Start() {
       originalPosition = transform.position;
       originalRotation = transform.rotation;
   }
   
   private void OnCollisionEnter(Collision other) {
       if(other.gameObject.CompareTag("Enviroment"))
        TakeDamage(loseAmount);
   }
   public void TakeDamage(float amount){
       health -= amount;

       // if(health <=0)
         //   Die();
   }

   public void Die(){
       //Invoke("Respawn" , 5f);
       //gameObject.SetActive(false);
   }
   public void Respawn(){
       //gameObject.SetActive(true);
       transform.position = originalPosition;
       transform.rotation = originalRotation;
   }

   private void Update() {
       isVisible = rende.isVisible;
   }


}
