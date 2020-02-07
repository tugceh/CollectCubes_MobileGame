using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerDisplay : MonoBehaviour
{
    public Player player;

    public GameObject plyr;

    // This will be appended to the name of the created entities and increment when each is created.
    int instanceNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }



    void CreatePlayer()
    {
        int currentSpawnPointIndex = 0;


        // Creates an instance of the prefab at the current spawn point.
        GameObject currentEntity = Instantiate(plyr, player.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

        currentEntity.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
        currentEntity.name = player.name + instanceNumber;

        // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
        currentSpawnPointIndex = (currentSpawnPointIndex + 1) % player.spawnPoints.Length;
        GameController.gameController.SetMessageVisual();
        instanceNumber++;

    }
}
