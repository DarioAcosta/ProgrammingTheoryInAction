using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MM : MonoBehaviour
{
    public TMP_InputField input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
    {
        PlayerName.instance.playerName = input.text;
        SceneManager.LoadScene("SampleScene");
    }


}
