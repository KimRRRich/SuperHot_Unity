using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    private Slider slider;
    private Text text;
    void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        text = slider.transform.Find("persent").GetComponent<Text>();
        text.text = " ";
    }
    void Update()
    {
        if (slider.value < 100)
        {
            text.text = Mathf.Round(slider.value*100) + "%";
        }
    }
}
