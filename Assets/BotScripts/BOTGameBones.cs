using UnityEngine;
using System.Security.Cryptography;
using System;

public class BOTGameBones : MonoBehaviour
{
    public int PanelPlayer;
    public int MasivRandomBonesBOTOFFRed;
    public int MasivRandomBonesPlayerOFFBlue;

    public static int MasivRandomBonesPlayer = -1;
    public static int PanelStartRandom;
    
    public bool randomON = true;
    public static bool StartBot = false;

    public GameObject Button;
    public GameObject BOTGamePanelButtonRed;


    public GameObject[] PanelStart;
    public GameObject[] RandomBonesBOTRed;
    public GameObject[] RandomBonesPlayerBlue;

    private BOTGamePanelButtonRed _actionBotPlay;
    //private BOTGamePanelButtonRed _actionStartBotPlay;


    private int GenerateRandomDigitPanel()
    {
        byte[] randomBytes1 = new byte[1];
        using (var CSP1 = new RNGCryptoServiceProvider())
        {
            CSP1.GetBytes(randomBytes1);
        }
        return Convert.ToInt32(randomBytes1[0]) % 2;
    }

    private int GenerateRandomDigitBones()
    {
        byte[] randomBytes2 = new byte[1];
        using (var CSP2 = new RNGCryptoServiceProvider())
        {
            CSP2.GetBytes(randomBytes2);
        }
        return Convert.ToInt32(randomBytes2[0]) % 6;
    }

    private void Start()
    {
        _actionBotPlay = BOTGamePanelButtonRed.GetComponent<BOTGamePanelButtonRed>();
        //_actionStartBotPlay = BOTGamePanelButtonRed.GetComponent<BOTGamePanelButtonRed>();

        StartRandomPanel();
    }

    private void StartRandomPanel()
    {
        PanelStartRandom = GenerateRandomDigitPanel();
        PanelPlayer = PanelStartRandom;
        PanelStart[PanelStartRandom].SetActive(true);
        randomON = true;
        //Debug.Log(PanelPlayer + "---PanelPlayer");
        if (PanelPlayer == 0)
        {
            StartBot = true;
            RandomButtonBones(0, true);
        }
    }

    public void ButtonPlayer()
    {
        RandomButtonBones(1, false);
    }

    public void RandomButtonBones(int PanelPlayer, bool StartBot)
    {
        if (randomON == true)
        {
            MasivRandomBonesPlayer = GenerateRandomDigitBones();
            MasivRandomBonesBOTOFFRed = MasivRandomBonesPlayer;
            MasivRandomBonesPlayerOFFBlue = MasivRandomBonesPlayer;

            if (PanelPlayer == 0 & StartBot == false  /*| BOTGamePanelButtonRed.PanelPlayer == 0*/)
            {
                RandomBonesBOTRed[MasivRandomBonesPlayer].SetActive(true);
                _actionBotPlay.CheckArraysInvoke();
                randomON = false;
                Button.SetActive(false);
                PanelStart[0].SetActive(false);
                PanelStart[1].SetActive(false);
                return;
            }
            if (PanelPlayer == 0 & StartBot == true)
            {
                RandomBonesBOTRed[MasivRandomBonesPlayer].SetActive(true);
                _actionBotPlay.CheckArraysInvoke();
                randomON = false;
                Button.SetActive(false);
                PanelStart[0].SetActive(false);
                PanelStart[1].SetActive(false);
                return;
            }
            if (PanelPlayer == 1)
            {
                RandomBonesPlayerBlue[MasivRandomBonesPlayer].SetActive(true);
                randomON = false;
                Button.SetActive(false);
                PanelStart[0].SetActive(false);
                PanelStart[1].SetActive(false);
                return;
            }
        }
        //Debug.Log(MasivRandomBonesPlayer + "---MasivRandomBonesPlayer");      
    }

    public void ResetBones()
    {
        RandomBonesBOTRed[MasivRandomBonesBOTOFFRed].SetActive(false);
        RandomBonesPlayerBlue[MasivRandomBonesPlayerOFFBlue].SetActive(false);
        randomON = true;
        Button.SetActive(true);
        MasivRandomBonesPlayer = -1;
    }
}
