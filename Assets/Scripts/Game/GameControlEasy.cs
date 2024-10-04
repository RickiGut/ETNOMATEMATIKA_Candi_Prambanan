using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlEasy : MonoBehaviour
{
    [SerializeField] Transform[] pictures;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject winButton;

    public static bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        winButton.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameEasy();
    }


    public void gameEasy()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 )
        {
            youWin = true;
            winText.SetActive(true);
            winButton.SetActive(true);
        }
    }
}
