using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlHard : MonoBehaviour
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
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0 &&
            pictures[12].rotation.z == 0 &&
            pictures[13].rotation.z == 0 &&
            pictures[14].rotation.z == 0 &&
            pictures[15].rotation.z == 0 &&
            pictures[16].rotation.z == 0 &&
            pictures[17].rotation.z == 0 &&
            pictures[18].rotation.z == 0 &&
            pictures[19].rotation.z == 0 &&
            pictures[20].rotation.z == 0 &&
            pictures[21].rotation.z == 0 &&
            pictures[22].rotation.z == 0 &&
            pictures[23].rotation.z == 0 &&
            pictures[24].rotation.z == 0 &&
            pictures[25].rotation.z == 0 &&
            pictures[26].rotation.z == 0 &&
            pictures[27].rotation.z == 0 &&
            pictures[28].rotation.z == 0 &&
            pictures[29].rotation.z == 0 &&
            pictures[30].rotation.z == 0 &&
            pictures[31].rotation.z == 0 &&
            pictures[32].rotation.z == 0 &&
            pictures[33].rotation.z == 0 &&
            pictures[34].rotation.z == 0 &&
            pictures[35].rotation.z == 0 &&
            pictures[36].rotation.z == 0 &&
            pictures[37].rotation.z == 0 &&
            pictures[38].rotation.z == 0 &&
            pictures[39].rotation.z == 0 &&
            pictures[40].rotation.z == 0 &&
            pictures[41].rotation.z == 0 &&
            pictures[42].rotation.z == 0 &&
            pictures[43].rotation.z == 0 &&
            pictures[44].rotation.z == 0 &&
            pictures[45].rotation.z == 0 &&
            pictures[46].rotation.z == 0 &&
            pictures[47].rotation.z == 0 &&
            pictures[48].rotation.z == 0 &&
            pictures[49].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
            winButton.SetActive(true);
        }
    }
}
