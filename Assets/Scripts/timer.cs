using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{

    int tid = 120;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("countdown", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void countdown()
    {
        if (tid == 0)
        {
            SceneManager.LoadScene("SampleScene");

        }
        else
        {
            tid -= 1;
           // Debug.Log(tid);
        }
    }
}
