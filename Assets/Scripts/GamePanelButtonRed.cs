using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamePanelButtonRed : MonoBehaviour
{
    public Button ButtonRed1;
    public Button ButtonRed2;
    public Button ButtonRed3;
    public Button ButtonRed4;
    public Button ButtonRed5;
    public Button ButtonRed6;
    public Button ButtonRed7;
    public Button ButtonRed8;
    public Button ButtonRed9;

    public Button ButtonBlue1;
    public Button ButtonBlue2;
    public Button ButtonBlue3;
    public Button ButtonBlue4;
    public Button ButtonBlue5;
    public Button ButtonBlue6;
    public Button ButtonBlue7;
    public Button ButtonBlue8;
    public Button ButtonBlue9;

    public GameObject[] BonesRed;
    public GameObject[] BonesBlue;

    public GameObject[,] InstantiateBonesRED;
    public GameObject[,] InstantiateBonesBLUE;

    public float[,] positionBonesRed = { { -179, 838, 0 }, { 3, 4, 5 }, { 3, 4, 5 },
                                         { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                         { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 }};

    public int[,] positionBonesBlue = { { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                        { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                        { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 }};

    Vector2 vector1RY = new Vector2(-179, 830);
    Vector3 vector2RY = new Vector3();

    public int MasivRandomBones;
    public int PanelPlayer;

    public static int ResetRandomBones = 0;

    private void Start()
    {
        ButtonRed1.onClick.AddListener(OnButtonRed1Clicked);
        ButtonRed2.onClick.AddListener(OnButtonRed2Clicked);
        ButtonRed3.onClick.AddListener(OnButtonRed3Clicked);
        ButtonRed4.onClick.AddListener(OnButtonRed4Clicked);
        ButtonRed5.onClick.AddListener(OnButtonRed5Clicked);
        ButtonRed6.onClick.AddListener(OnButtonRed6Clicked);
        ButtonRed7.onClick.AddListener(OnButtonRed7Clicked);
        ButtonRed8.onClick.AddListener(OnButtonRed8Clicked);
        ButtonRed9.onClick.AddListener(OnButtonRed9Clicked);

        ButtonBlue1.onClick.AddListener(OnButtonBlue1Clicked);
        ButtonBlue2.onClick.AddListener(OnButtonBlue2Clicked);
        ButtonBlue3.onClick.AddListener(OnButtonBlue3Clicked);
        ButtonBlue4.onClick.AddListener(OnButtonBlue4Clicked);
        ButtonBlue5.onClick.AddListener(OnButtonBlue5Clicked);
        ButtonBlue6.onClick.AddListener(OnButtonBlue6Clicked);
        ButtonBlue7.onClick.AddListener(OnButtonBlue7Clicked);
        ButtonBlue8.onClick.AddListener(OnButtonBlue8Clicked);
        ButtonBlue9.onClick.AddListener(OnButtonBlue9Clicked);

        PanelPlayer = GameBones.PanelStartRandom;
    }

    private void Update()
    {
        MasivRandomBones = GameBones.MasivRandomBonesPlayer;
    }

    private IEnumerator ResetBones()
    {
        ResetRandomBones = 1;
        yield return new WaitForSeconds(1);
        ResetRandomBones = 0;
    }


    void OnButtonRed1Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
            
            Instantiate(BonesRed[MasivRandomBones], vector1RY, transform.rotation);
        }
    }

    void OnButtonRed2Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }

    }

    void OnButtonRed3Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }

    }

    void OnButtonRed4Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonRed5Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonRed6Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonRed7Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonRed8Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonRed9Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            Debug.Log(PanelPlayer);
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
        }
    }
    /// <summary>
    /// Red
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// Blue
    /// </summary>

    void OnButtonBlue1Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue2Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }
    void OnButtonBlue3Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue4Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue5Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue6Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue7Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue8Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }

    void OnButtonBlue9Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
        }
    }
}