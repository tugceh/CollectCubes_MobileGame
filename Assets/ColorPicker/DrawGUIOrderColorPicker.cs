using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class DrawGUIOrderColorPicker : MonoBehaviour
{

	public GameObject cube;
	public int NumberOfCubes=10; //Number of Spawn Objects
	public Vector2 WorldSize = new Vector2(5, 5);


	public bool loadFromScene = true;
	public ColorPicker[] colorPicker;

	private List<ColorPicker> mColorPickerList;

	void Start()
	{
		if (loadFromScene)
		{
			colorPicker = GameObject.FindObjectsOfType<ColorPicker>();
		}
		mColorPickerList = new List<ColorPicker>();
		mColorPickerList.AddRange(colorPicker);
	}
	public void InstantiateObj() //Instantiate Cubes
	{
		for (int i = 0; i < NumberOfCubes; i++)
		{
			
            
			mColorPickerList = mColorPickerList.OrderBy(item => item.drawOrder).ToList();
			mColorPickerList.Reverse();
			mColorPickerList.CopyTo(colorPicker);

			foreach (var elem in mColorPickerList)
			{
				elem.useExternalDrawer = true;
			}
			Instantiate(cube).transform.position = new Vector3(Random.Range(0, WorldSize.x), 0.27f, Random.Range(0, WorldSize.y));
			cube.tag = "Cube";

		}




	}
    
	void OnGUI () 
	{
		foreach(var elem in mColorPickerList)
		{
			elem._DrawGUI();
		}
	}
}
