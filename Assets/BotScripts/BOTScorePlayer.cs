using UnityEngine;
using UnityEngine.UI;

public class BOTScorePlayer : MonoBehaviour
{
    public static int[,] BonesRED = new int[3, 3];
    public static int[,] BonesBLUE = new int[3, 3];

    public int[] NumsBones = { 0, 1, 2, 3, 4, 5 };

    public int[,] arrayRED = new int[3, 3];
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
    private BOTGamePanelButtonRed _arrayR;
    public GameObject InstantiateMSBLUE;
    private BOTGamePanelButtonRed _arrayB;

    public GameObject InstantiateGameObjectRED;
    private BOTGamePanelButtonRed _arrayGameObjectR;
    public GameObject InstantiateGameObjectBLUE;
    private BOTGamePanelButtonRed _arrayGameObjectB;

    public GameObject BonesMoveDownRED;
    private BOTGamePanelButtonRed _BonesMoveDownR;
    public GameObject BonesMoveDownBLUE;
    private BOTGamePanelButtonRed _BonesMoveDown;

    private void Start()
    {
        _arrayR = InstantiateMSRED.GetComponent<BOTGamePanelButtonRed>();
        _arrayB = InstantiateMSBLUE.GetComponent<BOTGamePanelButtonRed>();

        _arrayGameObjectR = InstantiateGameObjectRED.GetComponent<BOTGamePanelButtonRed>();
        _arrayGameObjectB = InstantiateGameObjectBLUE.GetComponent<BOTGamePanelButtonRed>();

        _BonesMoveDownR = BonesMoveDownRED.GetComponent<BOTGamePanelButtonRed>();
        _BonesMoveDown = BonesMoveDownBLUE.GetComponent<BOTGamePanelButtonRed>();
    }

    private void Array()
    {
        for (int i = 0; i < arrayRED.GetLength(0); i++)
        {
            for (int j = 0; j < arrayRED.GetLength(1); j++)
            {
                arrayRED[i, j] = _arrayR.InstantiateBonesRED[i, j];
                if (arrayRED[i, j] == 10)
                {
                    arrayRED[i, j] = 0;
                }
            }
        }

        for (int i = 0; i < arrayBLUE.GetLength(0); i++)
        {
            for (int j = 0; j < arrayBLUE.GetLength(1); j++)
            {
                arrayBLUE[i, j] = _arrayB.InstantiateBonesBLUE[i, j];
                if (arrayBLUE[i, j] == 10)
                {
                    arrayBLUE[i, j] = 0;
                }
            }
        }
    }

    public void DeleteBones(int numberToFind, int j, string array)
    {
        string NameBLUEPost;
        string NameREDPost;

        if (array == "RED")
        {
            NameBLUEPost = "B" + (j + 1);

            for (int i = 0; i < arrayBLUE.GetLength(0); i++)
            {
                while (arrayBLUE[i, j] == numberToFind)
                {
                    Destroy(_arrayGameObjectB.gameObjectsInstantiateBLUE[i, j]);
                    _arrayB.InstantiateBonesBLUE[i, j] = 10;
                    _arrayGameObjectB.gameObjectsInstantiateBLUE[i, j] = null;
                    _BonesMoveDown.BonesMoveDelete(NameBLUEPost);
                    Score("CNB" + (j + 1));
                }
            }
        }
        else if (array == "BLUE")
        {
            NameREDPost = "R" + (j + 1);

            for (int i = 0; i < arrayRED.GetLength(0); i++)
            {
                while (arrayRED[i, j] == numberToFind)
                {
                    Debug.Log("arrayRED[" + i + "," + j + "] == numberToFind-" + numberToFind);
                    Destroy(_arrayGameObjectR.gameObjectsInstantiateRED[i, j]);
                    _arrayR.InstantiateBonesRED[i, j] = 10;
                    _arrayGameObjectR.gameObjectsInstantiateRED[i, j] = null;
                    _BonesMoveDown.BonesMoveDelete(NameREDPost);
                    Score("CNR" + (j + 1));
                }
            }
        }
    }

    public void Score(string СolumnName)
    {
        Array();

        switch (СolumnName)
        {
            case "CNR1":

                if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] == arrayRED[2, 0])
                {
                    REDtext1 = (arrayRED[0, 0] + arrayRED[1, 0] + arrayRED[2, 0]) * 3;
                    //все равны
                }
                else if (arrayRED[0, 0] == arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
                {
                    REDtext1 = ((arrayRED[0, 0] + arrayRED[1, 0]) * 2) + arrayRED[2, 0];
                    //("равны 0 и 1
                }
                else if (arrayRED[1, 0] == arrayRED[2, 0] & arrayRED[1, 0] != arrayRED[0, 0])
                {
                    REDtext1 = ((arrayRED[1, 0] + arrayRED[2, 0]) * 2) + arrayRED[0, 0];
                    //равны 1 и 2 
                }
                else if (arrayRED[0, 0] == arrayRED[2, 0] & arrayRED[0, 0] != arrayRED[1, 0])
                {
                    REDtext1 = ((arrayRED[0, 0] + arrayRED[2, 0]) * 2) + arrayRED[1, 0];
                    //равны 0 и 2
                }
                else if (arrayRED[0, 0] != arrayRED[1, 0] & arrayRED[0, 0] != arrayRED[2, 0])
                {
                    REDtext1 = arrayRED[0, 0] + arrayRED[1, 0] + arrayRED[2, 0];
                    //все не равны
                }
                TextScore("R1");
                break;

            case "CNR2":

                if (arrayRED[0, 1] == arrayRED[1, 1] & arrayRED[0, 1] == arrayRED[2, 1])
                {
                    REDtext2 = (arrayRED[0, 1] + arrayRED[1, 1] + arrayRED[2, 1]) * 3;
                    TextScore("R2");
                    //все равны
                }
                else if (arrayRED[0, 1] == arrayRED[1, 1] & arrayRED[0, 1] != arrayRED[2, 1])
                {
                    REDtext2 = ((arrayRED[0, 1] + arrayRED[1, 1]) * 2) + arrayRED[2, 1];
                    TextScore("R2");
                    //равны 0 и 1
                }
                else if (arrayRED[1, 1] == arrayRED[2, 1] & arrayRED[1, 1] != arrayRED[0, 1])
                {
                    REDtext2 = ((arrayRED[1, 1] + arrayRED[2, 1]) * 2) + arrayRED[0, 1];
                    TextScore("R2");
                    //равны 1 и 2
                }
                else if (arrayRED[0, 1] == arrayRED[2, 1] & arrayRED[0, 1] != arrayRED[1, 1])
                {
                    REDtext2 = ((arrayRED[0, 1] + arrayRED[2, 1]) * 2) + arrayRED[1, 1];
                    TextScore("R2");
                    //равны 0 и 2
                }
                else if (arrayRED[0, 1] != arrayRED[1, 1] & arrayRED[0, 1] != arrayRED[2, 1])
                {
                    REDtext2 = arrayRED[0, 1] + arrayRED[1, 1] + arrayRED[2, 1];
                    TextScore("R2");
                    //все не равны
                }
                break;

            case "CNR3":

                if (arrayRED[0, 2] == arrayRED[1, 2] & arrayRED[0, 2] == arrayRED[2, 2])
                {
                    REDtext3 = (arrayRED[0, 2] + arrayRED[1, 2] + arrayRED[2, 2]) * 3;
                    TextScore("R3");
                    //все равны
                }
                else if (arrayRED[0, 2] == arrayRED[1, 2] & arrayRED[0, 2] != arrayRED[2, 2])
                {
                    REDtext3 = ((arrayRED[0, 2] + arrayRED[1, 2]) * 2) + arrayRED[2, 2];
                    TextScore("R3");
                    //равны 0 и 1
                }
                else if (arrayRED[1, 2] == arrayRED[2, 2] & arrayRED[1, 2] != arrayRED[0, 2])
                {
                    REDtext3 = ((arrayRED[1, 2] + arrayRED[2, 2]) * 2) + arrayRED[0, 2];
                    TextScore("R3");
                    //равны 1 и 2
                }
                else if (arrayRED[0, 2] == arrayRED[2, 2] & arrayRED[0, 2] != arrayRED[1, 2])
                {
                    REDtext3 = ((arrayRED[0, 2] + arrayRED[2, 2]) * 2) + arrayRED[1, 2];
                    TextScore("R3");
                    //равны 0 и 2
                }
                else if (arrayRED[0, 2] != arrayRED[1, 2] & arrayRED[0, 2] != arrayRED[2, 2])
                {
                    REDtext3 = arrayRED[0, 2] + arrayRED[1, 2] + arrayRED[2, 2];
                    TextScore("R3");
                    //все не равны
                }
                break;

            case "CNB1":

                if (arrayBLUE[0, 0] == arrayBLUE[1, 0] & arrayBLUE[0, 0] == arrayBLUE[2, 0])
                {
                    BLUEtext1 = (arrayBLUE[0, 0] + arrayBLUE[1, 0] + arrayBLUE[2, 0]) * 3;
                    TextScore("B1");
                    //все равны
                }
                else if (arrayBLUE[0, 0] == arrayBLUE[1, 0] & arrayBLUE[0, 0] != arrayBLUE[2, 0])
                {
                    BLUEtext1 = ((arrayBLUE[0, 0] + arrayBLUE[1, 0]) * 2) + arrayBLUE[2, 0];
                    TextScore("B1");
                    //равны 0 и 1
                }
                else if (arrayBLUE[1, 0] == arrayBLUE[2, 0] & arrayBLUE[1, 0] != arrayBLUE[0, 0])
                {
                    BLUEtext1 = ((arrayBLUE[1, 0] + arrayBLUE[2, 0]) * 2) + arrayBLUE[0, 0];
                    TextScore("B1");
                    //равны 1 и 2
                }
                else if (arrayBLUE[0, 0] == arrayBLUE[2, 0] & arrayBLUE[0, 0] != arrayBLUE[1, 0])
                {
                    BLUEtext1 = ((arrayBLUE[0, 0] + arrayBLUE[2, 0]) * 2) + arrayBLUE[1, 0];
                    TextScore("B1");
                    //равны 0 и 2
                }
                else if (arrayBLUE[0, 0] != arrayBLUE[1, 0] & arrayBLUE[0, 0] != arrayBLUE[2, 0])
                {
                    BLUEtext1 = arrayBLUE[0, 0] + arrayBLUE[1, 0] + arrayBLUE[2, 0];
                    TextScore("B1");
                    //все не все не равны
                }
                break;

            case "CNB2":

                if (arrayBLUE[0, 1] == arrayBLUE[1, 1] & arrayBLUE[0, 1] == arrayBLUE[2, 1])
                {
                    BLUEtext2 = (arrayBLUE[0, 1] + arrayBLUE[1, 1] + arrayBLUE[2, 1]) * 3;
                    TextScore("B2");
                    //все равны
                }
                else if (arrayBLUE[0, 1] == arrayBLUE[1, 1] & arrayBLUE[0, 1] != arrayBLUE[2, 1])
                {
                    BLUEtext2 = ((arrayBLUE[0, 1] + arrayBLUE[1, 1]) * 2) + arrayBLUE[2, 1];
                    TextScore("B2");
                    //равны 0 и 1
                }
                else if (arrayBLUE[1, 1] == arrayBLUE[2, 1] & arrayBLUE[1, 1] != arrayBLUE[0, 1])
                {
                    BLUEtext2 = ((arrayBLUE[1, 1] + arrayBLUE[2, 1]) * 2) + arrayBLUE[0, 1];
                    TextScore("B2");
                    //равны 1 и 2
                }
                else if (arrayBLUE[0, 1] == arrayBLUE[2, 1] & arrayBLUE[0, 1] != arrayBLUE[1, 1])
                {
                    BLUEtext2 = ((arrayBLUE[0, 1] + arrayBLUE[2, 1]) * 2) + arrayBLUE[1, 1];
                    TextScore("B2");
                    //равны 0 и 2
                }
                else if (arrayBLUE[0, 1] != arrayBLUE[1, 1] & arrayBLUE[0, 1] != arrayBLUE[2, 1])
                {
                    BLUEtext2 = arrayBLUE[0, 1] + arrayBLUE[1, 1] + arrayBLUE[2, 1];
                    TextScore("B2");
                    //все не все не равны
                }
                break;

            case "CNB3":

                if (arrayBLUE[0, 2] == arrayBLUE[1, 2] & arrayBLUE[0, 2] == arrayBLUE[2, 2])
                {
                    BLUEtext3 = (arrayBLUE[0, 2] + arrayBLUE[1, 2] + arrayBLUE[2, 2]) * 3;
                    TextScore("B3");
                    //все равны
                }
                else if (arrayBLUE[0, 2] == arrayBLUE[1, 2] & arrayBLUE[0, 2] != arrayBLUE[2, 2])
                {
                    BLUEtext3 = ((arrayBLUE[0, 2] + arrayBLUE[1, 2]) * 2) + arrayBLUE[2, 2];
                    TextScore("B3");
                    //равны 0 и 1
                }
                else if (arrayBLUE[1, 2] == arrayBLUE[2, 2] & arrayBLUE[1, 2] != arrayBLUE[0, 2])
                {
                    BLUEtext3 = ((arrayBLUE[1, 2] + arrayBLUE[2, 2]) * 2) + arrayBLUE[0, 2];
                    TextScore("B3");
                    //равны 1 и 2
                }
                else if (arrayBLUE[0, 2] == arrayBLUE[2, 2] & arrayBLUE[0, 2] != arrayBLUE[1, 2])
                {
                    BLUEtext3 = ((arrayBLUE[0, 2] + arrayBLUE[2, 2]) * 2) + arrayBLUE[1, 2];
                    TextScore("B3");
                    //равны 0 и 2
                }
                else if (arrayBLUE[0, 2] != arrayBLUE[1, 2] & arrayBLUE[0, 2] != arrayBLUE[2, 2])
                {
                    BLUEtext3 = arrayBLUE[0, 2] + arrayBLUE[1, 2] + arrayBLUE[2, 2];
                    TextScore("B3");
                    //все не равны
                }
                break;
        }
    }

    private void TextScore(string textUpdate)
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

    private void TextScoreDelete(string textUpdate, int deletenambr)
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
