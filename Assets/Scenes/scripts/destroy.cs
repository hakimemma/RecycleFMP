using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Destroy(cube,7f);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}