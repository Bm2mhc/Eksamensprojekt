using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lokaleinformation : MonoBehaviour
{

    private string Lokale;
    public Text Lokalenavn;
    public float timer = 120;
    // Start is called before the first frame update
    void Start()
    {
       Lokale = PlayerPrefs.GetString("lokale");
       InvokeRepeating("countdown", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Lokalenavn.text = Lokale;
        
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
}
