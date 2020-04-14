using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lokaleinformation : MonoBehaviour
{

    private string Lokale;
    public Text Lokalenavn;
    // Start is called before the first frame update
    void Start()
    {
       Lokale = PlayerPrefs.GetString("lokale");
    }

    // Update is called once per frame
    void Update()
    {
        Lokalenavn.text = Lokale;
    }
}
