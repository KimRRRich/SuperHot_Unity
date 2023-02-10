using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//³¡¾°

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{

        //}
    }


    public void Level1()
    {
        SceneManager.LoadScene("Scene");
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2");
    }
}
