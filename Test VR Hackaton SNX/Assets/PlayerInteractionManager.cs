using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionManager : MonoBehaviour
{
    public Transform initialLinecast;
    public Transform finalLinecast;

    public         RaycastHit _out; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     UpdateLinecast();   
    }

    public void UpdateLinecast(){


          Physics.Linecast(initialLinecast.position,finalLinecast.position,out _out);

          //if(_out.collider)
           // Debug.Log("Estamos tocando no objecto " + _out.collider);

    }


    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        if(initialLinecast != null && finalLinecast != null)
            Gizmos.DrawLine(initialLinecast.position,  finalLinecast.position);
    }
}
