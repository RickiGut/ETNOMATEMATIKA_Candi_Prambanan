using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotateHard : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControlHard.youWin)
        {
            transform.Rotate(0, 0, 90f);
        }
    }
}
