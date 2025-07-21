using UnityEngine;
using System.Security.Cryptography;
using System;

public class BOTGameBones : MonoBehaviour
{
    public int PanelPlayer;
    public int MasivRandomDicesOFF;

    public static int MasivRandomBonesPlayer = -1;
    public static int PanelStartRandom;
    
    public bool randomON = true;
    public static bool StartBot = false;

    public GameObject Button;
    public GameObject BOTGamePanelButtonRed;

    [SerializeField]
    private Animator anim;
    [SerializeField]
    private GameObject PanelRandomBones;

    public GameObject[] PanelStart;
    public GameObject[] RandomDices;

    private BOTGamePanelButtonRed _actionBotPlay;

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
        StartRandomPanel();
    }

    private void Update()
    {
        if (MasivRandomBonesPlayer == -1)
        {
            PanelRandomBones.SetActive(true);
        }
        else
        {
            PanelRandomBones.SetActive(false);
        }
    }

    private void StartRandomPanel()
    {
        PanelStartRandom = GenerateRandomDigitPanel();
        PanelPlayer = PanelStartRandom;
        PanelStart[PanelStartRandom].SetActive(true);
        randomON = true;
        if (PanelPlayer == 0)
        {
            StartBot = true;
            RandomButtonBones(0);
        }
    }

    private void ButtonPlayer()
    {
        RandomButtonBones(1);
    }

    public void RandomButtonBones(int PanelPlayer)
    {
        if (randomON == true)
        {
            MasivRandomBonesPlayer = GenerateRandomDigitBones();
            MasivRandomDicesOFF = MasivRandomBonesPlayer;

            if (PanelPlayer == 0)
            {
                RandomDices[MasivRandomBonesPlayer].SetActive(true);
                _actionBotPlay.CheckArraysInvoke(MasivRandomBonesPlayer);
                PanelPlayer = 1;
            }
            if (PanelPlayer == 1)
            {
                RandomDices[MasivRandomBonesPlayer].SetActive(true);
                PanelPlayer = 0;
            }
            randomON = false;
            Button.SetActive(false);
            PanelStart[0].SetActive(false);
            PanelStart[1].SetActive(false);
        }
    }

    public void ResetBones()
    {
        RandomDices[MasivRandomDicesOFF].SetActive(false);
        randomON = true;
        Button.SetActive(true);
        MasivRandomBonesPlayer = -1;
    }
}
