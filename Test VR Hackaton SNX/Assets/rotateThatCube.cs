using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateThatCube : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed
    {
        get { return Virandola.virandola; }
    }

    public ui_virandola Virandola
    {
        get
        {
            if (m_virandola == null)
            {
                m_virandola = GetComponent<ui_virandola>();
            }

            return m_virandola;
        }
    }
    public ui_virandola m_virandola;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,0, speed ));
    }
}
