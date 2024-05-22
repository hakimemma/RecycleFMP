using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWKEYPAD : MonoBehaviour
{
    public string correct;
    public string playerinput;
    public GameObject

    public void Keypad (string input)
    {
        playerinput += input;
        Debug.Log(playerinput);
    }
    void Update()
    {
        
    }
}
