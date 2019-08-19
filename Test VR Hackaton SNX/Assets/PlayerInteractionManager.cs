using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionManager : MonoBehaviour
{
    public Transform initialLinecast;
    public Transform finalLinecast;

    public PlayerInputs playerInputs{
        get{
            if(m_playerInputs == null)
                m_playerInputs = GetComponent<PlayerInputs>();
            return m_playerInputs;
        }
    }
    protected PlayerInputs m_playerInputs;
    
    //public ScalingObject scalingManager;
    
    public         RaycastHit _out; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     UpdateLinecast();   
        UpdateRespiration();
    }

public void UpdateRespiration(){
    //scalingManager.buttonScale = playerInputs.virandola.virandola > 0;
   // scalingManager.buttonScale = Input.GetButton("Fire1");
}

    public void UpdateLinecast(){


          Physics.Linecast(initialLinecast.position,finalLinecast.position,out _out);
        
        if(_out.collider)
          if(_out.collider.isTrigger)
                if(_out.collider.gameObject.CompareTag("House")){
                    //aqui resetar posição da house
                    _out.collider.gameObject.GetComponentInChildren<HouseScript>().Respawn();
                }
           // Debug.Log("Estamos tocando no objecto " + _out.collider);

    }


    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        if(initialLinecast != null && finalLinecast != null)
            Gizmos.DrawLine(initialLinecast.position,  finalLinecast.position);
    }
}
