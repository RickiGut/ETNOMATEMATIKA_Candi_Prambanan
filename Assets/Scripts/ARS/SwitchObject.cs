using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public GameObject[] BangunRuang;

    // Berfungsi untuk menampilkan objek balok dan menonaktifkan objek lainnya
    public void Balok()
    {
        BangunRuang[0].SetActive(true);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(false);
    }

    public void Bola()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(true);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(false);
    }

    public void Kerucut()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(true);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(false);
    }

    public void Kubus()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(true);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(false);
    }


    public void limas4()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(true);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(false);
    }

    public void prisma()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(true);
        BangunRuang[6].SetActive(false);
    }

    public void tabung()
    {
        BangunRuang[0].SetActive(false);
        BangunRuang[1].SetActive(false);
        BangunRuang[2].SetActive(false);
        BangunRuang[3].SetActive(false);
        BangunRuang[4].SetActive(false);
        BangunRuang[5].SetActive(false);
        BangunRuang[6].SetActive(true);
    }

}
