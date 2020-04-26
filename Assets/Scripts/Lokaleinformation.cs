using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lokaleinformation : MonoBehaviour
{

    private string Lokale;
    public Text Lokalenavn;
    public GameObject skema;
    public GameObject thing;
    //public Text information;
    public float timer;
    public Image Lokalekort;
    public Sprite rektor, studievejledningen, VR, innolab, proces, teori, biokemi, fysik, printer, bibliotek, teknologi, byg, musik, kantine, nordsal, tiergang, tyvergang, tredjveergang, tretilfemogføre, sekstilhalvtreds, halvtredsgang, tredsgang;
    // Start is called before the first frame update
    void Start()
    {
       Lokale = PlayerPrefs.GetString("lokale");
       InvokeRepeating("countdown", 0.0f, 1f);
        skema.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Lokalenavn.text = Lokale;
        //information.text = Lokale;

     
        Lokalekort.sprite = rektor;

        if (PlayerPrefs.GetString("lokale").Contains("Rektor"))
        {
            Lokalekort.sprite = rektor;
            skema.SetActive(true);

        } else if (PlayerPrefs.GetString("lokale").Contains("Studievejledningen"))
        {
            Lokalekort.sprite = studievejledningen;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("VR lab"))
        {
            Lokalekort.sprite = VR;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Innolab"))
        {
            Lokalekort.sprite = innolab;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Proces"))
        {
            Lokalekort.sprite = proces;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Teori"))
        {
            Lokalekort.sprite = teori;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Bio-Kemi"))
        {
            Lokalekort.sprite = biokemi;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Fysik - Laboratorium"))
        {
            Lokalekort.sprite = fysik;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Printer"))
        {
            Lokalekort.sprite = printer;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("04 - Bibliotek"))
        {
            Lokalekort.sprite = bibliotek;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("03 - Teknologi"))
        {
            Lokalekort.sprite = teknologi;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("07 - Byg"))
        {
            Lokalekort.sprite = byg;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("06 - Musik"))
        {
            Lokalekort.sprite = musik;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Kantinen - Sydsal"))
        {
            Lokalekort.sprite = kantine;
            skema.SetActive(true);
        }
        else if (PlayerPrefs.GetString("lokale").Contains("Nordsal"))
        {
            Lokalekort.sprite = nordsal;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("10'er gang"))
        {
            Lokalekort.sprite = tiergang;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("20'er gang"))
        {
            Lokalekort.sprite = tyvergang;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("30'er gang"))
        {
            Lokalekort.sprite = tredjveergang;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("43 - 44 - 45"))
        {
            Lokalekort.sprite = tretilfemogføre;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("46 - 47 - 48 - 49 - 50"))
        {
            Lokalekort.sprite = sekstilhalvtreds;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("50'er gang"))
        {
            Lokalekort.sprite = halvtredsgang;
        }
        else if (PlayerPrefs.GetString("lokale").Contains("60'er gang"))
        {
            Lokalekort.sprite = tredsgang;
        }



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
          // Debug.Log(timer);
        }
    }

    public void leave()
    {
        timer = 0;
    }
}
