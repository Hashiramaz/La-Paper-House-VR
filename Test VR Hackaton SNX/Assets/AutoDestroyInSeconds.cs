using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyInSeconds : MonoBehaviour
{
    public float secondsToDestroy = 5f;

     private void Start() {
         Invoke("AutoDestroy",secondsToDestroy);
    }

    public void AutoDestroy(){
        Destroy(gameObject);
    }
}
