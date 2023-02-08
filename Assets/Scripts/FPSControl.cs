using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Shuoming;
    void Start()
    {
        Application.targetFrameRate = 90;
        Cursor.visible = true;//鼠标显示
        Cursor.lockState = CursorLockMode.None;//鼠标解锁并显示
        Shuoming.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Shuoming.SetActive(false);
        }
    }

    public void ShowShuoMing()
    {
        Shuoming.SetActive(true);
    }
}
