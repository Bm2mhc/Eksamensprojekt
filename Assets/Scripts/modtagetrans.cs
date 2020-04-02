using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            Debug.Log("Yep " + transcript);

        } else if (transcript == "lokale 11"){
            Debug.Log("ens");
            System.Array.ForEach(lokaletiergang, Debug.Log);
        }
        else if (System.Array.IndexOf(studieadmin, transcript) != -1)
        {
            Debug.Log("Yep " + transcript);
          

        }
        else if (System.Array.IndexOf(vrlab, transcript) != -1)
        {
            Debug.Log("Yep " + transcript);
            

        }
        else if (System.Array.IndexOf(innolab, transcript) != -1)
        {
            Debug.Log("Yep " + transcript);

        }
        else if (System.Array.Exists(tiergang, s=> s == transcript) || System.Array.Exists(lokaletiergang, s => s == transcript))
        {
            Debug.Log("Yep " + transcript);

        }
        else if (System.Array.IndexOf(proces, transcript) != -1)
        {
            Debug.Log("Yep " + transcript);

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
