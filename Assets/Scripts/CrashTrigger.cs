using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Destroy(other.gameObject);

            GameController.gameController.IncreaseCollectingCubesCount(); //Increase collision count in UI
            GameController.gameController.SetCollectingPBVisual();

            //other.gameObject.SetActive(false); //Hide died objects

            
            //GameController.gameController.IncreaseDestroyingCount(); //Increase Destroying Count in UI

            //Destroy(this.gameObject);

            



        }
    }
}
