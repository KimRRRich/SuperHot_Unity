using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//³¡¾°


public class quitGame : MonoBehaviour
{
    public int level = 1;
    public GameObject LevelSelect;
    // Start is called before the first frame update
    void Start()
    {
        if (level == 0)
        {
            LevelSelect = GameObject.Find("¹Ø¿¨Ñ¡Ôñ");
            LevelSelect.SetActive(false);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 0)
        if(Input.GetKeyDown(KeyCode.Escape)) LevelSelect.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        LevelSelect.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void BackToDeskTop()
    {
        Application.Quit();
    }

    public void Restart()
    {
        if (level == 1)
        {
            SceneManager.LoadScene("Scene");
        }
        if (level == 2)
        {
            SceneManager.LoadScene("level2");
        }
    }

    
}
