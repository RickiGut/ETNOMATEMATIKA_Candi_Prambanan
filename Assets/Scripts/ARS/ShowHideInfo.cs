using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideInfo : MonoBehaviour
{
    public GameObject[] InfoObject;
    private bool ShowInfo = false;

    public void ShowAndHide()
    {
        if (!ShowInfo)
        {
            InfoObject[0].SetActive(true);
            InfoObject[1].SetActive(true);
            InfoObject[2].SetActive(true);
            InfoObject[3].SetActive(true);
            InfoObject[4].SetActive(true);
            InfoObject[5].SetActive(true);
            InfoObject[6].SetActive(true);
            ShowInfo = true;
        }
        else
        {
            InfoObject[0].SetActive(false);
            InfoObject[1].SetActive(false);
            InfoObject[2].SetActive(false);
            InfoObject[3].SetActive(false);
            InfoObject[4].SetActive(false);
            InfoObject[5].SetActive(false);
            InfoObject[6].SetActive(false);
            ShowInfo = false;
        }

    }
}
