using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        /*for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchp = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero,touchp,Color.red);
        }*/

        if (Input.touchCount >0)
        {
           
            Touch touch = Input.GetTouch(0);
            Vector3 touuch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            //transform.position = touuch_Pos;
            playerMovement.TurnLeftRight();
            playerMovement.LookUpDown();

            if (touuch_Pos.x >0)
            {
                playerMovement.MoveLeftRight();
            }
            if (touuch_Pos.z >0)
            {
                playerMovement.MoveForwardBack();
            }
        }
    }
}
