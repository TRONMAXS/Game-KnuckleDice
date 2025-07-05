using UnityEngine;
using UnityEngine.UI;

public class BOTGamePanelButtonRed : MonoBehaviour
{

    public Button ButtonBlue1;
    public Button ButtonBlue2;
    public Button ButtonBlue3;
    public Button ButtonBlue4;
    public Button ButtonBlue5;
    public Button ButtonBlue6;
    public Button ButtonBlue7;
    public Button ButtonBlue8;
    public Button ButtonBlue9;

    public GameObject BonesRed;
    public GameObject BonesBlue;

    private Quaternion[] quaternionBones = new Quaternion[6];

    private Vector2[] vector2BonesRed;
    private Vector2[] vector2BonesBlue;

    public int[,] InstantiateBonesRED = new int[3, 3];
    public int[,] InstantiateBonesBLUE = new int[3, 3];

    public GameObject[,] gameObjectsInstantiateRED = new GameObject[3, 3];
    public GameObject[,] gameObjectsInstantiateBLUE = new GameObject[3, 3];

    public int MasivRandomBones;
    public int PanelPlayer;

    public static int ResetRandomBones = 0;

    public GameObject ScorePlayer;
    private ScorePlayer _actionScore;
    public GameObject ScorePlayer1;
    private ScorePlayer _actionDeleteBones;

    public GameObject ScorePlayerWIN;
    private winPlayer _actionCheckingWinning;

    public GameObject Resetaction;
    private BOTGameBones _actionResetBones;

    public GameObject[] PanelPlayerPlay01;

    private void Start()
    {
        _actionScore = ScorePlayer.GetComponent<ScorePlayer>();
        _actionDeleteBones = ScorePlayer1.GetComponent<ScorePlayer>();

        _actionCheckingWinning = ScorePlayerWIN.GetComponent<winPlayer>();

        _actionResetBones = Resetaction.GetComponent<BOTGameBones>();

        ButtonBlue1.onClick.AddListener(OnButtonBlue0Clicked);
        ButtonBlue2.onClick.AddListener(OnButtonBlue1Clicked);
        ButtonBlue3.onClick.AddListener(OnButtonBlue2Clicked);
        ButtonBlue4.onClick.AddListener(OnButtonBlue3Clicked);
        ButtonBlue5.onClick.AddListener(OnButtonBlue4Clicked);
        ButtonBlue6.onClick.AddListener(OnButtonBlue5Clicked);
        ButtonBlue7.onClick.AddListener(OnButtonBlue6Clicked);
        ButtonBlue8.onClick.AddListener(OnButtonBlue7Clicked);
        ButtonBlue9.onClick.AddListener(OnButtonBlue8Clicked);

        quaternionBones[0] = Quaternion.Euler(-180f, 0f, 0f);
        quaternionBones[1] = Quaternion.Euler(-90f, 0f, 0f);
        quaternionBones[2] = Quaternion.Euler(0f, -90f, 0f);
        quaternionBones[3] = Quaternion.Euler(0f, 90f, 0f);
        quaternionBones[4] = Quaternion.Euler(90f, 0f, 0f);
        quaternionBones[5] = Quaternion.Euler(0f, 0f, 0f);

        vector2BonesRed = new Vector2[9];

        vector2BonesRed[0] = new Vector2(-179, 830);
        vector2BonesRed[1] = new Vector2(-179, 982);
        vector2BonesRed[2] = new Vector2(-179, 1137);
        vector2BonesRed[3] = new Vector2(0, 830);
        vector2BonesRed[4] = new Vector2(0, 982);
        vector2BonesRed[5] = new Vector2(0, 1137);
        vector2BonesRed[6] = new Vector2(179, 830);
        vector2BonesRed[7] = new Vector2(179, 982);
        vector2BonesRed[8] = new Vector2(179, 1137);

        vector2BonesBlue = new Vector2[9];

        vector2BonesBlue[0] = new Vector2(-179, 160);
        vector2BonesBlue[1] = new Vector2(-179, 314);
        vector2BonesBlue[2] = new Vector2(-179, 468);
        vector2BonesBlue[3] = new Vector2(0, 160);
        vector2BonesBlue[4] = new Vector2(0, 314);
        vector2BonesBlue[5] = new Vector2(0, 468);
        vector2BonesBlue[6] = new Vector2(179, 160);
        vector2BonesBlue[7] = new Vector2(179, 314);
        vector2BonesBlue[8] = new Vector2(179, 468);

        PanelPlayer = BOTGameBones.PanelStartRandom;
    }

    private void Update()
    {
        MasivRandomBones = BOTGameBones.MasivRandomBonesPlayer;
        BotRed0();
    }

    private void ResetBonesStart()
    {
        _actionResetBones.ResetBones();
    }

    private void BotRed0()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[0, 0] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[0, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[0], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + (MasivRandomBones + 1) + "0";
            gameObjectsInstantiateRED[0, 0] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[0, 0], 0, "RED");
            _actionScore.Score("CNR1");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    /*private void OnButtonRed0Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[0, 0] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[0, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[0], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + (MasivRandomBones + 1) + "0";
            gameObjectsInstantiateRED[0, 0] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[0, 0], 0, "RED");
            _actionScore.Score("CNR1");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed1Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[1, 0] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[1, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[1], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[1, 0] + "0";
            gameObjectsInstantiateRED[1, 0] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[1, 0], 0, "RED");
            _actionScore.Score("CNR1");
            _actionCheckingWinning.CheckingWinning();
        }

    }

    private void OnButtonRed2Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[2, 0] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[2, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[2], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[2, 0] + "0";
            gameObjectsInstantiateRED[2, 0] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[2, 0], 0, "RED");
            _actionScore.Score("CNR1");
            _actionCheckingWinning.CheckingWinning();
        }

    }

    private void OnButtonRed3Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[0, 1] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[0, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[3], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[0, 1] + "1";
            gameObjectsInstantiateRED[0, 1] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[0, 1], 1, "RED");
            _actionScore.Score("CNR2");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed4Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[1, 1] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[1, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[4], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[1, 1] + "1";
            gameObjectsInstantiateRED[1, 1] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[1, 1], 1, "RED");
            _actionScore.Score("CNR2");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed5Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[2, 1] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[2, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[5], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[2, 1] + "1";
            gameObjectsInstantiateRED[2, 1] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[2, 1], 1, "RED");
            _actionScore.Score("CNR2");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed6Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[0, 2] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[0, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[6], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[0, 2] + "2";
            gameObjectsInstantiateRED[0, 2] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[0, 2], 2, "RED");
            _actionScore.Score("CNR3");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed7Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[1, 2] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[1, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[7], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[1, 2] + "2";
            gameObjectsInstantiateRED[1, 2] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[1, 2], 2, "RED");
            _actionScore.Score("CNR3");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonRed8Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[2, 2] <= 0)
        {
            PanelPlayer = 1;
            InstantiateBonesRED[2, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[8], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[2, 2] + "2";
            gameObjectsInstantiateRED[2, 2] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[2, 2], 2, "RED");
            _actionScore.Score("CNR3");
            _actionCheckingWinning.CheckingWinning();
        }
    }*/
    /// Red
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// Blue

    private void OnButtonBlue0Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 0] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[0, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[0], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[0, 0] + "0";
            gameObjectsInstantiateBLUE[0, 0] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[0, 0], 0, "BLUE");
            _actionScore.Score("CNB1");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue1Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 0] <= 0)
        {
            PanelPlayer = 0;
            ResetBonesStart();
            InstantiateBonesBLUE[1, 0] = MasivRandomBones + 1;
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[1], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[1, 0] + "0";
            gameObjectsInstantiateBLUE[1, 0] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[1, 0], 0, "BLUE");
            _actionScore.Score("CNB1");
            _actionCheckingWinning.CheckingWinning();
        }
    }
    private void OnButtonBlue2Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 0] <= 0)
        {
            PanelPlayer = 0;
            ResetBonesStart();
            InstantiateBonesBLUE[2, 0] = MasivRandomBones + 1;
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[2], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[2, 0] + "0";
            gameObjectsInstantiateBLUE[2, 0] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[2, 0], 0, "BLUE");
            _actionScore.Score("CNB1");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue3Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 1] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[0, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[3], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[0, 1] + "1";
            gameObjectsInstantiateBLUE[0, 1] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[0, 1], 1, "BLUE");
            _actionScore.Score("CNB2");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue4Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 1] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[1, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[4], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[1, 1] + "1";
            gameObjectsInstantiateBLUE[1, 1] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[1, 1], 1, "BLUE");
            _actionScore.Score("CNB2");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue5Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 1] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[2, 1] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[5], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[2, 1] + "1";
            gameObjectsInstantiateBLUE[2, 1] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[2, 1], 1, "BLUE");
            _actionScore.Score("CNB2");
            _actionCheckingWinning.CheckingWinning();


        }
    }

    private void OnButtonBlue6Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 2] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[0, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[6], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[0, 2] + "2";
            gameObjectsInstantiateBLUE[0, 2] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[0, 2], 2, "BLUE");
            _actionScore.Score("CNB3");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue7Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 2] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[1, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[7], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[1, 2] + "2";
            gameObjectsInstantiateBLUE[1, 2] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[1, 2], 2, "BLUE");
            _actionScore.Score("CNB3");
            _actionCheckingWinning.CheckingWinning();
        }
    }

    private void OnButtonBlue8Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 2] <= 0)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[2, 2] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[8], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + (MasivRandomBones + 1) + "2";
            gameObjectsInstantiateBLUE[2, 2] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[2, 2], 2, "BLUE");
            _actionScore.Score("CNB3");
            _actionCheckingWinning.CheckingWinning();
        }
    }
}
