using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Player", menuName ="Player")]
public class Player : ScriptableObject
{
    public new string name;
    public float speed;
    
    public float movementDelay;
    public Color color= Color.red;
    public Material material;
    public Vector3[] spawnPoints;

    public void setcolor()
    {
        material.color = Color.red;
    }

}
