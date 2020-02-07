using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public Transform infoPanel;
    public GameObject objects;
    public GameObject demoscript;
    public Text numberCollectingText,messageText;
    public InputField numberObjectText;
    public Button create;
    public int numberObject;
    public Slider progressBar;

    public string message;
    private void Start()
    {

        //SetCollectingProgressBar(GameController.gameController.aRate);
        SetCollectingNumberCount(GameController.gameController.numberOfCollectingCubes);
    }


    public void SetCollectingProgressBar(float aRate)
    {
        progressBar.value += Mathf.Abs(0.1f + aRate);
    }
    
    public void SetCollectingNumberCount(int aNumber)
    {

        numberCollectingText.text = aNumber.ToString();

    }
    public void SetMessageText(string message)
    {
        
        messageText.text = message;
    }
    public void SetObjectNumberCount(int aNumber)
    {

        demoscript = GameObject.FindGameObjectWithTag("Script");
        demoscript.GetComponent<DrawGUIOrderColorPicker>().NumberOfCubes = aNumber;

    }

    public void GetInput()
    {
        numberObject = Convert.ToInt32(numberObjectText.text);
        demoscript = GameObject.FindGameObjectWithTag("Script");
        demoscript.GetComponent<DrawGUIOrderColorPicker>().NumberOfCubes = numberObject;
    }
}
