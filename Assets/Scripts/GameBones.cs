using UnityEngine;
using System.Security.Cryptography;
using System;


public class GameBones : MonoBehaviour
{
    public static int MasivRandomBonesPlayer = -1;
    private int PanelPlayer;
    private int MasivRandomBonesPlayerOFFRed;
    private int MasivRandomBonesPlayerOFFBlue;

    public GameObject Button;

    private bool randomON = true;

    public static int PanelStartRandom;

    public GameObject[] PanelStart;
    public GameObject[] RandomBonesPlayer;

    public GameObject[] RandomBonesPlayerRed;
    public GameObject[] RandomBonesPlayerBlue;


    private void Start()
    {
        PanelRandom();
    }

    private void PanelRandom()
    {
        PanelStartRandom = GenerateRandomDigitPanel();
        PanelPlayer = PanelStartRandom;
        PanelStart[PanelStartRandom].SetActive(true);
        randomON = true;
    }

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

    private void RandomButtonBones()
    {

        if (randomON == true)
        {
            MasivRandomBonesPlayer = GenerateRandomDigitBones();

            if (PanelPlayer == 0)
            {
                MasivRandomBonesPlayerOFFRed = MasivRandomBonesPlayer;
                RandomBonesPlayerRed[MasivRandomBonesPlayer].SetActive(true);
                PanelPlayer = 1;
            }
            else if (PanelPlayer == 1)
            {
                MasivRandomBonesPlayerOFFBlue = MasivRandomBonesPlayer;
                RandomBonesPlayerBlue[MasivRandomBonesPlayer].SetActive(true);
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
        RandomBonesPlayerRed[MasivRandomBonesPlayerOFFRed].SetActive(false);
        RandomBonesPlayerBlue[MasivRandomBonesPlayerOFFBlue].SetActive(false);
        randomON = true;
        Button.SetActive(true);
        MasivRandomBonesPlayer = -1;
    }
}