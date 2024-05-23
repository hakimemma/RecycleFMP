using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypad2 : MonoBehaviour
{
    public string correct;
    private string playerinput;
    public GameObject destroy;
    public GameObject panel;
    public Text text;

    bool inTrigger;

    public void Keypad (string input)
    {
        playerinput += input;
        Debug.Log(playerinput);
    }

    public void Clear()
    {
        playerinput = "";
    }

    public void Enter()
    {
        if (playerinput == correct)
        {
            Destroy(destroy);
            panel.SetActive(false);
            return;
        }

        Clear();
    }

    public void Exit()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            panel.SetActive(true);
            Clear();
        }

        text.text = playerinput;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
}