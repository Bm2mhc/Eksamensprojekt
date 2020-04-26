using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleCloudStreamingSpeechToText;

public class Startmic : MonoBehaviour
{
    public GameObject button;
    public GameObject mic;
    public GameObject Voicerec;
    GameObject clone;
    public modtagetrans mod;
    public GameObject text;
    float timer = 15;


    public void Awake()
    {
        text.SetActive(false);
    }
    public void Change()
    {
        PlayerPrefs.SetString("lokale", "null");
        clone = Instantiate(Voicerec);
        mod.stream = clone.GetComponent<StreamingRecognizer>();
        mod.startlistening();
        button.SetActive(false);
        text.SetActive(true);
        InvokeRepeating("countdown", 0.0f, 1f);       
        

    }
    public void countdown()
    { 
        if (timer == 0)
        {
            SceneManager.LoadScene("SampleScene");

        }
        else
        {
            timer -= 1;
            Debug.Log(timer);
        }
    }

    public void manual()
    {
        SceneManager.LoadScene("håndvalgt");
    }
}
