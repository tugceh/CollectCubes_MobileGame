using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    public int numberObject, numberOfCollectingCubes=0;
    public InputField numberObjectText;
    public float aRate;
    private string message="Black Player is Scriptable Player";
    private void Awake()
    {
        if (GameController.gameController == null)
        {
            GameController.gameController = this;
        }
        else
        {
            if (this != GameController.gameController)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(GameController.gameController.gameObject);
    }

    #region CollectingCubes
    public void IncreaseCollectingCubesCount()
    {

        numberOfCollectingCubes++;
        SetCollectingCubesCountVisual();
    }
    public void SetCollectingCubesCount(int aNumber)
    {
        numberOfCollectingCubes = aNumber;
        SetCollectingCubesCountVisual();
    }
    private void SetCollectingCubesCountVisual()
    {
        GameObject userInterface = GameObject.FindGameObjectWithTag("UserInterface");
        userInterface.GetComponent<UIController>().SetCollectingNumberCount(numberOfCollectingCubes);
    }
    public int GetCollectingCubesCount()
    {
        return numberOfCollectingCubes;
    }
    #endregion
    
    public void SetCollectingPBVisual()
    {
        GameObject userInterface = GameObject.FindGameObjectWithTag("UserInterface");
        userInterface.GetComponent<UIController>().SetCollectingProgressBar(aRate);
    }
    public void SetMessageVisual()
    {
        GameObject userInterface = GameObject.FindGameObjectWithTag("UserInterface");
        userInterface.GetComponent<UIController>().SetMessageText(message);
    }
   
    #region Objects
    /*public void GetInput(string objectNum)
    {
        numberObject = Convert.ToInt32(numberObjectText.text);
        GameObject myInterface = GameObject.FindGameObjectWithTag("UserInterface");
        myInterface.GetComponent<UIController>().SetObjectNumberCount(numberObject);
    }*/
    #endregion
}
