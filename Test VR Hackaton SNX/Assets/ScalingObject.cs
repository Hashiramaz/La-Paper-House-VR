﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingObject : MonoBehaviour
{
    public AnimationCurve curve;
    public float amounToMultiply = 10;
    public float debugvariable;

    public Vector3 ScaleUp;
    public Vector3 scaleDefault;

    public bool buttonScale;
    public bool buttonPressed;

    //public bool 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateVariable();
           // buttonScale = Input.GetButton("Jump");

        if(buttonScale && !buttonPressed){
            buttonPressed = true;
            ScaleScenaryUp();

        }

        if(!buttonScale && buttonPressed){
            buttonPressed = false;
            ScaleNormal();

        }

    }

    public void UpdateVariable(){
       debugvariable = curve.Evaluate(Time.realtimeSinceStartup);
       debugvariable *= amounToMultiply;
       transform.localScale = new Vector3(debugvariable, debugvariable,debugvariable);
        
    }


    public void ScaleScenaryUp() {
        Debug.Log("SetToMinScale");
        iTween.ScaleTo(gameObject,ScaleUp,10);
    }

    public void ScaleNormal(){
        iTween.ScaleTo(gameObject, scaleDefault ,10);
    }
}
