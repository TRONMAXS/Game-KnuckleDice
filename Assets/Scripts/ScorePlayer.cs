using UnityEngine;
using UnityEngine.UI;

public  class ScorePlayer : MonoBehaviour
{
    public static int[,] BonesRED = new int[3, 3];
    public static int[,] BonesBLUE = new int[3, 3];

    public int[,] arrayRED = new int[3,3];
    public int[,] arrayBLUE = new int[3, 3];
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
    private GamePanelButtonRed _arrayR;
    public GameObject InstantiateMSBLUE;
    private GamePanelButtonRed _arrayB;

    public GameObject InstantiateGameObjectRED;
    private GamePanelButtonRed _arrayGameObjectR;
    public GameObject InstantiateGameObjectBLUE;
    private GamePanelButtonRed _arrayGameObjectB;

    private void Start()
    {
        _arrayR = InstantiateMSRED.GetComponent<GamePanelButtonRed>();
        _arrayB = InstantiateMSBLUE.GetComponent<GamePanelButtonRed>();

        _arrayGameObjectR = InstantiateGameObjectRED.GetComponent<GamePanelButtonRed>();
        _arrayGameObjectB = InstantiateGameObjectBLUE.GetComponent<GamePanelButtonRed>();
    }

    public void Array()
    {
        for (int i = 0; i < arrayRED.GetLength(0); i++)
        {
            for (int j = 0; j < arrayRED.GetLength(1); j++)
            {
                arrayRED[i, j] = _arrayR.InstantiateBonesRED[i, j];
            }
        }

        for (int i = 0; i < arrayBLUE.GetLength(0); i++)
        {
            for (int j = 0; j < arrayBLUE.GetLength(1); j++)
            {
                arrayBLUE[i, j] = _arrayB.InstantiateBonesBLUE[i, j];
            }
        }
    }

    public void DeleteBones(int numberToFind, int j, string array)
    {

        if (array == "RED")
        {
            for (int i = 0; i < arrayBLUE.GetLength(0); i++)
            {
                if (arrayBLUE[i, j] == numberToFind)
                {
                    Destroy(_arrayGameObjectB.gameObjectsInstantiateBLUE[i, j]);
                    _arrayB.InstantiateBonesBLUE[i, j] = 0;
                    _arrayGameObjectB.gameObjectsInstantiateBLUE[i, j] = null;
                    Score("CNB" + (j + 1));
                }
            }
        }
        else if (array == "BLUE")
        {
            for (int i = 0; i < arrayBLUE.GetLength(0); i++)
            {
                if (arrayRED[i, j] == numberToFind)
                {
                    Destroy(_arrayGameObjectR.gameObjectsInstantiateRED[i, j]);
                    _arrayR.InstantiateBonesRED[i, j] = 0;
                    _arrayGameObjectR.gameObjectsInstantiateRED[i, j] = null;
                    Score("CNR" + (j + 1));
                }
            }
        }
    }
    //2 .  .  .
    //1 .  .  .
    //0 .  .  .
    //  0  1  2
    ///////////

    public void Score(string СolumnName)
    {
        Array();

        switch (СolumnName)
        {
            case "CNR1":

                if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] == arrayRED[2, 0])
                {
                    REDtext1 = (arrayRED[0, 0] + arrayRED[1, 0] + arrayRED[2, 0]) * 3;
                    //Debug.Log("все равны   " + REDtext1);
                }
                else if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
                {
                    REDtext1 = ((arrayRED[0, 0] + arrayRED[1, 0]) * 2) + arrayRED[2, 0];
                    //Debug.Log("равны 0 и 1   " + REDtext1);
                }
                else if (arrayRED[1, 0] == arrayRED[2, 0] & arrayRED[1, 0] != arrayRED[0, 0])
                {
                    REDtext1 = ((arrayRED[1, 0] + arrayRED[2, 0]) * 2) + arrayRED[0, 0];
                    //Debug.Log("равны 1 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 0] == arrayRED[2, 0] & arrayRED[0, 0] != arrayRED[1, 0])
                {
                    REDtext1 = ((arrayRED[0, 0] + arrayRED[2, 0]) * 2) + arrayRED[1, 0];
                    //Debug.Log("равны 0 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 0] != arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
                {
                    REDtext1 = arrayRED[0, 0] + arrayRED[1, 0] + arrayRED[2, 0];
                    //Debug.Log("все не равны   " + REDtext1);
                }
                TextScore("R1");
                break;            

            case "CNR2":

                if (arrayRED[0, 1] == arrayRED[1, 1] & arrayRED[0, 1] == arrayRED[2, 1])
                {
                    REDtext2 = (arrayRED[0, 1] + arrayRED[1, 1] + arrayRED[2, 1]) * 3;
                    TextScore("R2");
                    //Debug.Log("все равны   " + REDtext1);
                }
                else if (arrayRED[0, 1] == arrayRED[1, 1] & arrayRED[0, 1] != arrayRED[2, 1])
                {
                    REDtext2 = ((arrayRED[0, 1] + arrayRED[1, 1]) * 2) + arrayRED[2, 1];
                    TextScore("R2");
                   //Debug.Log("равны 0 и 1   " + REDtext1);
                }
                else if (arrayRED[1, 1] == arrayRED[2, 1] & arrayRED[1, 1] != arrayRED[0, 1])
                {
                    REDtext2 = ((arrayRED[1, 1] + arrayRED[2, 1]) * 2) + arrayRED[0, 1];
                    TextScore("R2");
                    //Debug.Log("равны 1 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 1] == arrayRED[2, 1] & arrayRED[0, 1] != arrayRED[1, 1])
                {
                    REDtext2 = ((arrayRED[0, 1] + arrayRED[2, 1]) * 2) + arrayRED[1, 1];
                    TextScore("R2");
                    //Debug.Log("равны 0 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 1] != arrayRED[1, 1] & arrayRED[0, 1] != arrayRED[2, 1])
                {
                    REDtext2 = arrayRED[0, 1] + arrayRED[1, 1] + arrayRED[2, 1];
                    TextScore("R2");
                    //Debug.Log("все не равны   " + REDtext1);
                }
                break;

            case "CNR3":

                if (arrayRED[0, 2] == arrayRED[1, 2] & arrayRED[0, 2] == arrayRED[2, 2])
                {
                    REDtext3 = (arrayRED[0, 2] + arrayRED[1, 2] + arrayRED[2, 2]) * 3;
                    TextScore("R3");
                    //Debug.Log("все равны   " + REDtext1);
                }
                else if (arrayRED[0, 2] == arrayRED[1, 2] & arrayRED[0, 2] != arrayRED[2, 2])
                {
                    REDtext3 = ((arrayRED[0, 2] + arrayRED[1, 2]) * 2) + arrayRED[2, 2];
                    TextScore("R3");
                    //Debug.Log("равны 0 и 1   " + REDtext1);
                }
                else if (arrayRED[1, 2] == arrayRED[2, 2] & arrayRED[1, 2] != arrayRED[0, 2])
                {
                    REDtext3 = ((arrayRED[1, 2] + arrayRED[2, 2]) * 2) + arrayRED[0, 2];
                    TextScore("R3");
                    //Debug.Log("равны 1 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 2] == arrayRED[2, 2] & arrayRED[0, 2] != arrayRED[1, 2])
                {
                    REDtext3 = ((arrayRED[0, 2] + arrayRED[2, 2]) * 2) + arrayRED[1, 2];
                    TextScore("R3");
                    //Debug.Log("равны 0 и 2   " + REDtext1);
                }
                else if (arrayRED[0, 2] != arrayRED[1, 2] & arrayRED[0, 2] != arrayRED[2, 2])
                {
                    REDtext3 = arrayRED[0, 2] + arrayRED[1, 2] + arrayRED[2, 2];
                    TextScore("R3");
                    //Debug.Log("все не равны   " + REDtext1);
                }
                break;

            case "CNB1":

                if (arrayBLUE[0, 0] == arrayBLUE[1, 0] & arrayBLUE[0, 0] == arrayBLUE[2, 0])
                {
                    BLUEtext1 = (arrayBLUE[0, 0] + arrayBLUE[1, 0] + arrayBLUE[2, 0]) * 3;
                    TextScore("B1");
                    //Debug.Log("все равны   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 0] == arrayBLUE[1, 0] & arrayBLUE[0, 0] != arrayBLUE[2, 0])
                {
                    BLUEtext1 = ((arrayBLUE[0, 0] + arrayBLUE[1, 0]) * 2) + arrayBLUE[2, 0];
                    TextScore("B1");
                    //Debug.Log("равны 0 и 1   " + BLUEtext1);
                }
                else if (arrayBLUE[1, 0] == arrayBLUE[2, 0] & arrayBLUE[1, 0] != arrayBLUE[0, 0])
                {
                    BLUEtext1 = ((arrayBLUE[1, 0] + arrayBLUE[2, 0]) * 2) + arrayBLUE[0, 0];
                    TextScore("B1");
                    //Debug.Log("равны 1 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 0] == arrayBLUE[2, 0] & arrayBLUE[0, 0] != arrayBLUE[1, 0])
                {
                    BLUEtext1 = ((arrayBLUE[0, 0] + arrayBLUE[2, 0]) * 2) + arrayBLUE[1, 0];
                    TextScore("B1");
                    //Debug.Log("равны 0 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 0] != arrayBLUE[1, 0] & arrayBLUE[0, 0] != arrayBLUE[2, 0])
                {
                    BLUEtext1 = arrayBLUE[0, 0] + arrayBLUE[1, 0] + arrayBLUE[2, 0];
                    TextScore("B1");
                    //Debug.Log("все не все не равны   " + BLUEtext1);
                }
                break;

            case "CNB2":

                if (arrayBLUE[0, 1] == arrayBLUE[1, 1] & arrayBLUE[0, 1] == arrayBLUE[2, 1])
                {
                    BLUEtext2 = (arrayBLUE[0, 1] + arrayBLUE[1, 1] + arrayBLUE[2, 1]) * 3;
                    TextScore("B2");
                    //Debug.Log("все равны   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 1] == arrayBLUE[1, 1] & arrayBLUE[0, 1] != arrayBLUE[2, 1])
                {
                    BLUEtext2 = ((arrayBLUE[0, 1] + arrayBLUE[1, 1]) * 2) + arrayBLUE[2, 1];
                    TextScore("B2");
                    //Debug.Log("равны 0 и 1   " + BLUEtext1);
                }
                else if (arrayBLUE[1, 1] == arrayBLUE[2, 1] & arrayBLUE[1, 1] != arrayBLUE[0, 1])
                {
                    BLUEtext2 = ((arrayBLUE[1, 1] + arrayBLUE[2, 1]) * 2) + arrayBLUE[0, 1];
                    TextScore("B2");
                    //Debug.Log("равны 1 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 1] == arrayBLUE[2, 1] & arrayBLUE[0, 1] != arrayBLUE[1, 1])
                {
                    BLUEtext2 = ((arrayBLUE[0, 1] + arrayBLUE[2, 1]) * 2) + arrayBLUE[1, 1];
                    TextScore("B2");
                    //Debug.Log("равны 0 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 1] != arrayBLUE[1, 1] & arrayBLUE[0, 1] != arrayBLUE[2, 1])
                {
                    BLUEtext2 = arrayBLUE[0, 1] + arrayBLUE[1, 1] + arrayBLUE[2, 1];
                    TextScore("B2");
                    //Debug.Log("все не все не равны   " + BLUEtext1);
                }
                break;

            case "CNB3":

                if (arrayBLUE[0, 2] == arrayBLUE[1, 2] & arrayBLUE[0, 2] == arrayBLUE[2, 2])
                {
                    BLUEtext3 = (arrayBLUE[0, 2] + arrayBLUE[1, 2] + arrayBLUE[2, 2]) * 3;
                    TextScore("B3");
                    //Debug.Log("все равны   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 2] == arrayBLUE[1, 2] & arrayBLUE[0, 2] != arrayBLUE[2, 2])
                {
                    BLUEtext3 = ((arrayBLUE[0, 2] + arrayBLUE[1, 2]) * 2) + arrayBLUE[2, 2];
                    TextScore("B3");
                    //Debug.Log("равны 0 и 1   " + BLUEtext1);
                }
                else if (arrayBLUE[1, 2] == arrayBLUE[2, 2] & arrayBLUE[1, 2] != arrayBLUE[0, 2])
                {
                    BLUEtext3 = ((arrayBLUE[1, 2] + arrayBLUE[2, 2]) * 2) + arrayBLUE[0, 2];
                    TextScore("B3");
                    //Debug.Log("равны 1 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 2] == arrayBLUE[2, 2] & arrayBLUE[0, 2] != arrayBLUE[1, 2])
                {
                    BLUEtext3 = ((arrayBLUE[0, 2] + arrayBLUE[2, 2]) * 2) + arrayBLUE[1, 2];
                    TextScore("B3");
                    //Debug.Log("равны 0 и 2   " + BLUEtext1);
                }
                else if (arrayBLUE[0, 2] != arrayBLUE[1, 2] & arrayBLUE[0, 2] != arrayBLUE[2, 2])
                {
                    BLUEtext3 = arrayBLUE[0, 2] + arrayBLUE[1, 2] + arrayBLUE[2, 2];
                    TextScore("B3");
                    //Debug.Log("все не равны   " + BLUEtext1);
                }
                break;
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
    public void TextScoreDelete(string textUpdate, int deletenambr)
    {
        switch (textUpdate)
        {
            case "R0":
                textScoreR1.text = (REDtext1 - deletenambr).ToString();
                break;
            case "R1":
                textScoreR2.text = (REDtext2 - deletenambr).ToString();
                break;
            case "R2":
                textScoreR3.text = (REDtext3 - deletenambr).ToString();
                break;
            case "B0":
                textScoreB1.text = (BLUEtext1 - deletenambr).ToString();
                break;
            case "B1":
                textScoreB2.text = (BLUEtext2 - deletenambr).ToString();
                break;
            case "B2":
                textScoreB3.text = (BLUEtext3 - deletenambr).ToString();
                break;
        }
    }
}