using UnityEngine;
using UnityEngine.UI;

public class GamePanelButtonRed : MonoBehaviour
{
    public GameObject BonesRed;
    public GameObject BonesBlue;

    private Quaternion[] quaternionBones = new Quaternion[6];

    private Vector2[] vector2BonesRed;
    private Vector2[] vector2BonesBlue;

    public int[,] InstantiateBonesRED =  { { 10, 10, 10 },
                                           { 10, 10, 10 },
                                           { 10, 10, 10 } };

    public int[,] InstantiateBonesBLUE = { { 10, 10, 10 },
                                           { 10, 10, 10 },
                                           { 10, 10, 10 } };

    public GameObject[,] gameObjectsInstantiateRED = new GameObject[3, 3];
    public GameObject[,] gameObjectsInstantiateBLUE = new GameObject[3, 3];

    public int MasivRandomBones;
    public int PanelPlayer;

    public int MoveXBlue;
    public int MoveYBlue;
    public int MoveXRed;
    public int MoveYRed;
    public int MoveVector2Red;
    public int MoveVector2Blue;

    public static int ResetRandomBones = 0;

    public GameObject ScorePlayer;
    private ScorePlayer _actionScore;
    public GameObject ScorePlayer1;
    private ScorePlayer _actionDeleteBones;

    public GameObject ScorePlayerWIN;
    private WinPlayer _actionCheckingWinning;

    public GameObject Resetaction;
    private GameBones _actionResetBones;

    public GameObject[] PanelPlayerPlay01;

    private void Start()
    {
        _actionScore = ScorePlayer.GetComponent<ScorePlayer>();
        _actionDeleteBones = ScorePlayer1.GetComponent<ScorePlayer>();

        _actionCheckingWinning  = ScorePlayerWIN.GetComponent<WinPlayer>();

        _actionResetBones = Resetaction.GetComponent<GameBones>();

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

        PanelPlayer = GameBones.PanelStartRandom;
    }

    private void Update()
    {
        MasivRandomBones = GameBones.MasivRandomBonesPlayer;
    }

    public void BonesMoveDelete(string Post)
    {
        int NoFull = 0;
        int IndexX = 0;
        int IndexQuaternion = 0;
        switch (Post)
        {
            case "B1":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesBLUE[a, 0] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }

                for (int b = 2; b >= 0; b--)
                {
                    if (InstantiateBonesBLUE[b, 0] == 10)
                    {
                        if (b > 0)
                        {
                            InstantiateBonesBLUE[b, 0] = InstantiateBonesBLUE[b - 1, 0];
                            gameObjectsInstantiateBLUE[b, 0] = gameObjectsInstantiateBLUE[b - 1, 0];
                            if (gameObjectsInstantiateBLUE[b, 0] != null)
                            {
                                if (InstantiateBonesBLUE[b - 1, 0] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[b - 1, 0];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[b - 1, 0] - 1;
                                }
                                gameObjectsInstantiateBLUE[b, 0].GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesBLUE[b - 1, 0] = 10;
                            gameObjectsInstantiateBLUE[b - 1, 0] = null;
                        }
                    }
                }
                break;
            case "B2":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesBLUE[a, 1] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }

                for (int b = 5; b >= 3; b--)
                {
                    if (b == 5)
                    {
                        IndexX = 2;
                    }
                    else if (b == 4)
                    {
                        IndexX = 1;
                    }
                    else if (b == 3)
                    {
                        IndexX = 0;
                    }

                    if (InstantiateBonesBLUE[IndexX, 1] == 10)
                    {
                        if (IndexX > 0)
                        {
                            InstantiateBonesBLUE[IndexX, 1] = InstantiateBonesBLUE[IndexX - 1, 1];
                            gameObjectsInstantiateBLUE[IndexX, 1] = gameObjectsInstantiateBLUE[IndexX - 1, 1];
                            if (gameObjectsInstantiateBLUE[IndexX, 1] != null)
                            {
                                if (InstantiateBonesBLUE[IndexX - 1, 1] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[IndexX - 1, 1];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[IndexX - 1, 1] - 1;
                                }
                                gameObjectsInstantiateBLUE[IndexX, 1].GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesBLUE[IndexX - 1, 1] = 10;
                            gameObjectsInstantiateBLUE[IndexX - 1, 1] = null;
                        }
                    }
                }
                break;
            case "B3":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesBLUE[a, 2] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }
                for (int b = 8; b >= 6; b--)
                {
                    if (b == 8)
                    {
                        IndexX = 2;
                    }
                    else if (b == 7)
                    {
                        IndexX = 1;
                    }
                    else if (b == 6)
                    {
                        IndexX = 0;
                    }

                    if (InstantiateBonesBLUE[IndexX, 2] == 10)
                    {
                        if (IndexX > 0)
                        {
                            InstantiateBonesBLUE[IndexX, 2] = InstantiateBonesBLUE[IndexX - 1, 2];
                            gameObjectsInstantiateBLUE[IndexX, 2] = gameObjectsInstantiateBLUE[IndexX - 1, 2];
                            if (gameObjectsInstantiateBLUE[IndexX, 2] != null)
                            {
                                if (InstantiateBonesBLUE[IndexX - 1, 2] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[IndexX - 1, 2];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesBLUE[IndexX - 1, 2] - 1;
                                }
                                gameObjectsInstantiateBLUE[IndexX, 2].GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesBLUE[IndexX - 1, 2] = 10;
                            gameObjectsInstantiateBLUE[IndexX - 1, 2] = null;
                        }
                    }
                }
                break;

            case "R1":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesRED[a, 0] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }

                for (int b = 0; b < 3; b++)
                {
                    if (InstantiateBonesRED[b, 0] == 10)
                    {
                        if (b < 2)
                        {
                            InstantiateBonesRED[b, 0] = InstantiateBonesRED[b + 1, 0];
                            gameObjectsInstantiateRED[b, 0] = gameObjectsInstantiateRED[b + 1, 0];
                            if (gameObjectsInstantiateRED[b, 0] != null)
                            {
                                if (InstantiateBonesRED[b + 1, 0] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesRED[b + 1, 0];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesRED[b + 1, 0] - 1;
                                }
                                gameObjectsInstantiateRED[b, 0].GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesRED[b + 1, 0] = 10;
                            gameObjectsInstantiateRED[b + 1, 0] = null;
                        }
                    }
                }
                break;
            case "R2":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesRED[a, 1] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }
                for (int b = 3; b <= 5; b++)
                {
                    if (b == 3)
                    {
                        IndexX = 0;
                    }
                    else if (b == 4)
                    {
                        IndexX = 1;
                    }
                    else if (b == 5)
                    {
                        IndexX = 2;
                    }

                    if (InstantiateBonesRED[IndexX, 1] == 10)
                    {
                        if (IndexX < 2)
                        {
                            InstantiateBonesRED[IndexX, 1] = InstantiateBonesRED[IndexX + 1, 1];
                            gameObjectsInstantiateRED[IndexX, 1] = gameObjectsInstantiateRED[IndexX + 1, 1];
                            if (gameObjectsInstantiateRED[IndexX, 1] != null)
                            {
                                if (InstantiateBonesRED[IndexX + 1, 1] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesRED[IndexX + 1, 1];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesRED[IndexX + 1, 1] - 1;
                                }
                                gameObjectsInstantiateRED[IndexX, 1].GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesRED[IndexX + 1, 1] = 10;
                            gameObjectsInstantiateRED[IndexX + 1, 1] = null;
                        }
                    }
                }
                break;
            case "R3":
                for (int a = 0; a < 3; a++)
                {
                    if (InstantiateBonesRED[a, 2] == 10)
                    {
                        NoFull++;
                    }
                }
                if (NoFull == 3)
                {
                    return;
                }
                for (int b = 6; b <= 8; b++)
                {
                    if (b == 6)
                    {
                        IndexX = 0;
                    }
                    else if (b == 7)
                    {
                        IndexX = 1;
                    }
                    else if (b == 8)
                    {
                        IndexX = 2;
                    }

                    if (InstantiateBonesRED[IndexX, 2] == 10)
                    {
                        if (IndexX < 2)
                        {
                            InstantiateBonesRED[IndexX, 2] = InstantiateBonesRED[IndexX + 1, 2];
                            gameObjectsInstantiateRED[IndexX, 2] = gameObjectsInstantiateRED[IndexX + 1, 2];
                            if (gameObjectsInstantiateRED[IndexX, 2] != null)
                            {
                                if (InstantiateBonesRED[IndexX + 1, 2] == 0)
                                {
                                    IndexQuaternion = InstantiateBonesRED[IndexX + 1, 2];
                                }
                                else
                                {
                                    IndexQuaternion = InstantiateBonesRED[IndexX + 1, 2] - 1;
                                }
                                gameObjectsInstantiateRED[IndexX, 2].GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[b], quaternionBones[IndexQuaternion]);
                            }
                            InstantiateBonesRED[IndexX + 1, 2] = 10;
                            gameObjectsInstantiateRED[IndexX + 1, 2] = null;
                        }
                    }
                }
                break;
        }

    }

    public void BonesMoveDown(string Post, int place)
    {
        switch (Post)
        {
            case "B1":
                if (place == 0)
                {
                    if (InstantiateBonesBLUE[1, 0] == 10)
                    {
                        InstantiateBonesBLUE[1, 0] = InstantiateBonesBLUE[0, 0];
                        InstantiateBonesBLUE[0, 0] = 10;
                        MoveXBlue = 1;
                        MoveYBlue = 0;
                        MoveVector2Blue = 1;
                        if (InstantiateBonesBLUE[2, 0] == 10)
                        {
                            InstantiateBonesBLUE[2, 0] = InstantiateBonesBLUE[1, 0];
                            InstantiateBonesBLUE[1, 0] = 10;
                            MoveXBlue = 2;
                            MoveYBlue = 0;
                            MoveVector2Blue = 2;
                        }
                    }
                    else
                    {
                        MoveXBlue = 0;
                        MoveYBlue = 0;
                        MoveVector2Blue = 0;
                    }
                }
                if (place == 1)
                {
                    if (InstantiateBonesBLUE[2, 0] == 10)
                    {
                        InstantiateBonesBLUE[2, 0] = InstantiateBonesBLUE[1, 0];
                        InstantiateBonesBLUE[1, 0] = 10;
                        MoveXBlue = 2;
                        MoveYBlue = 0;
                        MoveVector2Blue = 2;
                    }
                    else
                    {
                        MoveXBlue = 1;
                        MoveYBlue = 0;
                        MoveVector2Blue = 1;
                    }
                }
                if (place == 2)
                {
                    MoveXBlue = 2;
                    MoveYBlue = 0;
                    MoveVector2Blue = 2;
                }

                break;
            case "B2":
                if (place == 2)
                {
                    MoveXBlue = 2;
                    MoveYBlue = 1;
                    MoveVector2Blue = 5;
                }
                if (place == 1)
                {
                    if (InstantiateBonesBLUE[2, 1] == 10)
                    {
                        InstantiateBonesBLUE[2, 1] = InstantiateBonesBLUE[1, 1];
                        InstantiateBonesBLUE[1, 1] = 10;
                        MoveXBlue = 2;
                        MoveYBlue = 1;
                        MoveVector2Blue = 5;
                    }
                    else
                    {
                        MoveXBlue = 1;
                        MoveYBlue = 1;
                        MoveVector2Blue = 4;
                    }
                }
                if (place == 0)
                {
                    if (InstantiateBonesBLUE[1, 1] == 10)
                    {
                        InstantiateBonesBLUE[1, 1] = InstantiateBonesBLUE[0, 1];
                        InstantiateBonesBLUE[0, 1] = 10;
                        MoveXBlue = 1;
                        MoveYBlue = 1;
                        MoveVector2Blue = 4;
                        if (InstantiateBonesBLUE[2, 1] == 10)
                        {
                            InstantiateBonesBLUE[2, 1] = InstantiateBonesBLUE[1, 1];
                            InstantiateBonesBLUE[1, 1] = 10;
                            MoveXBlue = 2;
                            MoveYBlue = 1;
                            MoveVector2Blue = 5;
                        }
                    }
                    else
                    {
                        MoveXBlue = 0;
                        MoveYBlue = 1;
                        MoveVector2Blue = 3;
                    }
                }
                break;
            case "B3":
                if (place == 2)
                {
                    MoveXBlue = 2;
                    MoveYBlue = 2;
                    MoveVector2Blue = 8;
                }
                if (place == 1)
                {
                    if (InstantiateBonesBLUE[2, 2] == 10)
                    {
                        InstantiateBonesBLUE[2, 2] = InstantiateBonesBLUE[1, 2];
                        InstantiateBonesBLUE[1, 2] = 10;
                        MoveXBlue = 2;
                        MoveYBlue = 2;
                        MoveVector2Blue = 8;
                    }
                    else
                    {
                        MoveXBlue = 1;
                        MoveYBlue = 2;
                        MoveVector2Blue = 7;
                    }
                }
                if (place == 0)
                {
                    if (InstantiateBonesBLUE[1, 2] == 10)
                    {
                        InstantiateBonesBLUE[1, 2] = InstantiateBonesBLUE[0, 2];
                        InstantiateBonesBLUE[0, 2] = 10;
                        MoveXBlue = 1;
                        MoveYBlue = 2;
                        MoveVector2Blue = 7;
                        if (InstantiateBonesBLUE[2, 2] == 10)
                        {
                            InstantiateBonesBLUE[2, 2] = InstantiateBonesBLUE[1, 2];
                            InstantiateBonesBLUE[1, 2] = 10;
                            MoveXBlue = 2;
                            MoveYBlue = 2;
                            MoveVector2Blue = 8;
                        }
                    }
                    else
                    {
                        MoveXBlue = 0;
                        MoveYBlue = 2;
                        MoveVector2Blue = 6;
                    }
                }
                break;

            case "R1":
                if (place == 0)
                {
                    MoveXRed = 0;
                    MoveYRed = 0;
                    MoveVector2Red = 0;
                }
                if (place == 1)
                {
                    if (InstantiateBonesRED[0, 0] == 10)
                    {
                        InstantiateBonesRED[0, 0] = InstantiateBonesRED[1, 0];
                        InstantiateBonesRED[1, 0] = 10;
                        MoveXRed = 0;
                        MoveYRed = 0;
                        MoveVector2Red = 0;
                    }
                    else
                    {
                        MoveXRed = 1;
                        MoveYRed = 0;
                        MoveVector2Red = 1;
                    }
                }
                if (place == 2)
                {
                    if (InstantiateBonesRED[1, 0] == 10)
                    {
                        InstantiateBonesRED[1, 0] = InstantiateBonesRED[2, 0];
                        InstantiateBonesRED[2, 0] = 10;
                        MoveXRed = 1;
                        MoveYRed = 0;
                        MoveVector2Red = 1;
                        if (InstantiateBonesRED[0, 0] == 10)
                        {
                            InstantiateBonesRED[2, 0] = InstantiateBonesRED[1, 0];
                            InstantiateBonesRED[1, 0] = 10;
                            MoveXRed = 0;
                            MoveYRed = 0;
                            MoveVector2Red = 0;
                        }
                    }
                    else
                    {
                        MoveXRed = 2;
                        MoveYRed = 0;
                        MoveVector2Red = 2;
                    }
                }
                break;
            case "R2":
                if (place == 0)
                {
                    MoveXRed = 0;
                    MoveYRed = 1;
                    MoveVector2Red = 3;
                }
                if (place == 1)
                {
                    if (InstantiateBonesRED[0, 1] == 10)
                    {
                        InstantiateBonesRED[0, 1] = InstantiateBonesRED[1, 1];
                        InstantiateBonesRED[1, 1] = 10;
                        MoveXRed = 0;
                        MoveYRed = 1;
                        MoveVector2Red = 3;
                    }
                    else
                    {
                        MoveXRed = 1;
                        MoveYRed = 1;
                        MoveVector2Red = 4;
                    }
                }
                if (place == 2)
                {
                    if (InstantiateBonesRED[1, 1] == 10)
                    {
                        InstantiateBonesRED[1, 1] = InstantiateBonesRED[2, 1];
                        InstantiateBonesRED[2, 1] = 10;
                        MoveXRed = 1;
                        MoveYRed = 1;
                        MoveVector2Red = 4;
                        if (InstantiateBonesRED[0, 1] == 10)
                        {
                            InstantiateBonesRED[2, 1] = InstantiateBonesRED[1, 1];
                            InstantiateBonesRED[1, 1] = 10;
                            MoveXRed = 0;
                            MoveYRed = 1;
                            MoveVector2Red = 3;
                        }
                    }
                    else
                    {
                        MoveXRed = 2;
                        MoveYRed = 1;
                        MoveVector2Red = 5;
                    }
                }
                break;
            case "R3":
                if (place == 0)
                {
                    MoveXRed = 0;
                    MoveYRed = 2;
                    MoveVector2Red = 6;
                }
                if (place == 1)
                {
                    if (InstantiateBonesRED[0, 2] == 10)
                    {
                        InstantiateBonesRED[0, 2] = InstantiateBonesRED[1, 2];
                        InstantiateBonesRED[1, 2] = 10;
                        MoveXRed = 0;
                        MoveYRed = 2;
                        MoveVector2Red = 6;
                    }
                    else
                    {
                        MoveXRed = 1;
                        MoveYRed = 2;
                        MoveVector2Red = 7;
                    }
                }
                if (place == 2)
                {
                    if (InstantiateBonesRED[1, 2] == 10)
                    {
                        InstantiateBonesRED[1, 2] = InstantiateBonesRED[2, 2];
                        InstantiateBonesRED[2, 2] = 10;
                        MoveXRed = 1;
                        MoveYRed = 2;
                        MoveVector2Red = 7;
                        if (InstantiateBonesRED[0, 2] == 10)
                        {
                            InstantiateBonesRED[2, 2] = InstantiateBonesRED[1, 2];
                            InstantiateBonesRED[1, 2] = 10;
                            MoveXRed = 0;
                            MoveYRed = 2;
                            MoveVector2Red = 6;
                        }
                    }
                    else
                    {
                        MoveXRed = 2;
                        MoveYRed = 2;
                        MoveVector2Red = 8;
                    }
                }
                break;
        }
    }

    private void ResetBonesStart()
    {
        _actionResetBones.ResetBones();
    }


    public void ButtonRedClicked(int Index—olumn)
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0 & InstantiateBonesRED[2, Index—olumn] == 10)
        {
            PanelPlayer = 1;
            ResetBonesStart();
            BonesMoveDown("R" + (Index—olumn + 1), 2);
            InstantiateBonesRED[MoveXRed, MoveYRed] = MasivRandomBones + 1;
            GameObject bonesRed = Instantiate(BonesRed) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[MoveVector2Red], quaternionBones[MasivRandomBones]);
            bonesRed.name = "R-" + InstantiateBonesRED[MoveXRed, MoveYRed] + "0";
            gameObjectsInstantiateRED[MoveXRed, MoveYRed] = bonesRed;
            _actionDeleteBones.DeleteBones(InstantiateBonesRED[MoveXRed, MoveYRed], Index—olumn, "RED");
            _actionScore.Score("CNR" + (Index—olumn + 1));
            _actionCheckingWinning.CheckingWinning();
        }
    }

    public void ButtonBlueClicked(int Index—olumn)
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0 & InstantiateBonesBLUE[0, Index—olumn] == 10)
        {
            PanelPlayer = 0;
            ResetBonesStart();
            BonesMoveDown("B" + (Index—olumn + 1), 0);
            InstantiateBonesBLUE[MoveXBlue, MoveYBlue] = MasivRandomBones + 1;
            GameObject bonesBlue = Instantiate(BonesBlue) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[MoveVector2Blue], quaternionBones[MasivRandomBones]);
            bonesBlue.name = "B-" + InstantiateBonesBLUE[MoveXBlue, MoveYBlue] + "0";
            gameObjectsInstantiateBLUE[MoveXBlue, MoveYBlue] = bonesBlue;
            _actionDeleteBones.DeleteBones(InstantiateBonesBLUE[MoveXBlue, MoveYBlue], Index—olumn, "BLUE");
            _actionScore.Score("CNB" + (Index—olumn + 1));
            _actionCheckingWinning.CheckingWinning();
        }
    }
}