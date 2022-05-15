using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePet : MonoBehaviour
{
    public Cat catPrefab;
    public Dog dogPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("generatePet", Random.Range(3, 9));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generatePet()
    {
        Invoke("generatePet", Random.Range(3, 9));
        int opt=Random.Range(0, 2);
        switch (opt)
        {
            case 0:
                {
                    generateCat();
                    break;
                }
            case 1:
                {
                    generateDog();
                    break;
                }
        }
    }



    void generateCat()
    {
        Instantiate(catPrefab);
    }
    void generateDog()
    {
        Instantiate(dogPrefab);
    }



}
