using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class searchscript : MonoBehaviour
{
    public InputField ifield;
    public string transcript;
    // Start is called before the first frame update
    void Update()
    {
        transcript = ifield.text;

        if (Input.GetKey(KeyCode.Return))
        {
            changescene();
        }
       
    }

    public void changescene()
    {
        if (transcript.Contains("rektor") || transcript.Contains("Rektor") || transcript.Contains("katrine") || transcript.Contains("Katrine"))
        {
            PlayerPrefs.SetString("lokale", "Rektor");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("studieadministration") || transcript.Contains("studieadministrationen")|| transcript.Contains("Studieadministration") || transcript.Contains("Studieadministrationen"))
        {
            PlayerPrefs.SetString("lokale", "Studieadministration");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("VR") || transcript.Contains("vr") || transcript.Contains("Vr"))
        {
            PlayerPrefs.SetString("lokale", "VR lab");
            SceneManager.LoadScene("roadmap");


        }
        else if (transcript.Contains("innolab") || transcript.Contains("inno lab") || transcript.Contains("Innolab") || transcript.Contains("Inno lab"))
        {
            PlayerPrefs.SetString("lokale", "Innolab");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("proces") || transcript.Contains("process") || transcript.Contains("74") || transcript.Contains("Proces") || transcript.Contains("Process"))
        {
            PlayerPrefs.SetString("lokale", "Proces");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("teori") || transcript.Contains("design") || transcript.Contains("73") || transcript.Contains("Teori") || transcript.Contains("Design") )
        {
            PlayerPrefs.SetString("lokale", "Teori");
            Debug.Log("Yep " + transcript);
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("biokemi") || transcript.Contains("kemi") || transcript.Contains("72") || transcript.Contains("Biokemi") || transcript.Contains("Kemi"))
        {
            PlayerPrefs.SetString("lokale", "Bio-Kemi");
            SceneManager.LoadScene("roadmap");
        }
        else if (transcript.Contains("fysik") || transcript.Contains("laboratorium") || transcript.Contains("71") || transcript.Contains("Fysik") || transcript.Contains("Laboratorium"))
        {
            PlayerPrefs.SetString("lokale", "Fysik - Laboratorium");
            SceneManager.LoadScene("roadmap");
        }
        else if (transcript.Contains("print") || transcript.Contains("printer") || transcript.Contains("printe") || transcript.Contains("printeren") || transcript.Contains("printere") || transcript.Contains("printerne") || transcript.Contains("Print") || transcript.Contains("Printer") || transcript.Contains("Printe") || transcript.Contains("Printeren") || transcript.Contains("Printere") || transcript.Contains("Printerne"))
        {
            PlayerPrefs.SetString("lokale", "Printer");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("bibliotek") || transcript.Contains("biblioteket") || transcript.Contains("04") || transcript.Contains("Bibliotek") || transcript.Contains("Biblioteket"))
        {

            PlayerPrefs.SetString("lokale", "04 - Bibliotek");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("teknologi") || transcript.Contains("Teknologi") || transcript.Contains("03"))
        {
            PlayerPrefs.SetString("lokale", "03 - Teknologi");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("byg") || transcript.Contains("Byg") || transcript.Contains("by") || transcript.Contains("07") || transcript.Contains("By"))
        {
            PlayerPrefs.SetString("lokale", "07 - Byg");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("musik") || transcript.Contains("musiklokalet") || transcript.Contains("06")|| transcript.Contains("Musik") || transcript.Contains("Musiklokalet"))
        {
            PlayerPrefs.SetString("lokale", "06 - Musik");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("kantine") || transcript.Contains("kantinen") || transcript.Contains("syd") || transcript.Contains("sydsal") || transcript.Contains("syd sal")|| transcript.Contains("Kantine") || transcript.Contains("Kantinen") || transcript.Contains("Syd") || transcript.Contains("Sydsal") || transcript.Contains("Syd sal"))
        {

            PlayerPrefs.SetString("lokale", "Kantinen - Sydsal");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("nordsal") || transcript.Contains("nord") || transcript.Contains("nord sal") || transcript.Contains("nordsalen") || transcript.Contains("Nordsal") || transcript.Contains("Nord") || transcript.Contains("Nord sal") || transcript.Contains("Nordsalen"))
        {

            PlayerPrefs.SetString("lokale", "Nordsal");
            SceneManager.LoadScene("roadmap");

        }
        else if (transcript.Contains("lokale") || transcript.Contains("Lokale"))
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
}
