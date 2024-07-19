using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public  class ScorePlayer : MonoBehaviour
{
    public static int[,] BonesRED = new int[3, 3];
    public static int[,] BonesBLUE = new int[3, 3];

    public int[,] arrayRED = new int[3,3];
    public Text textScoreR1;
    public Text textScoreR2;
    public Text textScoreR3;

    public Text textScoreB1;
    public Text textScoreB2;
    public Text textScoreB3;

    public int REDtext1;
    public int REDtext2;
    public int REDtext3;
    public int BLUEtext1;
    public int BLUEtext2;
    public int BLUEtext3;

    public GameObject InstantiateMSRED;
    private GamePanelButtonRed _actionTarget;

    private void Start()
    {
        _actionTarget = InstantiateMSRED.GetComponent<GamePanelButtonRed>();
        //Score();
        //TextScore();
    }

    public void Array()
    {
        for (int i = 0; i < arrayRED.GetLength(0); i++)
        {
            for (int j = 0; j < arrayRED.GetLength(1); j++)
            {
                arrayRED[i, j] = _actionTarget.InstantiateBonesRED[i, j];
            }
        }
    }
    //2 .  .  .
    //1 .  .  .
    //0 .  .  .
    //  0  1  2
    ///////////

    public void Score()
    {
        Array();

        Debug.Log(arrayRED[0, 0]);
        Debug.Log(arrayRED[1, 0]);
        Debug.Log(arrayRED[2, 0]);
/*        Debug.Log(arrayRED[0, 1]);
        Debug.Log(arrayRED[1, 1]);
        Debug.Log(arrayRED[2, 1]);
        Debug.Log(arrayRED[0, 2]);
        Debug.Log(arrayRED[1, 2]);
        Debug.Log(arrayRED[2, 2]);*/

        if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] == arrayRED[2, 0])
        {
            REDtext1 = arrayRED[0, 0] * arrayRED[1, 0] * arrayRED[2, 0];
            TextScore("R1");
            Debug.Log("все равны   " + REDtext1);
        }
        else if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
        {
            REDtext1 = arrayRED[0, 0] * arrayRED[1, 0] + arrayRED[2, 0];
            TextScore("R1");
            Debug.Log("равны 0 и 1   " + REDtext1);
        }
        else if (arrayRED[1, 0] == arrayRED[2, 0] & arrayRED[1, 0] != arrayRED[0, 0])
        {
            REDtext1 = arrayRED[1, 0] * arrayRED[2, 0] + arrayRED[0, 0];
            TextScore("R1");
            Debug.Log("равны 1 и 2   " + REDtext1);
        }
        else if (arrayRED[0, 0] == arrayRED[2, 0] & arrayRED[0, 0] != arrayRED[1, 0])
        {
            REDtext1 = arrayRED[0, 0] * arrayRED[2, 0] + arrayRED[1, 0];
            TextScore("R1");
            Debug.Log("равны 0 и 2   " + REDtext1);
        }
        else if (arrayRED[0, 0] != arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
        {
            REDtext1 = arrayRED[0, 0] + arrayRED[1, 0] + arrayRED[2, 0];
            TextScore("R1");
        }

    }
    public void TextScore(string textUpdate)
    {
        switch (textUpdate)
        {
            case "R1":
                textScoreR1.text = (REDtext1).ToString(); 
                break;
            case "R2":
                textScoreR2.text = (REDtext2).ToString();
                break;
            case "R3":
                textScoreR3.text = (REDtext3).ToString();
                break;
            case "B1":
                textScoreB1.text = (BLUEtext1).ToString();
                break;
            case "B2":
                textScoreB2.text = (BLUEtext2).ToString();
                break;
            case "B3":
                textScoreB3.text = (BLUEtext3).ToString();
                break;
        }
    }
}
