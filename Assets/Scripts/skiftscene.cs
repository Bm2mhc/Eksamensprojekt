using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiftscene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void skema()
    {
        SceneManager.LoadScene("Skema");
    }

    public void tilbage()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void tilbageroad()
    {
        SceneManager.LoadScene("roadmap");
    }
}
