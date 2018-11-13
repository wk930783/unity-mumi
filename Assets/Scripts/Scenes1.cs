using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenes1 : MonoBehaviour {
    // Use this for initialization
    public Button BtnStart;
    public Button BtnExit;


    // Use this for initialization
    void Start()
    {
        BtnStart.onClick.AddListener(BtnStartOnClick);
        BtnExit.onClick.AddListener(BtnExitOnClick);
    }

    public void BtnStartOnClick()
    {
        Debug.Log("yee");
        Application.LoadLevel("Scenes2");
    }

    public void BtnExitOnClick()
    {
        Debug.Log("wryyyyyyyy");
        Application.Quit();
    }

    void Update()
    {
        
    }
}
