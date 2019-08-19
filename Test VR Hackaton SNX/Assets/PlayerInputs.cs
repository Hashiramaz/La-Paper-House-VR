using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInteractionManager))]
[RequireComponent(typeof(ui_virandola))]
public class PlayerInputs : MonoBehaviour
{
    public bool buttonShootPressed;

    public bool buttonShootActive;

    

    public PlayerInteractionManager playerInteraction{
        get{
            if(m_playerinteraction == null)
                m_playerinteraction = GetComponent<PlayerInteractionManager>();
            return m_playerinteraction;
        }

    }    public PlayerInteractionManager m_playerinteraction;

    public ui_virandola virandola{
        get{
            if(m_virandola == null)
                m_virandola = GetComponent<ui_virandola>();
            return m_virandola;
        }
    }
    public ui_virandola m_virandola;
    
    
    private void Update() {
        UpdateInputs();
    }    
    
    public void UpdateInputs(){

       //#if UNITY_EDITOR
       //buttonShootPressed = Input.GetButton("Fire1");

       //#else
        buttonShootPressed = (virandola.virandola > 0 );         
        //#endif
        if(buttonShootPressed && !buttonShootActive){
            buttonShootActive = true;


            Debug.Log("Botão Pressionado");
            //SendMessageToSpawnObject();

            FindObjectOfType<AudioManager>().StartHigherVolume("WindMusic");

        }

        if(!buttonShootPressed && buttonShootActive){
            buttonShootActive = false;

             Debug.Log("Botão Solto");
            FindObjectOfType<AudioManager>().StartLowerVolume("WindMusic");

        }




    }

   public void SendMessageToInteractWithObject(){

   }
}
