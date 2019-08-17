using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInputs))]
[RequireComponent(typeof(PlayerInteractionManager))]
public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
#region ChatchReferencea
    public PlayerInputs playerInputs{
        get{
            if(m_playerInputs == null)
            m_playerInputs = GetComponent<PlayerInputs>();
            return m_playerInputs;
        }
    }
    public PlayerInputs m_playerInputs;
    public PlayerInteractionManager playerInteractions{
        get{
            if(m_playerInteractions == null)
             m_playerInteractions = GetComponent<PlayerInteractionManager>();
             return m_playerInteractions;
        }
    }
    public PlayerInteractionManager m_playerInteractions;

    #endregion
    
    public GameObject ObjToSpawn; 

    public void SpawnObject(){
        Debug.Log("Spawning Object");
        if(playerInteractions._out.collider == null)
            return;

        Instantiate(ObjToSpawn,playerInteractions._out.point,Quaternion.Euler( playerInteractions._out.normal));

    }
}
