using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    float time;
    public GameObject CreatePoint1;
    public GameObject CreatePoint2;
    public GameObject CreatePoint3;
    public GameObject CreatePoint4;
    public GameObject Enemy;
    public bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver==false){
            time += Time.deltaTime;
            if (time > 3)
            {
                int a = Random.Range(1, 3);
                if (a == 1)
                {
                    Instantiate(Enemy, CreatePoint1.transform.position, CreatePoint1.transform.rotation);
                    Instantiate(Enemy, CreatePoint3.transform.position, CreatePoint3.transform.rotation);
                }
                else
                {
                    Instantiate(Enemy, CreatePoint2.transform.position, CreatePoint2.transform.rotation);
                    Instantiate(Enemy, CreatePoint4.transform.position, CreatePoint3.transform.rotation);
                }

                Debug.Log("CreateEnemy!");
                time -= 3;
            }
        }
        
    }
}