using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dandelion : MonoBehaviour
{
    public GameObject flowerPrefab;

    public ParticleSystem flowerParticles;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Wind")){
        SpawnFlowers();
            Debug.Log("Theres WIIIIIND");
        }
    }



    public void SpawnFlowers(){
        flowerParticles.Play();

    }
}
