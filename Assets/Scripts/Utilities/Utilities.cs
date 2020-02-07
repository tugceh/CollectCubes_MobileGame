using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static Utilities utilities;

    private void Awake()
    {
        if (Utilities.utilities == null)
        {
            Utilities.utilities = this;
        }
        else
        {
            if (this != Utilities.utilities)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(Utilities.utilities.gameObject);
    }


    public void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
