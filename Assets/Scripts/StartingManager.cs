using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingManager : MonoBehaviour
{
    public GameObject cube;
    private DrawGUIOrderColorPicker colorcube;
    public int NumberOfBodies = 5; //Number of Spawn Objects
    public Vector2 WorldSize = new Vector2(50, 50);

    private void Start()
    {
        /*for (int i = 0; i < NumberOfBodies; i++)
        {

            InstantiateObj(); //Instantiate objects

        }*/

    }
    private void Update()
    {
        
    }
    public void InstantiateObj()
    {
        for(int i = 0; i < NumberOfBodies; i++)
        {
            colorcube.colorPicker= GameObject.FindObjectsOfType<ColorPicker>();
            
            Instantiate(cube).transform.position = new Vector3(Random.Range(0, WorldSize.x), 0.27f, Random.Range(0, WorldSize.y));
            cube.tag = "Cube";

        }
        

       

    }

}
