using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleCloudStreamingSpeechToText;

public class Startmic : MonoBehaviour
{
    public GameObject button;
    public GameObject mic;
    public GameObject Voicerec;
    public modtagetrans mod;
    float timer = 10;
     public void Change()
    {

        Instantiate(mic);
        mod.stream = Instantiate(Voicerec).GetComponent<StreamingRecognizer>();
        mod.startlistening();
        button.SetActive(false);
        InvokeRepeating("countdown", 0.0f, 1f);
        if (timer > 0)
        {
            Debug.Log(timer + "i change");
        }else if(timer == 0)
        {
            Debug.Log("done");
        }

       
           
        

    }
    public void countdown()
    { 
        if (timer == 0)
        {
            CancelInvoke();
            button.SetActive(true);

        }
        else
        {
            timer -= 1;
            Debug.Log(timer);
        }
    }
}
