using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingObject : MonoBehaviour
{
    public AnimationCurve curve;

    public float debugvariable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVariable();
    }

    public void UpdateVariable(){
       debugvariable = curve.Evaluate(Time.realtimeSinceStartup);
       transform.localScale = new Vector3(debugvariable, debugvariable,debugvariable);
        
    }
}
