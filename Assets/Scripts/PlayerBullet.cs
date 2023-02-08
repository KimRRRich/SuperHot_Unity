using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float speed = 10.0f;
    private Vector3 moveDirection;
    //public GameObject ShootPlace;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(0, 0, 1);
        //ShootPlace = GameObject.Find("ShootPlace");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * speed,Space.Self);
    }

    public void OnTriggerEnter(Collider other)
    {
        
            if (other.GetComponent<Collider>().CompareTag("Enemy"))
            {
                other.gameObject.GetComponent<EnemyController>().GetShoot();
                 Destroy(gameObject);
             }
            else if (other.GetComponent<Collider>().CompareTag("Wall"))
            {
                Destroy(gameObject);
                //Debug.Log("Wall get shooted!");
            }
        

    }
}
