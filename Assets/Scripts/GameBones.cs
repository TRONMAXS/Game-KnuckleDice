using System.Collections;
using UnityEngine;


public class GameBones : MonoBehaviour
{
    public static int MasivRandomBonesPlayer = -1;
    int MasivRandomBonesPlayerOFF;
    public GameObject Button;

    private int Reset = 0;
    private int randomON = 0;

    public static int PanelStartRandom;

    public GameObject[] PanelStart;
    public GameObject[] RandomBonesPlayer;


    private void Start()
    {
        StartCoroutine(PanelRandom());
    }

    private void Update()
    {
        Reset = GamePanelButtonRed.ResetRandomBones;
        if (Reset == 1)
        {
            StartCoroutine(ResetBones());
        }
    }

    private IEnumerator PanelRandom()
    {
        PanelStartRandom = Random.Range(0, 2);

        PanelStart[PanelStartRandom].SetActive(true);

        yield return new WaitForSeconds(3);
        randomON = 1;
        PanelStart[0].SetActive(false);
        PanelStart[1].SetActive(false);
    }

    private void RandomButtonBones()
    {
        if (randomON == 1)
        {
            RandomBonesPlayer[MasivRandomBonesPlayerOFF].SetActive(false);

            MasivRandomBonesPlayer = Random.Range(0, 6);

            MasivRandomBonesPlayerOFF = MasivRandomBonesPlayer;

            RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(true);

            Debug.Log(MasivRandomBonesPlayer + "-MasivRandomBonesPlayer");
            randomON = 0;
            Button.SetActive(false);
        }
    }

    private IEnumerator ResetBones()
    {
        RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(false);
        yield return new WaitForSeconds(1); 
        MasivRandomBonesPlayer = -1;
        randomON = 1;
        Button.SetActive(true);
    }
}
