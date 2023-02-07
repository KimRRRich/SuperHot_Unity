using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//³¡¾°

public class UpdateTime : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeV;
    string TimeValue;
    GameObject CountingTime;
    public bool GameOver;
    public GameObject menu;
    void Start()
    {
        CountingTime = GameObject.Find("Êý×Ö");
        string TimeValue = CountingTime.GetComponent<Text>().text;
        TimeV = float.Parse(TimeValue);
        GameOver = false;
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver)
        {
            if (TimeV > 0)
            {
                TimeV -= Time.deltaTime;
                string SetString = TimeV.ToString("f1");
                CountingTime.GetComponent<Text>().text = SetString;


            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("menu");
            }
        }
        
        

    }

    public void ShowMenu()
    {
        menu.SetActive(true);
    }
}
