using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class quiz : MonoBehaviour
{
    //[SerializeField] Button berhitungButton;
    [SerializeField] Button kembaliButton;

    public void question(bool answer)
    {
        int score = PlayerPrefs.GetInt("score");

        if (answer)
        {
            score += 10;
        }
        else
        {
            score -= 0;
            if (score < 0)
            {
                score = 0;
            }
        }
        PlayerPrefs.SetInt("score", score);


        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

   
}