using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class ui_virandola : MonoBehaviour
{
    SerialPort vir = new SerialPort("COM7", 9600);
    public float virandola = 0;
    public float reduction = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        vir.Open();
        vir.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (vir.IsOpen)
        {
            try
            {
                //Apenas pra Debug
                //print();

                virandola = reduce_value(float.Parse(vir.ReadLine()), reduction);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
    
    public float reduce_value(float amount, float reduction)
    {
        return amount / reduction;
    } 
}
