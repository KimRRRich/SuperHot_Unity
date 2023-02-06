using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryDrop : MonoBehaviour
{
    public float DestoryTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, DestoryTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
