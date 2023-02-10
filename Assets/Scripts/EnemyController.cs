using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public enum Type
    {
        GUN, NOGUN
    }
    public Type type;
    public float moveSpeed;
    public int TrackDis = 4000;
    public int ShootDis = 30;
    private CharacterController cc;
    private Vector3 moveDirection;
    private float moveDistance;
    private Vector3 moveVector;
    private GameObject player;
    private Animator animator;
    private bool CanMove=true;
    public GameObject Bullet;
    public GameObject Gun;
    public bool GameOver = false;
    private bool isDead;
    private AudioSource AudioSource;
    

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        //Bullet = GameObject.Find("Bullet");
        cc = GetComponent<CharacterController>();
        AudioSource = GetComponent<AudioSource>();
        moveDirection = Vector3.zero;
        moveSpeed = 4.0f;
        animator = GetComponent<Animator>();
        isDead = false;
        GameOver = false;
        CanMove = true;
    }

    // Update is called once per frame
    void Update () {
        if (!GameOver)
        {
            moveDirection = (player.transform.position - this.transform.position).normalized;
            moveDistance = (player.transform.position - this.transform.position).magnitude;
            if (CanMove)
            {
                if (moveDistance < TrackDis && moveDistance > ShootDis)
                {
                    animator.SetBool("Run", true);
                    Vector3 pos = player.transform.position;
                    pos.y = transform.position.y;
                    transform.LookAt(pos);
                    moveVector = new Vector3(moveDirection.x * Time.deltaTime * moveSpeed, 0, moveDirection.z * Time.deltaTime * moveSpeed);
                    cc.Move(moveVector);
                    
                }
                else if (moveDistance < ShootDis)
                {
                    this.transform.LookAt(new Vector3(player.transform.position.x,this.transform.position.y,player.transform.position.z));
                    animator.SetTrigger("Shoot");
                }
                else if (moveDistance > TrackDis)
                {
                    animator.SetBool("Run", false);
                }
            }
        }
        else
        {
            animator.SetBool("Run", false);
        }
       
        
    }

    void CreateBullet()
    {
        Instantiate(Bullet,Gun.transform.position,new Quaternion(0,0,0,0));
        //Debug.Log("CreateBullet");
    }
    void StartMove()
    {
        CanMove = true;
        //Debug.Log("StartMove");
    }

    void StopMove()
    {
        CanMove = false;
        //Debug.Log("StopMove");
    }

    public void GetShoot()
    {
        if (!isDead)
        {
            animator.SetTrigger("death1");
            AudioSource.Play();
            CanMove = false;
            Destroy(gameObject, 3);
            isDead = true;
        }
        
    }
}
