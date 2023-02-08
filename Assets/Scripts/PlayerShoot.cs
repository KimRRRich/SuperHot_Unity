using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public GameObject ShootPlace;
    private AudioSource gunshoot;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        ShootPlace = GameObject.Find("ShootPlace");
        gunshoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBullet()
    {
        
        Instantiate(Bullet, ShootPlace.transform.position, ShootPlace.transform.rotation);
        
        Debug.Log("CreateBullet");
    }

    void StartShoot()
    {
        gunshoot.Play();
        Player.GetComponent<PlayerController>().CanShoot = false;
    }

    void ShootOver()
    {
        Player.GetComponent<PlayerController>().CanShoot = true;
        Debug.Log("ShootOver");
    }
}
