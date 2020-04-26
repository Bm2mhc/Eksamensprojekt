using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class LectioApi : MonoBehaviour
{

    public Text manModule1, manModule2, manModule3, manModule4, manModule5, manModule6, manModule7;
    public Text tirModule1, tirModule2, tirModule3, tirModule4, tirModule5, tirModule6, tirModule7;
    public Text onsModule1, onsModule2, onsModule3, onsModule4, onsModule5, onsModule6, onsModule7;
    public Text torModule1, torModule2, torModule3, torModule4, torModule5, torModule6, torModule7;
    public Text freModule1, freModule2, freModule3, freModule4, freModule5, freModule6, freModule7;

    public GameObject boxman1, boxman2, boxman3, boxman4, boxman5, boxman6, boxman7;
    public GameObject boxtir1, boxtir2, boxtir3, boxtir4, boxtir5, boxtir6, boxtir7;
    public GameObject boxons1, boxons2, boxons3, boxons4, boxons5, boxons6, boxons7;
    public GameObject boxtor1, boxtor2, boxtor3, boxtor4, boxtor5, boxtor6, boxtor7;
    public GameObject boxfre1, boxfre2, boxfre3, boxfre4, boxfre5, boxfre6, boxfre7;

    public string token;
    public string roomid;
    string lectioToken;
    string Startdate;
    string datenow = System.DateTime.Now.ToString("yyyy/MM/ddThh");

    private readonly string baseLectioToken = "https://lectioapi.dk/api/Auth/557/17HTX319/bm2ergod";
    private readonly string baseLectio = "https://lectioapi.dk/api/Calendar/557/";

   public void Start()
    {
        roomid = PlayerPrefs.GetString("roomid");

    StartCoroutine(gettoken());
    }

    IEnumerator gettoken()
    {
        string authToken = baseLectioToken;
        UnityWebRequest lectioTokenRequest = UnityWebRequest.Get(authToken);

        yield return lectioTokenRequest.SendWebRequest();

        if (lectioTokenRequest.isNetworkError || lectioTokenRequest.isHttpError)
        {
            Debug.LogError(lectioTokenRequest.error);
            yield break;
        }

        lectioToken = lectioTokenRequest.downloadHandler.text;
        lectioToken = lectioToken.Substring(1, lectioToken.Length - 2);

        Debug.Log(lectioToken);

        StartCoroutine(getroominfo());
    }

    IEnumerator getroominfo()
    {
        /* string date = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
         Debug.Log(date);*/

        string day = System.DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        Debug.Log(day);

        // Gets the Calendar instance associated with a CultureInfo.
        CultureInfo myCI = new CultureInfo("da-DK");
        Calendar myCal = myCI.Calendar;

        // Gets the DTFI properties required by GetWeekOfYear.
        CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
        DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

        string weburl = baseLectio + myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW) + "2020" + "?authToken=" + lectioToken + "&userType=lokale&roomId=" + roomid;
        UnityWebRequest roomrequest = UnityWebRequest.Get(weburl);
        yield return roomrequest.SendWebRequest();

        if (roomrequest.isNetworkError || roomrequest.isHttpError)
        {
            Debug.LogError(roomrequest.error);
            yield break;
        }

        JSONNode roominfo = JSON.Parse(roomrequest.downloadHandler.text);

        string module1 = roominfo[1][0]["Title"];
        string all = roomrequest.downloadHandler.text;

        Debug.Log("module1 = " + module1);
        Debug.Log("all data = " + all);

      string tid1man = roominfo[1][0]["DateStart"];
      string tid2man = roominfo[1][1]["DateStart"];
      string tid3man = roominfo[1][2]["DateStart"];
      string tid4man = roominfo[1][3]["DateStart"];
      string tid5man = roominfo[1][4]["DateStart"];
      string tid6man = roominfo[1][5]["DateStart"];
      string tid7man = roominfo[1][6]["DateStart"];

      string text1man = roominfo[1][0]["Title"];
      string text2man = roominfo[1][1]["Title"];
      string text3man = roominfo[1][2]["Title"];
      string text4man = roominfo[1][3]["Title"];
      string text5man = roominfo[1][4]["Title"];
      string text6man = roominfo[1][5]["Title"];
      string text7man = roominfo[1][6]["Title"];


        if (tid1man == null)
        {
            boxman1.SetActive(false);
        }
        else if (tid1man.Contains("08:15"))
        {
            boxman1.SetActive(true);
            manModule1.text = "8:15 " + text1man;
        }

        

        if (tid1man == null)
        {
            boxman2.SetActive(false);
        }
        else if (tid1man.Contains("09:25"))
        {
            boxman2.SetActive(true);
            manModule2.text = "9:25 " + text1man;

        } else if (tid2man == null)
        {
            boxman2.SetActive(false);
        } else if (tid2man.Contains("9:25"))
        {
            boxman2.SetActive(true);
            manModule2.text = "9:25 " + text2man;
        }


        if (tid1man == null)
        {
            boxman3.SetActive(false);
        }
        else if (tid1man.Contains("10:35"))
        {
            boxman3.SetActive(true);
            manModule3.text = "10:35 " + text1man;

        }
        else if (tid3man == null)
        {
            boxman3.SetActive(false);
        }
        else if (tid2man.Contains("10:35"))
        {
            boxman3.SetActive(true);
            manModule3.text = "10:35 " + text2man;
        }
        else if (tid3man == null)
        {
            boxman3.SetActive(false);
        }
        else if (tid3man.Contains("10:35"))
        {
            boxman3.SetActive(true);
            manModule3.text = "10:35 " + text3man;
        }


        if (tid1man == null)
        {
            boxman4.SetActive(false);
        }
        else if (tid1man.Contains("12:05"))
        {
            boxman4.SetActive(true);
            manModule4.text = "12:05 " + text1man;

        }
        else if (tid2man == null)
        {
            boxman4.SetActive(false);
        }
        else if (tid2man.Contains("12:05"))
        {
            boxman4.SetActive(true);
            manModule4.text = "12:05 " + text2man;
        }
        else if (tid3man == null)
        {
            boxman4.SetActive(false);
        }
        else if (tid3man.Contains("12:05"))
        {
            boxman4.SetActive(true);
            manModule4.text = "12:05 " + text3man;
        }
        else if (tid4man == null)
        {
            boxman4.SetActive(false);
        }
        else if (tid4man.Contains("12:05"))
        {
            boxman4.SetActive(true);
            Debug.Log(text4man);
            manModule4.text = "12:05 " + text4man;
        }



        if (tid1man == null)
        {
            boxman5.SetActive(false);
        }
        else if (tid1man.Contains("13:15"))
        {
            boxman5.SetActive(true);
            manModule5.text = "13:15 " + text1man;

        }
        else if (tid2man == null)
        {
            boxman5.SetActive(false);
        }
        else if (tid2man.Contains("13:15"))
        {
            boxman5.SetActive(true);
            manModule5.text = "13:15 " + text2man;
        }
        else if (tid3man == null)
        {
            boxman5.SetActive(false);
        }
        else if (tid3man.Contains("13:15"))
        {
            boxman5.SetActive(true);
            manModule5.text = "13:15 " + text3man;
        }
        else if (tid4man == null)
        {
            boxman5.SetActive(false);
        }
        else if (tid4man.Contains("13:15"))
        {
            boxman5.SetActive(true);
            manModule5.text = "13:15 " + text4man;
        }
        else if (tid5man == null)
        {
            boxman5.SetActive(false);
        }
        else if (tid5man.Contains("13:15"))
        {
            boxman5.SetActive(true);
            manModule5.text = "13:15 " + text5man;
        }



        if (tid1man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid1man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text1man;
        }
        else if (tid2man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid2man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text2man;
        }
        else if (tid3man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid3man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text3man;
        }
        else if (tid4man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid4man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text4man;
        }
        else if (tid5man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid5man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text5man;
        }
        else if (tid6man == null)
        {
            boxman6.SetActive(false);
        }
        else if (tid6man.Contains("14:20"))
        {
            boxman6.SetActive(true);
            manModule6.text = "14:20 " + text6man;
        }



        if (tid1man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid1man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text1man;

        }
        else if (tid2man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid2man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text2man;
        }
        else if (tid3man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid3man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text3man;
        }
        else if (tid4man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid4man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text4man;
        }
        else if (tid5man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid5man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text5man;
        }
        else if (tid6man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid6man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text7man;
        }
        else if (tid7man == null)
        {
            boxman7.SetActive(false);
        }
        else if (tid7man.Contains("15:20"))
        {
            boxman7.SetActive(true);
            manModule7.text = "15:20 " + text7man;
        }



        string tid1tir = roominfo[2][0]["DateStart"];
        string tid2tir = roominfo[2][1]["DateStart"];
        string tid3tir = roominfo[2][2]["DateStart"];
        string tid4tir = roominfo[2][3]["DateStart"];
        string tid5tir = roominfo[2][4]["DateStart"];
        string tid6tir = roominfo[2][5]["DateStart"];
        string tid7tir = roominfo[2][6]["DateStart"];

        string text1tir = roominfo[2][0]["Title"];
        string text2tir = roominfo[2][1]["Title"];
        string text3tir = roominfo[2][2]["Title"];
        string text4tir = roominfo[2][3]["Title"];
        string text5tir = roominfo[2][4]["Title"];
        string text6tir = roominfo[2][5]["Title"];
        string text7tir = roominfo[2][6]["Title"];


        if (tid1tir == null)
        {
            boxtir1.SetActive(false);
        }
        else if (tid1tir.Contains("08:15"))
        {
            boxtir1.SetActive(true);
            tirModule1.text = "8:15 " + text1tir;
        }



        if (tid1tir == null)
        {
            boxtir2.SetActive(false);
        }
        else if (tid1tir.Contains("09:25"))
        {
            boxtir2.SetActive(true);
            tirModule2.text = "9:25 " + text1tir;

        }
        else if (tid2tir == null)
        {
            boxtir2.SetActive(false);
        }
        else if (tid2tir.Contains("9:25"))
        {
            boxtir2.SetActive(true);
            tirModule2.text = "9:25 " + text2tir;
        }


        if (tid1tir == null)
        {
            boxtir3.SetActive(false);
        }
        else if (tid1tir.Contains("10:35"))
        {
            boxtir3.SetActive(true);
            tirModule3.text = "10:35 " + text1tir;

        }
        else if (tid3tir == null)
        {
            boxtir3.SetActive(false);
        }
        else if (tid2tir.Contains("10:35"))
        {
            boxtir3.SetActive(true);
            tirModule3.text = "10:35 " + text2tir;
        }
        else if (tid3tir == null)
        {
            boxtir3.SetActive(false);
        }
        else if (tid3tir.Contains("10:35"))
        {
            boxtir3.SetActive(true);
            tirModule3.text = "10:35 " + text3tir;
        }


        if (tid1tir == null)
        {
            boxtir4.SetActive(false);
        }
        else if (tid1tir.Contains("12:05"))
        {
            boxtir4.SetActive(true);
            tirModule4.text = "12:05 " + text1tir;

        }
        else if (tid2tir == null)
        {
            boxtir4.SetActive(false);
        }
        else if (tid2tir.Contains("12:05"))
        {
            boxtir4.SetActive(true);
            tirModule4.text = "12:05 " + text2tir;
        }
        else if (tid3tir == null)
        {
            boxtir4.SetActive(false);
        }
        else if (tid3tir.Contains("12:05"))
        {
            boxtir4.SetActive(true);
            tirModule4.text = "12:05 " + text3tir;
        }
        else if (tid4tir == null)
        {
            boxtir4.SetActive(false);
        }
        else if (tid4tir.Contains("12:05"))
        {
            boxtir4.SetActive(true);
            Debug.Log(text4tir);
            tirModule4.text = "12:05 " + text4tir;
        }



        if (tid1tir == null)
        {
            boxtir5.SetActive(false);
        }
        else if (tid1tir.Contains("13:15"))
        {
            boxtir5.SetActive(true);
            tirModule5.text = "13:15 " + text1tir;

        }
        else if (tid2tir == null)
        {
            boxtir5.SetActive(false);
        }
        else if (tid2tir.Contains("13:15"))
        {
            boxtir5.SetActive(true);
            tirModule5.text = "13:15 " + text2tir;
        }
        else if (tid3tir == null)
        {
            boxtir5.SetActive(false);
        }
        else if (tid3tir.Contains("13:15"))
        {
            boxtir5.SetActive(true);
            tirModule5.text = "13:15 " + text3tir;
        }
        else if (tid4tir == null)
        {
            boxtir5.SetActive(false);
        }
        else if (tid4tir.Contains("13:15"))
        {
            boxtir5.SetActive(true);
            tirModule5.text = "13:15 " + text4tir;
        }
        else if (tid5tir == null)
        {
            boxtir5.SetActive(false);
        }
        else if (tid5tir.Contains("13:15"))
        {
            boxtir5.SetActive(true);
            tirModule5.text = "13:15 " + text5tir;
        }



        if (tid1tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid1tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text1tir;
        }
        else if (tid2tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid2tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text2tir;
        }
        else if (tid3tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid3tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text3tir;
        }
        else if (tid4tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid4tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text4tir;
        }
        else if (tid5tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid5tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text5tir;
        }
        else if (tid6tir == null)
        {
            boxtir6.SetActive(false);
        }
        else if (tid6tir.Contains("14:20"))
        {
            boxtir6.SetActive(true);
            tirModule6.text = "14:20 " + text6tir;
        }



        if (tid1tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid1tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text1tir;

        }
        else if (tid2tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid2tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text2tir;
        }
        else if (tid3tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid3tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text3tir;
        }
        else if (tid4tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid4tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text4tir;
        }
        else if (tid5tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid5tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text5tir;
        }
        else if (tid6tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid6tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text7tir;
        }
        else if (tid7tir == null)
        {
            boxtir7.SetActive(false);
        }
        else if (tid7tir.Contains("15:20"))
        {
            boxtir7.SetActive(true);
            tirModule7.text = "15:20 " + text7tir;
        }



        string tid1ons = roominfo[3][0]["DateStart"];
        string tid2ons = roominfo[3][1]["DateStart"];
        string tid3ons = roominfo[3][2]["DateStart"];
        string tid4ons = roominfo[3][3]["DateStart"];
        string tid5ons = roominfo[3][4]["DateStart"];
        string tid6ons = roominfo[3][5]["DateStart"];
        string tid7ons = roominfo[3][6]["DateStart"];

        string text1ons = roominfo[3][0]["Title"];
        string text2ons = roominfo[3][1]["Title"];
        string text3ons = roominfo[3][2]["Title"];
        string text4ons = roominfo[3][3]["Title"];
        string text5ons = roominfo[3][4]["Title"];
        string text6ons = roominfo[3][5]["Title"];
        string text7ons = roominfo[3][6]["Title"];


        if (tid1ons == null)
        {
            boxons1.SetActive(false);
        }
        else if (tid1ons.Contains("08:15"))
        {
            boxons1.SetActive(true);
            onsModule1.text = "8:15 " + text1ons;
        }



        if (tid1ons == null)
        {
            boxons2.SetActive(false);
        }
        else if (tid1ons.Contains("09:25"))
        {
            boxons2.SetActive(true);
            onsModule2.text = "9:25 " + text1ons;

        }
        else if (tid2ons == null)
        {
            boxons2.SetActive(false);
        }
        else if (tid2ons.Contains("9:25"))
        {
            boxons2.SetActive(true);
            onsModule2.text = "9:25 " + text2ons;
        }


        if (tid1ons == null)
        {
            boxons3.SetActive(false);
        }
        else if (tid1ons.Contains("10:35"))
        {
            boxons3.SetActive(true);
            onsModule3.text = "10:35 " + text1ons;

        }
        else if (tid3ons == null)
        {
            boxons3.SetActive(false);
        }
        else if (tid2ons.Contains("10:35"))
        {
            boxons3.SetActive(true);
            onsModule3.text = "10:35 " + text2ons;
        }
        else if (tid3ons == null)
        {
            boxons3.SetActive(false);
        }
        else if (tid3ons.Contains("10:35"))
        {
            boxons3.SetActive(true);
            onsModule3.text = "10:35 " + text3ons;
        }


        if (tid1ons == null)
        {
            boxons4.SetActive(false);
        }
        else if (tid1ons.Contains("12:05"))
        {
            boxons4.SetActive(true);
            onsModule4.text = "12:05 " + text1ons;

        }
        else if (tid2ons == null)
        {
            boxons4.SetActive(false);
        }
        else if (tid2ons.Contains("12:05"))
        {
            boxons4.SetActive(true);
            onsModule4.text = "12:05 " + text2ons;
        }
        else if (tid3ons == null)
        {
            boxons4.SetActive(false);
        }
        else if (tid3ons.Contains("12:05"))
        {
            boxons4.SetActive(true);
            onsModule4.text = "12:05 " + text3ons;
        }
        else if (tid4ons == null)
        {
            boxons4.SetActive(false);
        }
        else if (tid4ons.Contains("12:05"))
        {
            boxons4.SetActive(true);
            Debug.Log(text4ons);
            onsModule4.text = "12:05 " + text4ons;
        }



        if (tid1ons == null)
        {
            boxons5.SetActive(false);
        }
        else if (tid1ons.Contains("13:15"))
        {
            boxons5.SetActive(true);
            onsModule5.text = "13:15 " + text1ons;

        }
        else if (tid2ons == null)
        {
            boxons5.SetActive(false);
        }
        else if (tid2ons.Contains("13:15"))
        {
            boxons5.SetActive(true);
            onsModule5.text = "13:15 " + text2ons;
        }
        else if (tid3ons == null)
        {
            boxons5.SetActive(false);
        }
        else if (tid3ons.Contains("13:15"))
        {
            boxons5.SetActive(true);
            onsModule5.text = "13:15 " + text3ons;
        }
        else if (tid4ons == null)
        {
            boxons5.SetActive(false);
        }
        else if (tid4ons.Contains("13:15"))
        {
            boxons5.SetActive(true);
            onsModule5.text = "13:15 " + text4ons;
        }
        else if (tid5ons == null)
        {
            boxons5.SetActive(false);
        }
        else if (tid5ons.Contains("13:15"))
        {
            boxons5.SetActive(true);
            onsModule5.text = "13:15 " + text5ons;
        }



        if (tid1ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid1ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text1ons;
        }
        else if (tid2ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid2ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text2ons;
        }
        else if (tid3ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid3ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text3ons;
        }
        else if (tid4ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid4ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text4ons;
        }
        else if (tid5ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid5ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text5ons;
        }
        else if (tid6ons == null)
        {
            boxons6.SetActive(false);
        }
        else if (tid6ons.Contains("14:20"))
        {
            boxons6.SetActive(true);
            onsModule6.text = "14:20 " + text6ons;
        }



        if (tid1ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid1ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text1ons;

        }
        else if (tid2ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid2ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text2ons;
        }
        else if (tid3ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid3ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text3ons;
        }
        else if (tid4ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid4ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text4ons;
        }
        else if (tid5ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid5ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text5ons;
        }
        else if (tid6ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid6ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text7ons;
        }
        else if (tid7ons == null)
        {
            boxons7.SetActive(false);
        }
        else if (tid7ons.Contains("15:20"))
        {
            boxons7.SetActive(true);
            onsModule7.text = "15:20 " + text7ons;
        }



        string tid1tor = roominfo[4][0]["DateStart"];
        string tid2tor = roominfo[4][1]["DateStart"];
        string tid3tor = roominfo[4][2]["DateStart"];
        string tid4tor = roominfo[4][3]["DateStart"];
        string tid5tor = roominfo[4][4]["DateStart"];
        string tid6tor = roominfo[4][5]["DateStart"];
        string tid7tor = roominfo[4][6]["DateStart"];

        string text1tor = roominfo[4][0]["Title"];
        string text2tor = roominfo[4][1]["Title"];
        string text3tor = roominfo[4][2]["Title"];
        string text4tor = roominfo[4][3]["Title"];
        string text5tor = roominfo[4][4]["Title"];
        string text6tor = roominfo[4][5]["Title"];
        string text7tor = roominfo[4][6]["Title"];


        if (tid1tor == null)
        {
            boxtor1.SetActive(false);
        }
        else if (tid1tor.Contains("08:15"))
        {
            boxtor1.SetActive(true);
            torModule1.text = "8:15 " + text1tor;
        }



        if (tid1tor == null)
        {
            boxtor2.SetActive(false);
        }
        else if (tid1tor.Contains("09:25"))
        {
            boxtor2.SetActive(true);
            torModule2.text = "9:25 " + text1tor;

        }
        else if (tid2tor == null)
        {
            boxtor2.SetActive(false);
        }
        else if (tid2tor.Contains("9:25"))
        {
            boxtor2.SetActive(true);
            torModule2.text = "9:25 " + text2tor;
        }


        if (tid1tor == null)
        {
            boxtor3.SetActive(false);
        }
        else if (tid1tor.Contains("10:35"))
        {
            boxtor3.SetActive(true);
            torModule3.text = "10:35 " + text1tor;

        }
        else if (tid3tor == null)
        {
            boxtor3.SetActive(false);
        }
        else if (tid2tor.Contains("10:35"))
        {
            boxtor3.SetActive(true);
            torModule3.text = "10:35 " + text2tor;
        }
        else if (tid3tor == null)
        {
            boxtor3.SetActive(false);
        }
        else if (tid3tor.Contains("10:35"))
        {
            boxtor3.SetActive(true);
            torModule3.text = "10:35 " + text3tor;
        }


        if (tid1tor == null)
        {
            boxtor4.SetActive(false);
        }
        else if (tid1tor.Contains("12:05"))
        {
            boxtor4.SetActive(true);
            torModule4.text = "12:05 " + text1tor;

        }
        else if (tid2tor == null)
        {
            boxtor4.SetActive(false);
        }
        else if (tid2tor.Contains("12:05"))
        {
            boxtor4.SetActive(true);
            torModule4.text = "12:05 " + text2tor;
        }
        else if (tid3tor == null)
        {
            boxtor4.SetActive(false);
        }
        else if (tid3tor.Contains("12:05"))
        {
            boxtor4.SetActive(true);
            torModule4.text = "12:05 " + text3tor;
        }
        else if (tid4tor == null)
        {
            boxtor4.SetActive(false);
        }
        else if (tid4tor.Contains("12:05"))
        {
            boxtor4.SetActive(true);
            Debug.Log(text4tor);
            torModule4.text = "12:05 " + text4tor;
        }



        if (tid1tor == null)
        {
            boxtor5.SetActive(false);
        }
        else if (tid1tor.Contains("13:15"))
        {
            boxtor5.SetActive(true);
            torModule5.text = "13:15 " + text1tor;

        }
        else if (tid2tor == null)
        {
            boxtor5.SetActive(false);
        }
        else if (tid2tor.Contains("13:15"))
        {
            boxtor5.SetActive(true);
            torModule5.text = "13:15 " + text2tor;
        }
        else if (tid3tor == null)
        {
            boxtor5.SetActive(false);
        }
        else if (tid3tor.Contains("13:15"))
        {
            boxtor5.SetActive(true);
            torModule5.text = "13:15 " + text3tor;
        }
        else if (tid4tor == null)
        {
            boxtor5.SetActive(false);
        }
        else if (tid4tor.Contains("13:15"))
        {
            boxtor5.SetActive(true);
            torModule5.text = "13:15 " + text4tor;
        }
        else if (tid5tor == null)
        {
            boxtor5.SetActive(false);
        }
        else if (tid5tor.Contains("13:15"))
        {
            boxtor5.SetActive(true);
            torModule5.text = "13:15 " + text5tor;
        }



        if (tid1tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid1tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text1tor;
        }
        else if (tid2tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid2tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text2tor;
        }
        else if (tid3tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid3tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text3tor;
        }
        else if (tid4tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid4tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text4tor;
        }
        else if (tid5tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid5tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text5tor;
        }
        else if (tid6tor == null)
        {
            boxtor6.SetActive(false);
        }
        else if (tid6tor.Contains("14:20"))
        {
            boxtor6.SetActive(true);
            torModule6.text = "14:20 " + text6tor;
        }



        if (tid1tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid1tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text1tor;

        }
        else if (tid2tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid2tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text2tor;
        }
        else if (tid3tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid3tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text3tor;
        }
        else if (tid4tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid4tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text4tor;
        }
        else if (tid5tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid5tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text5tor;
        }
        else if (tid6tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid6tor.Contains("15:20"))
        {
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text7tor;
        }
        else if (tid7tor == null)
        {
            boxtor7.SetActive(false);
        }
        else if (tid7tor.Contains("15:20"))
        { 
            boxtor7.SetActive(true);
            torModule7.text = "15:20 " + text7tor;
        }

        string tid1fre = roominfo[4][0]["DateStart"];
        string tid2fre = roominfo[4][1]["DateStart"];
        string tid3fre = roominfo[4][2]["DateStart"];
        string tid4fre = roominfo[4][3]["DateStart"];
        string tid5fre = roominfo[4][4]["DateStart"];
        string tid6fre = roominfo[4][5]["DateStart"];
        string tid7fre = roominfo[4][6]["DateStart"];

        string text1fre = roominfo[4][0]["Title"];
        string text2fre = roominfo[4][1]["Title"];
        string text3fre = roominfo[4][2]["Title"];
        string text4fre = roominfo[4][3]["Title"];
        string text5fre = roominfo[4][4]["Title"];
        string text6fre = roominfo[4][5]["Title"];
        string text7fre = roominfo[4][6]["Title"];


        if (tid1fre == null)
        {
            boxfre1.SetActive(false);
        }
        else if (tid1fre.Contains("08:15"))
        {
            boxfre1.SetActive(true);
            freModule1.text = "8:15 " + text1fre;
        }



        if (tid1fre == null)
        {
            boxfre2.SetActive(false);
        }
        else if (tid1fre.Contains("09:25"))
        {
            boxfre2.SetActive(true);
            freModule2.text = "9:25 " + text1fre;

        }
        else if (tid2fre == null)
        {
            boxfre2.SetActive(false);
        }
        else if (tid2fre.Contains("9:25"))
        {
            boxfre2.SetActive(true);
            freModule2.text = "9:25 " + text2fre;
        }


        if (tid1fre == null)
        {
            boxfre3.SetActive(false);
        }
        else if (tid1fre.Contains("10:35"))
        {
            boxfre3.SetActive(true);
            freModule3.text = "10:35 " + text1fre;

        }
        else if (tid3fre == null)
        {
            boxfre3.SetActive(false);
        }
        else if (tid2fre.Contains("10:35"))
        {
            boxfre3.SetActive(true);
            freModule3.text = "10:35 " + text2fre;
        }
        else if (tid3fre == null)
        {
            boxfre3.SetActive(false);
        }
        else if (tid3fre.Contains("10:35"))
        {
            boxfre3.SetActive(true);
            freModule3.text = "10:35 " + text3fre;
        }


        if (tid1fre == null)
        {
            boxfre4.SetActive(false);
        }
        else if (tid1fre.Contains("12:05"))
        {
            boxfre4.SetActive(true);
            freModule4.text = "12:05 " + text1fre;

        }
        else if (tid2fre == null)
        {
            boxfre4.SetActive(false);
        }
        else if (tid2fre.Contains("12:05"))
        {
            boxfre4.SetActive(true);
            freModule4.text = "12:05 " + text2fre;
        }
        else if (tid3fre == null)
        {
            boxfre4.SetActive(false);
        }
        else if (tid3fre.Contains("12:05"))
        {
            boxfre4.SetActive(true);
            freModule4.text = "12:05 " + text3fre;
        }
        else if (tid4fre == null)
        {
            boxfre4.SetActive(false);
        }
        else if (tid4fre.Contains("12:05"))
        {
            boxfre4.SetActive(true);
            Debug.Log(text4fre);
            freModule4.text = "12:05 " + text4fre;
        }



        if (tid1fre == null)
        {
            boxfre5.SetActive(false);
        }
        else if (tid1fre.Contains("13:15"))
        {
            boxfre5.SetActive(true);
            freModule5.text = "13:15 " + text1fre;

        }
        else if (tid2fre == null)
        {
            boxfre5.SetActive(false);
        }
        else if (tid2fre.Contains("13:15"))
        {
            boxfre5.SetActive(true);
            freModule5.text = "13:15 " + text2fre;
        }
        else if (tid3fre == null)
        {
            boxfre5.SetActive(false);
        }
        else if (tid3fre.Contains("13:15"))
        {
            boxfre5.SetActive(true);
            freModule5.text = "13:15 " + text3fre;
        }
        else if (tid4fre == null)
        {
            boxfre5.SetActive(false);
        }
        else if (tid4fre.Contains("13:15"))
        {
            boxfre5.SetActive(true);
            freModule5.text = "13:15 " + text4fre;
        }
        else if (tid5fre == null)
        {
            boxfre5.SetActive(false);
        }
        else if (tid5fre.Contains("13:15"))
        {
            boxfre5.SetActive(true);
            freModule5.text = "13:15 " + text5fre;
        }



        if (tid1fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid1fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text1fre;
        }
        else if (tid2fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid2fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text2fre;
        }
        else if (tid3fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid3fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text3fre;
        }
        else if (tid4fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid4fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text4fre;
        }
        else if (tid5fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid5fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text5fre;
        }
        else if (tid6fre == null)
        {
            boxfre6.SetActive(false);
        }
        else if (tid6fre.Contains("14:20"))
        {
            boxfre6.SetActive(true);
            freModule6.text = "14:20 " + text6fre;
        }



        if (tid1fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid1fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text1fre;

        }
        else if (tid2fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid2fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text2fre;
        }
        else if (tid3fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid3fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text3fre;
        }
        else if (tid4fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid4fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text4fre;
        }
        else if (tid5fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid5fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text5fre;
        }
        else if (tid6fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid6fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text7fre;
        }
        else if (tid7fre == null)
        {
            boxfre7.SetActive(false);
        }
        else if (tid7fre.Contains("15:20"))
        {
            boxfre7.SetActive(true);
            freModule7.text = "15:20 " + text7fre;
        }

    }


}


