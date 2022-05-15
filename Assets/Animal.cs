using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]


public abstract class Animal : MonoBehaviour
{
    protected int life { get; set; }
    protected string animalName;
    protected float force=200;
    protected string favoriteFood { get; set; }
    [SerializeField] protected GameObject dialogCanvas;
    [SerializeField] protected TMP_Text textDialog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public virtual void jump()
    {
        Debug.Log("jump");
        GetComponent<Rigidbody>().AddForce(0, force, 0);
    }


    public void randomJump()
    {
        Debug.Log("RandomJump");
        Invoke("randomJump", Random.Range(5, 10));
        jump();
    }

    public void cancelJump()
    {
        CancelInvoke("randomJump");
    }


    public virtual void setName(string name)
    {
        animalName = name;
    }


    public void talk()
    {
        textDialog.text = "my name is " + animalName;
        dialogCanvas.gameObject.SetActive(true);
        Invoke("hideTalk", Random.Range(2f, 6f));
    }

    void hideTalk()
    {
        dialogCanvas.gameObject.SetActive(false);
    }

}
