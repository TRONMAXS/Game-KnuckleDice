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

    /*public int[,] InstantiateBonesRED = new int[3, 3];
    public int[,] InstantiateBonesBLUE = new int[3, 3];*/

    public int[,] InstantiateBonesRED =  { { 10, 10, 10 },
                                           { 10, 10, 10 },
                                           { 10, 10, 10 } };

    public int[,] InstantiateBonesBLUE = { { 10, 10, 10 },
                                           { 10, 10, 10 },
                                           { 10, 10, 10 } };

    /*public int[,] InstantiateBonesRED =  { { 0, 0, 0 },
                                           { 0, 0, 0 },
                                           { 0, 0, 0 } };

    public int[,] InstantiateBonesBLUE = { { 0, 0, 0 },
                                           { 0, 0, 0 },
                                           { 0, 0, 0 } };*/

    public GameObject[,] gameObjectsInstantiateRED = new GameObject[3, 3];
    public GameObject[,] gameObjectsInstantiateBLUE = new GameObject[3, 3];

    public int MasivRandomBones;
    public static int PanelPlayer;
    public string СolumnName;

    private int BotStartColumnName;
    private string BotStartNameScore;

    public int IFvectorBones;
    public string IFNameScore;
    public int IFColumnName;
    public int IFi;
    public int IFj;

/*    public int SetPositionArrayBotX;
    public int SetPositionArrayBotY;*/

    public static int ResetRandomBones = 0;

    public GameObject ScorePlayer;
    private BOTScorePlayer _actionScore;
    public GameObject ScorePlayer1;
    private BOTScorePlayer _actionDeleteBones;

    public GameObject ScorePlayerWIN;
    private BOTwinPlayer _actionCheckingWinning;

    public GameObject ResetAction;
    private BOTGameBones _actionResetBones;

    public GameObject Bones;
    private BOTGameBones _actionBones;

    public GameObject[] PanelPlayerPlay01;

    private void Start()
    {
        _actionScore = ScorePlayer.GetComponent<BOTScorePlayer>();
        _actionDeleteBones = ScorePlayer1.GetComponent<BOTScorePlayer>();

        _actionCheckingWinning = ScorePlayerWIN.GetComponent<BOTwinPlayer>();

        _actionResetBones = ResetAction.GetComponent<BOTGameBones>();
        _actionBones = Bones.GetComponent<BOTGameBones>();


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
    }

    public void GameLeave()
    {
        ResetBonesStart();
    }

    private void ResetBonesStart()
    {
        _actionResetBones.ResetBones();
    }

    public void CheckArraysInvoke()
    {
        if (BOTGameBones.StartBot == true)
        {
            Invoke("StartBotPlay", 2f);
            return;
        }
        else if(BOTGameBones.StartBot == false)
        {
            Invoke("CheckArraysBotBlue", 2f);
        }
    }

    public void CheckArraysBotBlue()
    {
        if (MasivRandomBones > -1)
        {
            Debug.Log("CheckArraysBotBlue --- MasivRandomBones ---" + MasivRandomBones);
            //все равны
            if (InstantiateBonesBLUE[0, 0] == InstantiateBonesBLUE[1, 0] & InstantiateBonesBLUE[0, 0] == InstantiateBonesBLUE[2, 0])
            {
                if (InstantiateBonesBLUE[0, 0] == MasivRandomBones & InstantiateBonesBLUE[1, 0] == MasivRandomBones & InstantiateBonesBLUE[2, 0] == MasivRandomBones)
                {
                    Debug.Log("все равны1---" + (InstantiateBonesBLUE[0, 0] + InstantiateBonesBLUE[1, 0] + InstantiateBonesBLUE[2, 0]) * 3);
                    //все равны 1 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 1] == InstantiateBonesBLUE[1, 1] & InstantiateBonesBLUE[0, 1] == InstantiateBonesBLUE[2, 1])
            {
                if (InstantiateBonesBLUE[0, 1] == MasivRandomBones & InstantiateBonesBLUE[1, 1] == MasivRandomBones & InstantiateBonesBLUE[2, 1] == MasivRandomBones)
                {
                    Debug.Log("все равны2---" + (InstantiateBonesBLUE[0, 1] + InstantiateBonesBLUE[1, 1] + InstantiateBonesBLUE[2, 1]) * 3);
                    //все равны 2 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 2] == InstantiateBonesBLUE[1, 2] & InstantiateBonesBLUE[0, 2] == InstantiateBonesBLUE[2, 2])
            {
                if (InstantiateBonesBLUE[0, 2] == MasivRandomBones & InstantiateBonesBLUE[1, 2] == MasivRandomBones & InstantiateBonesBLUE[2, 2] == MasivRandomBones)
                {
                    Debug.Log("все равны3---" + (InstantiateBonesBLUE[0, 2] + InstantiateBonesBLUE[1, 2] + InstantiateBonesBLUE[2, 2]) * 3);
                    //все равны 3 столбец
                    return;
                }
            }
            //все равны
            //
            //равны 0 и 1
            if (InstantiateBonesBLUE[0, 0] == InstantiateBonesBLUE[1, 0] & InstantiateBonesBLUE[1, 0] != InstantiateBonesBLUE[2, 0])
            {
                if (InstantiateBonesBLUE[0, 0] == MasivRandomBones & InstantiateBonesBLUE[1, 0] == MasivRandomBones & InstantiateBonesBLUE[2, 0] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 1---" + ((InstantiateBonesBLUE[0, 0] + InstantiateBonesBLUE[1, 0]) * 2) + InstantiateBonesBLUE[2, 0]);
                    //равны 0 и 1  1 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 1] == InstantiateBonesBLUE[1, 1] & InstantiateBonesBLUE[0, 1] != InstantiateBonesBLUE[2, 1])
            {
                if (InstantiateBonesBLUE[0, 1] == MasivRandomBones & InstantiateBonesBLUE[1, 1] == MasivRandomBones & InstantiateBonesBLUE[2, 1] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 1---" + ((InstantiateBonesBLUE[0, 1] + InstantiateBonesBLUE[1, 1]) * 2) + InstantiateBonesBLUE[2, 1]);
                    //равны 0 и 1  2 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 2] == InstantiateBonesBLUE[1, 2] & InstantiateBonesBLUE[0, 2] != InstantiateBonesBLUE[2, 2])
            {
                if (InstantiateBonesBLUE[0, 2] == MasivRandomBones & InstantiateBonesBLUE[1, 2] == MasivRandomBones & InstantiateBonesBLUE[2, 2] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 1---" + ((InstantiateBonesBLUE[0, 2] + InstantiateBonesBLUE[1, 2]) * 2) + InstantiateBonesBLUE[2, 2]);
                    //равны 0 и 1  3 столбец
                    return;
                }
            }
            //равны 0 и 1
            //
            //равны 1 и 2
            if (InstantiateBonesBLUE[1, 0] == InstantiateBonesBLUE[2, 0] & InstantiateBonesBLUE[1, 0] != InstantiateBonesBLUE[0, 0])
            {
                if (InstantiateBonesBLUE[1, 0] == MasivRandomBones & InstantiateBonesBLUE[2, 0] == MasivRandomBones & InstantiateBonesBLUE[0, 0] != MasivRandomBones)
                {
                    Debug.Log("равны 1 и 2---" + ((InstantiateBonesBLUE[1, 0] + InstantiateBonesBLUE[2, 0]) * 2) + InstantiateBonesBLUE[0, 0]);
                    //равны 1 и 2  1 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[1, 1] == InstantiateBonesBLUE[2, 1] & InstantiateBonesBLUE[1, 1] != InstantiateBonesBLUE[0, 1])
            {
                if (InstantiateBonesBLUE[1, 1] == MasivRandomBones & InstantiateBonesBLUE[2, 1] == MasivRandomBones & InstantiateBonesBLUE[0, 1] != MasivRandomBones)
                {
                    Debug.Log("равны 1 и 2---" + ((InstantiateBonesBLUE[1, 1] + InstantiateBonesBLUE[2, 1]) * 2) + InstantiateBonesBLUE[0, 1]);
                    //равны 1 и 2  2 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[1, 2] == InstantiateBonesBLUE[2, 2] & InstantiateBonesBLUE[1, 2] != InstantiateBonesBLUE[0, 2])
            {
                if (InstantiateBonesBLUE[1, 2] == MasivRandomBones & InstantiateBonesBLUE[2, 2] == MasivRandomBones & InstantiateBonesBLUE[0, 2] != MasivRandomBones)
                {
                    Debug.Log("равны 1 и 2---" + ((InstantiateBonesBLUE[1, 2] + InstantiateBonesBLUE[2, 2]) * 2) + InstantiateBonesBLUE[0, 2]);
                    //равны 1 и 2  3 столбец
                    return;
                }
            }
            //равны 1 и 2
            //
            //равны 0 и 2
            if (InstantiateBonesBLUE[0, 0] == InstantiateBonesBLUE[2, 0] & InstantiateBonesBLUE[0, 0] != InstantiateBonesBLUE[1, 0])
            {
                if (InstantiateBonesBLUE[0, 0] == MasivRandomBones & InstantiateBonesBLUE[2, 0] == MasivRandomBones & InstantiateBonesBLUE[1, 0] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 2---" + ((InstantiateBonesBLUE[0, 0] + InstantiateBonesBLUE[2, 0]) * 2) + InstantiateBonesBLUE[1, 0]);
                    //равны 0 и 2  1 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 1] == InstantiateBonesBLUE[2, 1] & InstantiateBonesBLUE[1, 1] != InstantiateBonesBLUE[1, 1])
            {
                if (InstantiateBonesBLUE[0, 1] == MasivRandomBones & InstantiateBonesBLUE[2, 1] == MasivRandomBones & InstantiateBonesBLUE[1, 1] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 2---" + ((InstantiateBonesBLUE[0, 1] + InstantiateBonesBLUE[2, 1]) * 2) + InstantiateBonesBLUE[1, 1]);
                    //равны 0 и 2  2 столбец
                    return;
                }
            }
            if (InstantiateBonesBLUE[0, 2] == InstantiateBonesBLUE[2, 2] & InstantiateBonesBLUE[1, 2] != InstantiateBonesBLUE[1, 2])
            {
                if (InstantiateBonesBLUE[0, 2] == MasivRandomBones & InstantiateBonesBLUE[2, 2] == MasivRandomBones & InstantiateBonesBLUE[1, 2] != MasivRandomBones)
                {
                    Debug.Log("равны 0 и 2---" + ((InstantiateBonesBLUE[0, 2] + InstantiateBonesBLUE[2, 2]) * 2) + InstantiateBonesBLUE[1, 2]);
                    //равны 0 и 2  3 столбец
                    return;
                }
            }
            //равны 0 и 2
            //
            //все не равны
            if (InstantiateBonesBLUE[0, 0] != InstantiateBonesBLUE[1, 0] & InstantiateBonesBLUE[0, 0] != InstantiateBonesBLUE[2, 0] & InstantiateBonesBLUE[1, 0] != InstantiateBonesBLUE[2, 0])
            {
                /*IFi = i;
                IFj = j;
                IFColumnName = j;
                IFNameScore = $"CNR{j + 1}";
                Debug.Log($"if{j} --- CNR{j}");

                BotRed(IFi, IFj, IFNameScore, IFColumnName);
                IFvector();*/
                Debug.Log("все не равны1---" + InstantiateBonesBLUE[0, 0] + InstantiateBonesBLUE[1, 0] + InstantiateBonesBLUE[2, 0]);
                //все не равны  1 столбец
                return;
            }
            if (InstantiateBonesBLUE[0, 1] != InstantiateBonesBLUE[1, 1] & InstantiateBonesBLUE[0, 1] != InstantiateBonesBLUE[2, 1] & InstantiateBonesBLUE[1, 1] != InstantiateBonesBLUE[2, 1])
            {
                Debug.Log("все не равны2---" + InstantiateBonesBLUE[0, 1] + InstantiateBonesBLUE[1, 1] + InstantiateBonesBLUE[2, 1]);
                //все не равны  2 столбец
                return;
            }
            if (InstantiateBonesBLUE[0, 2] != InstantiateBonesBLUE[1, 2] & InstantiateBonesBLUE[0, 2] != InstantiateBonesBLUE[2, 2] & InstantiateBonesBLUE[1, 2] != InstantiateBonesBLUE[2, 2])
            {
                Debug.Log("все не равны3---" + InstantiateBonesBLUE[0, 2] + InstantiateBonesBLUE[1, 2] + InstantiateBonesBLUE[2, 2]);
                //все не равны  3 столбец
                return;
            }
            //все не равны
            else
            {
                Debug.Log("ни чё нету");
                bool found = false;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (InstantiateBonesRED[i, j] == 10)
                        {
                            IFi = i;
                            IFj = j;
                            IFColumnName = j;
                            IFNameScore = $"CNR{j + 1}";
                            Debug.Log($"if{j} --- CNR{j}");
                            found = true;
                            IFvector();
                            Debug.Log("for-for-if CheckArraysBotBlue");
                            //return;
                            break;
                        }
                    }
                    if (found)
                    {
                        Debug.Log("found CheckArraysBotBlue");
                        found = false;
                        break; 
                    }
                }
                Debug.Log("BotRed()-IFvector() CheckArraysBotBlue");
                BotRed(IFi, IFj, IFNameScore, IFColumnName);
                IFvector();
            }
            Debug.Log("конец CheckArraysBotBlue");
        }
    
        else if (MasivRandomBones < 0)
        {
            Debug.Log("MasivRandomBones < 0 --- " + MasivRandomBones);
        }
    } 

    public void StartBotPlay()
    {
        BOTGameBones.StartBot = false;
        Debug.Log("MasivRandomBones - " + MasivRandomBones);
        int RandXPlaceBotPlay = Random.Range(0, 3);
        int RandYPlaceBotPlay = Random.Range(0, 3);
        IFi = RandXPlaceBotPlay;
        IFj = RandYPlaceBotPlay;
        BotStartColumnName = RandYPlaceBotPlay;
        BotStartNameScore = $"CNR{RandYPlaceBotPlay + 1}";

        BotRed(RandXPlaceBotPlay, RandYPlaceBotPlay, BotStartNameScore, BotStartColumnName);
        Debug.Log("StartBotPlay");
    }

    public void IFvector()
    {
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[0, 0] && InstantiateBonesRED[0, 0] == 10)
        if (IFi == 0 & IFj == 0 && InstantiateBonesRED[0, 0] == 10)
        {
            IFvectorBones = 0;
            Debug.Log("IFvector(0);");
            Debug.Log("InstantiateBonesRED[" + IFi + "," + IFj + "]---"+ InstantiateBonesRED[IFi, IFj]);
            //BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[1, 0] & InstantiateBonesRED[1, 0] == 10)
        if(IFi == 1 & IFj == 0 && InstantiateBonesRED[1, 0] == 10)
        {
            IFvectorBones = 1;
            Debug.Log("IFvector(1);");
           //BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[2, 0] & InstantiateBonesRED[2, 0] == 10)
        if (IFi == 2 & IFj == 0 && InstantiateBonesRED[2, 0] == 10)
        {
            IFvectorBones = 2;
            Debug.Log("IFvector(2);");
          //  BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[0, 1] & InstantiateBonesRED[0, 1] == 10)
        if (IFi == 0 & IFj == 1 && InstantiateBonesRED[0, 1] == 10)
        {
            IFvectorBones = 3;
            Debug.Log("IFvector(3);");
           // BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[1, 1] & InstantiateBonesRED[1, 1] == 10)
        if (IFi == 1 & IFj == 1 && InstantiateBonesRED[1, 1] == 10)
        {
            IFvectorBones = 4;
            Debug.Log("IFvector(4);");
            //BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[2, 1] & InstantiateBonesRED[2, 1] == 10)
        if (IFi == 2 & IFj == 1 && InstantiateBonesRED[2, 1] == 10)
        {
            IFvectorBones = 5;
            Debug.Log("IFvector(5);");
          //  BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[0, 2] & InstantiateBonesRED[0, 2] == 10)
        if (IFi == 0 & IFj == 2 && InstantiateBonesRED[0, 2] == 10)
        {
            IFvectorBones = 6;
            Debug.Log("IFvector(6);");
           // BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[1, 2] & InstantiateBonesRED[1, 2] == 10)
        if (IFi == 1 & IFj == 2 && InstantiateBonesRED[1, 2] == 10)
        {
            IFvectorBones = 7;
            Debug.Log("IFvector(7);");
            //BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
        //if (InstantiateBonesRED[IFi, IFj] == InstantiateBonesRED[2, 2] & InstantiateBonesRED[2, 2] == 10)
        if (IFi == 2 & IFj == 2 && InstantiateBonesRED[2, 2] == 10)
        {
            IFvectorBones = 8;
            Debug.Log("IFvector(8);");
           // BotRed(IFi, IFj, IFNameScore, IFColumnName);
            return;
        }
    }

    public void BotRed(int SetPositionArrayBotX, int SetPositionArrayBotY, string NameScore, int ColumnName)
    {
        IFvector();
        if (PanelPlayer == 0 & MasivRandomBones >= 0 /*& InstantiateBonesRED[SetPositionArrayBotX, SetPositionArrayBotY] <= 0*/)
        {
            Debug.Log("IFvectorBones-"+ IFvectorBones+ "  MasivRandomBones-"+ MasivRandomBones);
            PanelPlayer = 1;
            InstantiateBonesRED[SetPositionArrayBotX, SetPositionArrayBotY] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[IFvectorBones], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + (MasivRandomBones + 1) + ColumnName;
            gameObjectsInstantiateRED[SetPositionArrayBotX, SetPositionArrayBotY] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[SetPositionArrayBotX, SetPositionArrayBotY], ColumnName, "RED");
            _actionScore.Score(NameScore);
            _actionCheckingWinning.CheckingWinning();
            Debug.Log(SetPositionArrayBotX+"---"+SetPositionArrayBotY +"---InstantiateBonesRED[SetPositionArrayBotX, SetPositionArrayBotY]---"+InstantiateBonesRED[SetPositionArrayBotX, SetPositionArrayBotY]);
            Debug.Log(InstantiateBonesRED[2, 0] + " " + InstantiateBonesRED[2, 1] + " " + InstantiateBonesRED[2, 2]);
            Debug.Log(InstantiateBonesRED[1, 0] + " " + InstantiateBonesRED[1, 1] + " " + InstantiateBonesRED[1, 2]);
            Debug.Log(InstantiateBonesRED[0, 0] + " " + InstantiateBonesRED[0, 1] + " " + InstantiateBonesRED[0, 2]);
        }
    }

    /// Red
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// Blue

    private void OnButtonBlue0Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 0] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue1Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 0] == 10)
        {
            PanelPlayer = 0;
            InstantiateBonesBLUE[1, 0] = MasivRandomBones + 1;
            ResetBonesStart();
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[1], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[1, 0] + "0";
            gameObjectsInstantiateBLUE[1, 0] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[1, 0], 0, "BLUE");
            _actionScore.Score("CNB1");
            _actionCheckingWinning.CheckingWinning();
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue2Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 0] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue3Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 1] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue4Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 1] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue5Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 1] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue6Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, 2] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue7Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[1, 2] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }

    private void OnButtonBlue8Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[2, 2] == 10)
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
            _actionBones.RandomButtonBones(0, false);
        }
    }
}