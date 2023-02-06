using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSetting()
    {
        GetComponentInChildren<CanvasGroup>().alpha = 1;
        GetComponentInChildren<CanvasGroup>().interactable = true;
        GetComponentInChildren<CanvasGroup>().blocksRaycasts = true;
        
    }
}
