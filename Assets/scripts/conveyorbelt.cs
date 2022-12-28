using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyorbelt : MonoBehaviour
{

    public Rigidbody rBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void FixedUpdate()
    {
        move();
        
        
        
    }

    public void move()
        {
        Vector3 pos = rBody.position;
        rBody.position += transform.forward*speed*Time.fixedDeltaTime;
        rBody.MovePosition(pos);

        }


}
