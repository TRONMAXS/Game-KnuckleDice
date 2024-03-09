using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameBones : MonoBehaviour
{
    int MasivRandomBonesPlayer;
    int MasivRandomBonesPlayerOFF;
    public GameObject Button;

    public static int PanelStartRandom;

    public GameObject[] PanelStart;
    public GameObject[] RandomBonesPlayer;





    private void Start()
    {
        StartCoroutine(CoroutineSample());
    }


    private IEnumerator CoroutineSample()
    {
        PanelStartRandom = Random.Range(0, 2);

        PanelStart[PanelStartRandom].SetActive(true);

        yield return new WaitForSeconds(3);

        PanelStart[0].SetActive(false);
        PanelStart[1].SetActive(false);
  
    }



    public void RandomButtonBones()
    {
        RandomBonesPlayer[MasivRandomBonesPlayerOFF].SetActive(false);

        MasivRandomBonesPlayer = Random.Range(0, 6);

        MasivRandomBonesPlayerOFF = MasivRandomBonesPlayer;

        RandomBonesPlayer[MasivRandomBonesPlayer].SetActive(true);


        Debug.Log(MasivRandomBonesPlayer + "-MasivRandomBonesPlayer");

    }
}
