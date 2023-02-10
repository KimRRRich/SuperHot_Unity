using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//场景

public class LevelUpdateTime : MonoBehaviour
{
    float TimeV;
    string TimeValue;
    GameObject CountingTime;
    public bool GameOver;
    public GameObject menu;
    private GameObject player;
    public GameObject aim;
    // Start is called before the first frame update
    void Start()
    {
        CountingTime = GameObject.Find("时间");
        menu = GameObject.Find("游戏结束界面");
        aim = GameObject.Find("aim");
        string TimeValue = CountingTime.GetComponent<Text>().text;
        TimeV = 0;
        GameOver = false;
        menu.SetActive(false);
        player = GameObject.Find("Player");
        aim.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver)
        {
            TimeV += Time.deltaTime;
            string SetString = TimeV.ToString("f1");
            CountingTime.GetComponent<Text>().text = SetString;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
        aim.SetActive(false);
    }
}
