using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTime : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeV;
    string TimeValue;
    GameObject CountingTime;
    void Start()
    {
        CountingTime = GameObject.Find("Êý×Ö");
        string TimeValue = CountingTime.GetComponent<Text>().text;
        TimeV = float.Parse(TimeValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeV > 0)
        {
            TimeV -= Time.deltaTime;
            string SetString = TimeV.ToString("f1");
            CountingTime.GetComponent<Text>().text = SetString;


        }
        

    }
}
