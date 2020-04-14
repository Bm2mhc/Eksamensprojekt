using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleCloudStreamingSpeechToText;

public class modtagetrans : MonoBehaviour
{
    // Start is called before the first frame update
    public StreamingRecognizer stream;
    public string[] lokaler;

    public string[] rektor = new string[] { "rektor", "rejser", "actor" };
    public string[] studieadmin = new string[] { "studieadministration", "studieadministrationen" };
    public string[] vrlab = new string[] { "vr-lab", "vr lab", "vr lap", "vi er lab", "vr", "VR Lab", "DR app", "VR" };
    public string[] innolab = new string[] { "innolab", "inno lab" };
    public string[] tiergang = new string[]{"11", "12", "13", "14", "15", "16", "17", "18"};
    public string[] lokaletiergang = new string[] { "lokale 11", "lokale 12", "lokale 13", "lokale 14", "lokale 15", "lokale 16", "lokale 17", "lokale 18" };
    public string[] tyvergang = new string[]{"21", "22", "23", "24", "25"};
    public string[] tredvegang = new string[] { "31", "32" };
    public string[] foretilfemgang = new string[] { "43", "44", "45" };
    public string[] sekstilfalvtreds = new string[] { "46", "47", "48", "49", "50" };
    public string[] halvtredsgang = new string[] { "51", "52", "53", "54" };
    public string[] tredsgang = new string[] { "60", "61", "62", "63" };
    public string[] proces = new string[] { "proces", "process", "prosa", "protest", "74" };
    public string[] teori = new string[] { "teori", "design", "73" };
    public string[] biokemi = new string[] { "biokemi", "kemi", "72" };
    public string[] fysik = new string[] { "fysik", "71" };
    public string[] printer = new string[] { "print", "printe", "printer", "printeren", "printere", "printerne" };
    public string[] bibliotek = new string[] { "bibliotek", "biblioteket" };
    public string[] teknologi = new string[] { "teknologi" };
    public string[] byg = new string[] { "byg", "Byg", "by" };
    public string[] musik = new string[] { "musik" };
    public string[] kantine = new string[] { "syd", "kantine", "sydsal", "syd sal", "kantinen" };
    public string[] nordsal = new string[] { "nord", "nordsal", "nord sal", "nordsalen" };

    void Modtage(string transcript)
    {
        Debug.Log(transcript);
        if (System.Array.IndexOf(rektor, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Rektor");
            Debug.Log("Yep " + transcript);
            Debug.Log(PlayerPrefs.GetString("lokale"));
            SceneManager.LoadScene("roadmap");
           

        }
        else if (System.Array.IndexOf(studieadmin, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Studieadministration");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");


        }
        else if (System.Array.IndexOf(vrlab, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "VR lab");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");


        }
        else if (System.Array.IndexOf(innolab, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Innolab");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(proces, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Proces");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(teori, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Teori");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(biokemi, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Bio-Kemi");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }
        else if (System.Array.IndexOf(fysik, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Fysik - Laboratorium");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }
        else if (System.Array.IndexOf(printer, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Printer");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }else if (System.Array.IndexOf(bibliotek, transcript) != -1)
        {

            PlayerPrefs.SetString("lokale", "04 - Bibliotek");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }else if (System.Array.IndexOf(teknologi, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "03 - Teknologi");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        } else if (System.Array.IndexOf(byg, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "07 - Byg");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        } else if (System.Array.IndexOf(musik, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "06 - Musik");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        } else if (System.Array.IndexOf(kantine, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Kantinen - Sydsal");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        } else if (System.Array.IndexOf(nordsal, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "Nordsal");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }
        else if (System.Array.IndexOf(tiergang, transcript) !=-1)
        {
            PlayerPrefs.SetString("lokale", "10'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(lokaletiergang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "10'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(tyvergang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "20'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(tredvegang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "30'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(foretilfemgang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "43 - 44 - 45");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(sekstilfalvtreds, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "46 - 47 - 48 - 49 - 50");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (System.Array.IndexOf(halvtredsgang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "50'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        } else if (System.Array.IndexOf(tredsgang, transcript) != -1)
        {
            PlayerPrefs.SetString("lokale", "60'er gang");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");
        }


    }
    public void startlistening()
    {
        //stream.onInterimResult.AddListener(Modtage);
        stream.onFinalResult.AddListener(Modtage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
