using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class skiptotut : MonoBehaviour
{
    // Start is called before the first frame update
   public void retry()
    {
        SceneManager.LoadScene("tutorial");
    }

}

