using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmSetting : MonoBehaviour
{
    public int fps_set=1;
    public int res_set=1;
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }
    public void WindowFullize()
    {
        Screen.fullScreen = true;
    }
    public void Windowlize()
    {
        Screen.fullScreen = false;
    }
    public void forwardButton()
    {
        if (fps_set == 2)
        {
            fps_set = 0;
        }
        else
        {
            fps_set += 1;
        }
        changeFPSText(fps_set);
    }
    public void backButton()
    {
        if (fps_set == 0)
        {
            fps_set = 2;
        }
        else
        {
            fps_set -= 1;
        }
        changeFPSText(fps_set);
    }
    public void changeFPSText(int _fps_set)
    {
        Text text_fps = GameObject.Find("Canvas/settings/SettingPanel/ScreenFPS/fps").GetComponent<Text>();
        Image image_fps0 = GameObject.Find("Canvas/settings/SettingPanel/ScreenFPS/00").GetComponent<Image>();
        Image image_fps1 = GameObject.Find("Canvas/settings/SettingPanel/ScreenFPS/11").GetComponent<Image>();
        Image image_fps2 = GameObject.Find("Canvas/settings/SettingPanel/ScreenFPS/22").GetComponent<Image>();
        if (_fps_set == 0)
        {
            text_fps.text = "30HZ";
            image_fps0.color = new Color(255, 255, 255, 1);
            image_fps1.color = new Color(255, 255, 255, 0.5f);
            image_fps2.color = new Color(255, 255, 255, 0.5f);
            Application.targetFrameRate = 30;
            
        }
        else if (_fps_set == 1)
        {
            text_fps.text = "60HZ";
            image_fps0.color = new Color(255, 255, 255, 0.5f);
            image_fps1.color = new Color(255, 255, 255, 1);
            image_fps2.color = new Color(255, 255, 255, 0.5f);
            Application.targetFrameRate = 60;
        }
        else if (_fps_set == 2)
        {
            text_fps.text = "120HZ";
            image_fps0.color = new Color(255, 255, 255, 0.5f);
            image_fps1.color = new Color(255, 255, 255, 0.5f);
            image_fps2.color = new Color(255, 255, 255, 1);
            Application.targetFrameRate = 120;
        }

    }
    public void forwardButton1()
    {
        if (res_set == 2)
        {
            res_set = 0;
        }
        else
        {
            res_set += 1;
        }
        changeResolutionText(res_set);
    }
    public void backButton1()
    {
        if (res_set == 0)
        {
            res_set = 2;
        }
        else
        {
            res_set -= 1;
        }
        changeResolutionText(res_set);
    }
    public void changeResolutionText(int _res_set)
    {
        Text text_fps = GameObject.Find("Canvas/settings/SettingPanel/ScreenResolusion/resolution").GetComponent<Text>();
        Image image_fps0 = GameObject.Find("Canvas/settings/SettingPanel/ScreenResolusion/00").GetComponent<Image>();
        Image image_fps1 = GameObject.Find("Canvas/settings/SettingPanel/ScreenResolusion/11").GetComponent<Image>();
        Image image_fps2 = GameObject.Find("Canvas/settings/SettingPanel/ScreenResolusion/22").GetComponent<Image>();
        if (_res_set == 0)
        {
            text_fps.text = "1280x720";
            image_fps0.color = new Color(255, 255, 255, 1);
            image_fps1.color = new Color(255, 255, 255, 0.5f);
            image_fps2.color = new Color(255, 255, 255, 0.5f);
            Screen.SetResolution(1280, 720,Screen.fullScreen);
        }
        else if (_res_set == 1)
        {
            text_fps.text = "1920x1080";
            image_fps0.color = new Color(255, 255, 255, 0.5f);
            image_fps1.color = new Color(255, 255, 255, 1);
            image_fps2.color = new Color(255, 255, 255, 0.5f);
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        }
        else if (_res_set == 2)
        {
            text_fps.text = "2560¡Á1440";
            image_fps0.color = new Color(255, 255, 255, 0.5f);
            image_fps1.color = new Color(255, 255, 255, 0.5f);
            image_fps2.color = new Color(255, 255, 255, 1);
            Screen.SetResolution(2560, 1440, Screen.fullScreen);
        }
    }
    public void EXITPanel()
    {
        GetComponentInParent<CanvasGroup>().alpha = 0;
        GetComponentInParent<CanvasGroup>().interactable = false;
        GetComponentInParent<CanvasGroup>().blocksRaycasts = false;
    }
    public void CancleSet()
    {
        changeFPSText(1);
        changeResolutionText(1);
        Screen.SetResolution(1920, 1080, true, 60);
    }
}
