using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameBones : MonoBehaviour
{
    public static GameObject MasivBonesDiceRandom;
    public GameObject Button;
    public GameObject[] PanelStart;
    public GameObject[] GameRedLine;
    public GameObject[] GameBlueLine;

    public static GameObject Dice0;
    public static GameObject Dice1;
    public static GameObject Dice2;
    public static GameObject Dice3;
    public static GameObject Dice4;
    public GameObject Dice5;

    GameObject[,] masivPanelRed = new GameObject[3, 3];
    GameObject[,] masivPanelBlue = new GameObject[3, 3];

    public static int PanelStartRandom;
    public int setoffActiveX;
    public int setoffAcliveY;
    public static int RandomMasivX;
    public static int RandomMasivY;


    GameObject[,] masivBones = new GameObject[3, 3]
    {
      {Dice0, Dice3, Dice0},
      {Dice1, Dice4, Dice1},
      {Dice2, Dice5, Dice2}
    };

    private void Start()
    {
        setoffActiveX = 0;
        setoffAcliveY = 0;

        StartCoroutine(CoroutineSample());

        masivBones[2,1].SetActive(true);
    }
    private void Update()
    {
        
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
            RandomMasivX = Random.Range(0, 3);
            RandomMasivY = Random.Range(0, 3);

            Debug.Log(RandomMasivX + "-RandomMasivX");
            Debug.Log(RandomMasivY + "-RandomMasivY");

            //masivBones[setoffActiveX, setoffAcliveY].SetActive(false);
            masivBones[RandomMasivX, RandomMasivY].SetActive(true);

            masivPanelRed[RandomMasivX, RandomMasivY] = masivBones[RandomMasivX, RandomMasivY];
            masivPanelBlue[RandomMasivX, RandomMasivY] = masivBones[RandomMasivX, RandomMasivY];

            setoffActiveX = RandomMasivX;
            setoffAcliveY = RandomMasivY;



            Debug.Log(masivBones + "-masivBONES");
            Debug.Log(masivPanelRed + "-masivPanelRed");
            Debug.Log(masivPanelBlue + "-masivPanelBlue");
    }
}
