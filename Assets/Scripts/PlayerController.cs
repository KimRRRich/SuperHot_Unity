using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private CharacterController cc;
    public GameObject Canvas;
    public GameObject player;
    private bool isGameOver;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
        player = GameObject.Find("Player");
        Canvas = GameObject.Find("Canvas");
        isGameOver = false;

    }

    // Update is called once per frame
    void Update () {
        
    }

    public float Speed() {
        return cc.velocity.magnitude;
    }

    public void GameOver()
    {
        if (!isGameOver)
        {
            Canvas.GetComponent<UpdateTime>().GameOver = true;
            player.GetComponent<FirstPersonController>().GameOver = true;
            Canvas.GetComponent<UpdateTime>().ShowMenu();
            player.GetComponent<FirstPersonController>().UnlockedMouse();

            Cursor.visible = true;//鼠标显示
            Cursor.lockState = CursorLockMode.None;//鼠标解锁并显示
            isGameOver = true;
        }
        


    }
}
