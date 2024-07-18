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

    public Quaternion[] quaternionBones = new Quaternion[6];

    public Vector2[] vector2BonesRed;
    public Vector2[] vector2BonesBlue;

    public GameObject[,] InstantiateBonesRED;
    public GameObject[,] InstantiateBonesBLUE;

    /*    public float[,] positionBonesRed = { { -179, 838, 0 }, { 3, 4, 5 }, { 3, 4, 5 },
                                             { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                             { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 }};

        public int[,] positionBonesBlue = { { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                            { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 },
                                            { 0, 1, 2 }, { 3, 4, 5 }, { 3, 4, 5 }};*/


    public int MasivRandomBones;
    public int PanelPlayer;

    public static int ResetRandomBones = 0;

    private void Start()
    {
        ButtonRed1.onClick.AddListener(OnButtonRed0Clicked);
        ButtonRed2.onClick.AddListener(OnButtonRed1Clicked);
        ButtonRed3.onClick.AddListener(OnButtonRed2Clicked);
        ButtonRed4.onClick.AddListener(OnButtonRed3Clicked);
        ButtonRed5.onClick.AddListener(OnButtonRed4Clicked);
        ButtonRed6.onClick.AddListener(OnButtonRed5Clicked);
        ButtonRed7.onClick.AddListener(OnButtonRed6Clicked);
        ButtonRed8.onClick.AddListener(OnButtonRed7Clicked);
        ButtonRed9.onClick.AddListener(OnButtonRed8Clicked);

        ButtonBlue1.onClick.AddListener(OnButtonBlue0Clicked);
        ButtonBlue2.onClick.AddListener(OnButtonBlue1Clicked);
        ButtonBlue3.onClick.AddListener(OnButtonBlue2Clicked);
        ButtonBlue4.onClick.AddListener(OnButtonBlue3Clicked);
        ButtonBlue5.onClick.AddListener(OnButtonBlue4Clicked);
        ButtonBlue6.onClick.AddListener(OnButtonBlue5Clicked);
        ButtonBlue7.onClick.AddListener(OnButtonBlue6Clicked);
        ButtonBlue8.onClick.AddListener(OnButtonBlue7Clicked);
        ButtonBlue9.onClick.AddListener(OnButtonBlue8Clicked);

        PanelPlayer = GameBones.PanelStartRandom;

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

        Debug.Log(vector2BonesRed[1]);
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


    void OnButtonRed0Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            PanelPlayer = 1;
            StartCoroutine(ResetBones());
            Debug.Log(BonesRed[MasivRandomBones]);
            Debug.Log(new Vector2(-179, 830));
            Debug.Log(quaternionBones[MasivRandomBones]);

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[0], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed1Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[1], quaternionBones[MasivRandomBones]);
        }

    }

    void OnButtonRed2Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {
            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[2], quaternionBones[MasivRandomBones]);
        }

    }

    void OnButtonRed3Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[3], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed4Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[4], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed5Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[5], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed6Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[6], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed7Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[7], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonRed8Clicked()
    {
        if (PanelPlayer == 0 & MasivRandomBones >= 0)
        {

            PanelPlayer = 1;
            StartCoroutine(ResetBones());

            GameObject bonesRed = Instantiate(BonesRed[MasivRandomBones]) as GameObject;
            bonesRed.GetComponent<Transform>().SetPositionAndRotation(vector2BonesRed[8], quaternionBones[MasivRandomBones]);
        }
    }
    /// <summary>
    /// Red
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// Blue
    /// </summary>

    void OnButtonBlue0Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[0], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue1Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[1], quaternionBones[MasivRandomBones]);
        }
    }
    void OnButtonBlue2Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[2], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue3Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[3], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue4Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());
            
            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[4], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue5Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[5], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue6Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[6], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue7Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[7], quaternionBones[MasivRandomBones]);
        }
    }

    void OnButtonBlue8Clicked()
    {
        if (PanelPlayer == 1 & MasivRandomBones >= 0)
        {
            Debug.Log("второй игрок");
            PanelPlayer = 0;
            StartCoroutine(ResetBones());

            GameObject bonesBlue = Instantiate(BonesBlue[MasivRandomBones]) as GameObject;
            bonesBlue.GetComponent<Transform>().SetPositionAndRotation(vector2BonesBlue[8], quaternionBones[MasivRandomBones]);
        }
    }
}