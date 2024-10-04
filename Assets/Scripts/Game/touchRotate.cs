using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youWin)
        {
            transform.Rotate(0, 0, 90f);
        }    
    }
}
