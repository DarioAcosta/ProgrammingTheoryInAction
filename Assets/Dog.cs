using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("randomJump", Random.Range(5, 30));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void jump()
    {
        GetComponent<Rigidbody>().AddForce(0, force*1.5f, 0);
    }
}