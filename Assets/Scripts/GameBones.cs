using System.Collections;
using UnityEngine;


public class GameBones : MonoBehaviour
{
    public static int MasivRandomBonesPlayer = -1;
    int MasivRandomBonesPlayerOFF;
    public GameObject Button;

    private int Reset = 0;
    private bool randomON = true;

    public static int PanelStartRandom;

    public GameObject[] PanelStart;
    public GameObject[] RandomBonesPlayer;


    private void Start()
    {
        StartCoroutine(PanelRandom());
        //Time.timeScale = 1f;
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
        randomON = true;
        PanelStart[0].SetActive(false);
        PanelStart[1].SetActive(false);
    }

    private void RandomButtonBones()
    {
        if (randomON == true)
        {
            RandomBonesPlayer[MasivRandomBonesPlayerOFF].SetActive(false);

            MasivRandomBonesPlayer = Random.Range(0, 6);

            MasivRandomBonesPlayerOFF = MasivRandomBonesPlayer;

            RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(true);
            randomON = false;
            Debug.Log(MasivRandomBonesPlayer + "-MasivRandomBonesPlayer");
            Button.SetActive(false);
        }
    }

    private IEnumerator ResetBones()
    {
        RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(false);
        yield return new WaitForSeconds(1);
        //yield return new WaitUntil(() => );
        MasivRandomBonesPlayer = -1;
        randomON = true;
        Button.SetActive(true);
    }
}
