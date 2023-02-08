using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private CharacterController cc;
    public GameObject Canvas;
    public GameObject player;
    public GameObject EnemyCreatePoint;
    private bool isGameOver;
    private Animator Gun;
    public GameObject GunModel;
    public bool CanShoot;
    private AudioSource[] m_ArrayMusic;
    private AudioSource m_music1;
    private AudioSource m_music2;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
        player = GameObject.Find("Player");
        Canvas = GameObject.Find("Canvas");
        isGameOver = false;
        Gun = GunModel.GetComponent<Animator>();
        CanShoot = true;
        EnemyCreatePoint = GameObject.Find("Enemy");
        m_ArrayMusic = gameObject.GetComponents<AudioSource>();
        m_music1 = m_ArrayMusic[0];
        //m_music1 = m_ArrayMusic[0];
        m_music2 = m_ArrayMusic[1];

    }

    // Update is called once per frame
    void Update () {
        if (!isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (CanShoot)
                    Gun.SetTrigger("Shoot");
            }
        }
        
    }

    public float Speed() {
        return cc.velocity.magnitude;
    }

    public void GameOver()
    {
        if (!isGameOver)
        {
            //player
            m_music2.Play();
            Canvas.GetComponent<UpdateTime>().GameOver = true;
            player.GetComponent<FirstPersonController>().GameOver = true;
            EnemyCreatePoint.GetComponent<CreateEnemy>().GameOver = true;
            Canvas.GetComponent<UpdateTime>().ShowMenu();
            player.GetComponent<FirstPersonController>().UnlockedMouse();

            Cursor.visible = true;//鼠标显示
            Cursor.lockState = CursorLockMode.None;//鼠标解锁并显示
            isGameOver = true;
        }
        


    }
}
