using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("talk", Random.Range(2f, 4f));

        Invoke("randomJump", Random.Range(5, 30));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -50)
        {
            Destroy(gameObject);
        }
    }

    public override void jump()
    {
        GetComponent<Rigidbody>().AddForce(0, force*1.5f, 0);
    }
}
