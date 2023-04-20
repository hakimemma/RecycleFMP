using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouchh : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public bool crouched;
    public float normalHeight, crouchHeight;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            crouched = !crouched;
            if (crouched)
            {
                transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
                //PlayerHeight.height = crouchHeight;
                //playerCol.height = crouchHeight;
                //player.position = player.position + offset;

            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x, normalHeight, transform.localScale.z);
                //PlayerHeight.height = normalHeight;
                //playerCol.height = normalHeight;
            }

        }
        if (Input.GetKeyDown(KeyCode.C))
        {

        }

    }
}
