using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleCloudStreamingSpeechToText;

public class modtagetrans : MonoBehaviour
{
    // Start is called before the first frame update
    public StreamingRecognizer stream;
    public Text whatihear;

    void Modtage(string transcript)
    {
        if (transcript.Contains("rektor"))
        {
            PlayerPrefs.SetString("lokale", "Rektor");
            PlayerPrefs.SetString("roomid", "15033222473");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("studievejledningen") || transcript.Contains("studievejledning"))
        {
            PlayerPrefs.SetString("lokale", "Studievejledningen");
            PlayerPrefs.SetString("roomid", "15033222472");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("VR") || transcript.Contains("vr"))
        {
            PlayerPrefs.SetString("lokale", "VR lab");
            PlayerPrefs.SetString("roomid", "29296243158");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("innolab") || transcript.Contains("inno lab"))
        {
            PlayerPrefs.SetString("lokale", "Innolab");
            PlayerPrefs.SetString("roomid", "null");
            PlayerPrefs.SetString("innolab 2", "19804903661");
            PlayerPrefs.SetString("innolab 3", "15033222475");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("proces") || transcript.Contains("process") || transcript.Contains("74"))
        {
            PlayerPrefs.SetString("lokale", "Proces");
            PlayerPrefs.SetString("roomid", "15033222464");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("teori") || transcript.Contains("design") || transcript.Contains("73"))
        {
            PlayerPrefs.SetString("lokale", "Teori");
            PlayerPrefs.SetString("roomid", "15033222465");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("biokemi") || transcript.Contains("kemi") || transcript.Contains("72"))
        {
            PlayerPrefs.SetString("lokale", "Bio-Kemi");
            PlayerPrefs.SetString("roomid", "15033222461");
            SceneManager.LoadScene("roadmap");
        }
        else if (transcript.Contains("fysik") || transcript.Contains("laboratorium") || transcript.Contains("71"))
        {
            PlayerPrefs.SetString("lokale", "Fysik - Laboratorium");
            PlayerPrefs.SetString("roomid", "15033222462");
            SceneManager.LoadScene("roadmap");
        }
        else if (transcript.Contains("print") || transcript.Contains("printer") || transcript.Contains("printe") || transcript.Contains("printeren") || transcript.Contains("printere") || transcript.Contains("printerne"))
        {
            PlayerPrefs.SetString("lokale", "Printer");
            PlayerPrefs.SetString("roomid", "null");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("bibliotek") || transcript.Contains("biblioteket") || transcript.Contains("04"))
        {

            PlayerPrefs.SetString("lokale", "04 - Bibliotek");
            PlayerPrefs.SetString("roomid", "19804712904");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("teknologi") || transcript.Contains("Teknologi") || transcript.Contains("03"))
        {
            PlayerPrefs.SetString("lokale", "03 - Teknologi");
            PlayerPrefs.SetString("roomid", "19804716018");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("byg") || transcript.Contains("Byg") || transcript.Contains("by") || transcript.Contains("07"))
        {
            PlayerPrefs.SetString("lokale", "07 - Byg");
            PlayerPrefs.SetString("roomid", "15033222460");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("musik") || transcript.Contains("musiklokalet") || transcript.Contains("06"))
        {
            PlayerPrefs.SetString("lokale", "06 - Musik");
            PlayerPrefs.SetString("roomid", "15033222474");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("kantine") || transcript.Contains("kantinen") || transcript.Contains("syd") || transcript.Contains("sydsal") || transcript.Contains("sydsal"))
        {

            PlayerPrefs.SetString("lokale", "Kantinen - Sydsal");
            PlayerPrefs.SetString("roomid", "15033222469");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("nordsal") || transcript.Contains("nord") || transcript.Contains("nord sal") || transcript.Contains("nordsalen"))
        {

            PlayerPrefs.SetString("lokale", "Nordsal");
            PlayerPrefs.SetString("Nordsal 1", "15033222459");
            PlayerPrefs.SetString("Nordsal 2", "15033222458");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("lokale"))
        {

            if (transcript.Contains("11") || transcript.Contains("12") || transcript.Contains("13") || transcript.Contains("14") || transcript.Contains("15") || transcript.Contains("16") || transcript.Contains("17") || transcript.Contains("18"))
            {

                PlayerPrefs.SetString("lokale", "10'er gang");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("21") || transcript.Contains("22") || transcript.Contains("23") || transcript.Contains("24") || transcript.Contains("25"))
            {

                PlayerPrefs.SetString("lokale", "20'er gang");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("31") || transcript.Contains("32"))
            {
                PlayerPrefs.SetString("lokale", "30'er gang");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("43") || transcript.Contains("44") || transcript.Contains("45"))
            {

                PlayerPrefs.SetString("lokale", "43 - 44 - 45");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("46") || transcript.Contains("47") || transcript.Contains("48") || transcript.Contains("49") || transcript.Contains("50"))
            {

                PlayerPrefs.SetString("lokale", "46 - 47 - 48 - 49 - 50");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("51") || transcript.Contains("52") || transcript.Contains("53") || transcript.Contains("54"))
            {

                PlayerPrefs.SetString("lokale", "50'er gang");
                SceneManager.LoadScene("roadmap");

            }
            else if (transcript.Contains("60") || transcript.Contains("61") || transcript.Contains("62") || transcript.Contains("63"))
            {

                PlayerPrefs.SetString("lokale", "60'er gang");
                SceneManager.LoadScene("roadmap");

            }
        }


    }
    public void startlistening()
    {
        stream.onInterimResult.AddListener(text);
        stream.onFinalResult.AddListener(Modtage);
    }

    // Update is called once per frame
    void text(string oninterim)
    {
        whatihear.text = oninterim + "...";
    }
}
