using UnityEngine;
using System.Collection.generic;
using system.collections;
using UnityStandardAssets.Characters.FirstPerson;

public class note : MonoBehaviour
{
    public Gameobject player;
    public Gameobject noteUI;
    public Gameobject hud;
    public Gameobject inv;
    
    public Gameobject pickupText;

    public AudioSource pickUpSound;

    public bool inReach;


    void start()
    {
        noteUI.SetActive(false);
        hud.SetActive(true);
        inv.SetActive(true);
        pickupText.SetActive(false);

        inReach = false;
    }

   
}
