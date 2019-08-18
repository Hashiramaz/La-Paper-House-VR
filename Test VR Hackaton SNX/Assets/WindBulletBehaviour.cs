using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WindBulletBehaviour : MonoBehaviour
{
    public Rigidbody rb{
            get{
                if(m_rb == null)
                    m_rb = GetComponent<Rigidbody>();
                return m_rb;
            }
    }
    public Rigidbody m_rb;

    public float speed  = 10f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate() {
        UpdateWindMovement();
    }

    public void UpdateWindMovement(){
        rb.velocity = transform.forward * speed;

    }
    private void OnCollisionEnter(Collision other) {
        Invoke( "AutoDestroy",0.1f);
    }

    public void AutoDestroy(){
        Destroy(gameObject);
    }
}
