using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchRotateEasy : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControlEasy.youWin)
        {
            transform.Rotate(0, 0, 90f);
        }
    }
}
