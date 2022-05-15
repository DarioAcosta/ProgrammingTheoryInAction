using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePet : MonoBehaviour
{
    public Cat catPrefab;
    public Dog dogPrefab;

    string[] catsName = { "mishi", "pspspspsps", "catcatcat","catName","cat","kesha"};
    string[] dogsName = {"doggy","goodboy","dogdogdog","dogName","scooby","bigDog"};
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
        Cat cat= Instantiate(catPrefab);
        cat.setName(catsName[Random.Range(0, catsName.Length)]);
        cat.transform.rotation.SetEulerRotation(0, Random.Range(0,359f), 0);
    }
    void generateDog()
    {
        Dog dog=Instantiate(dogPrefab);
        dog.setName(dogsName[Random.Range(0,dogsName.Length)]);
        dog.transform.rotation.SetEulerRotation(0, Random.Range(0, 359f), 0);

    }



}
