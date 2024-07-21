using System.Collections;
using UnityEngine;


public class GameBones : MonoBehaviour
{
    public static int MasivRandomBonesPlayer = -1;
    int MasivRandomBonesPlayerOFF;
    public GameObject Button;

    private bool randomON = true;

    public static int PanelStartRandom;

    public GameObject[] PanelStart;
    public GameObject[] RandomBonesPlayer;


    private void Start()
    {
        //StartCoroutine(PanelRandom());
        PanelRandom();
    }

/*    private void Update()
    {
        Reset = GamePanelButtonRed.ResetRandomBones;
        if (Reset == 1)
        {
            ResetBones();
        }
    }*/

/*    private IEnumerator PanelRandom()
    {
        PanelStartRandom = Random.Range(0, 2);

        PanelStart[PanelStartRandom].SetActive(true);

        yield return new WaitForSeconds(3);
        randomON = true;
        PanelStart[0].SetActive(false);
        PanelStart[1].SetActive(false);
    }*/

    private void PanelRandom()
    {
        PanelStartRandom = Random.Range(0, 2);
        PanelStart[PanelStartRandom].SetActive(true);
        randomON = true;
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
            Button.SetActive(false);
            PanelStart[0].SetActive(false);
            PanelStart[1].SetActive(false);
        }
    }

    public void ResetBones()
    {
        RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(false);
        randomON = true;
        Button.SetActive(true);
        MasivRandomBonesPlayer = -1;
    }
}
