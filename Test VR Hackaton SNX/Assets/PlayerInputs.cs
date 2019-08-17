using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public bool buttonPressed;

    public bool buttonActive;

    private void Update() {
        UpdateInputs();
    }    
    
    public void UpdateInputs(){

        
        buttonPressed = Input.GetMouseButton(0);

        if(buttonPressed && !buttonActive){
            buttonActive = true;


            Debug.Log("Botão Pressionado");
            SendMessageToSpawnObject();

        }

        if(!buttonPressed && buttonActive){
            buttonActive = false;

             Debug.Log("Botão Solto");
            

        }




    }

public void SendMessageToSpawnObject(){
    transform.SendMessage("SpawnObject");
}
}
