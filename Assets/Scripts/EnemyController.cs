﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public enum Type
    {
        GUN, NOGUN
    }
    public Type type;
    public float moveSpeed;
    public int TrackDis = 50;
    public int ShootDis = 20;
    private CharacterController cc;
    private Vector3 moveDirection;
    private float moveDistance;
    private Vector3 moveVector;
    private GameObject player;
    private Animator animator;
    private bool CanMove=true;
    public GameObject Bullet;
    public GameObject Gun;
    

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        //Bullet = GameObject.Find("Bullet");
        cc = GetComponent<CharacterController>();
        moveDirection = Vector3.zero;
        moveSpeed = 4.0f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        moveDirection = (player.transform.position - this.transform.position).normalized;
        moveDistance = (player.transform.position - this.transform.position).magnitude;
        if (CanMove)
        {
            if (moveDistance < TrackDis && moveDistance > ShootDis)
            {
                Vector3 pos = player.transform.position;
                pos.y = transform.position.y;
                transform.LookAt(pos);
                moveVector = new Vector3(moveDirection.x * Time.deltaTime * moveSpeed, 0, moveDirection.z * Time.deltaTime * moveSpeed);
                cc.Move(moveVector);
            }
            else if (moveDistance < ShootDis)
            {
                animator.SetTrigger("Shoot");
            }
        }
        
    }

    void CreateBullet()
    {
        Instantiate(Bullet,Gun.transform.position,new Quaternion(0,0,0,0));
        Debug.Log("CreateBullet");
    }
    void StartMove()
    {
        CanMove = true;
        Debug.Log("StartMove");
    }

    void StopMove()
    {
        CanMove = false;
        Debug.Log("StopMove");
    }
}