using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("talk", Random.Range(2f, 4f));
        Invoke("randomJump", Random.Range(3f, 6f));

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

    public override void setName(string name)
    {
        if (name.Length >= 6)
        {
            name.Substring(0, 5);
        }
        base.setName(name);
    }




}
