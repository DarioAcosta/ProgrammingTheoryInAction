using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("randomJump", Random.Range(3, 6));

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void jump()
    {
        //base.jump();
        Debug.Log("jump cats");

        GetComponent<Rigidbody>().AddForce(0, force*3, 0);
    }
}
