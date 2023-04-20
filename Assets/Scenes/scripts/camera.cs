using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float yRotation = 0f;

    public bool just_lock;

    public bool will_we_lock;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        if(will_we_lock) 
        {
            Cursor.lockState = CursorLockMode.Locked;
        } else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!just_lock) 
        {
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            yRotation -= mouseY;

            yRotation = Mathf.Clamp(yRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);  
        }
    }
}
