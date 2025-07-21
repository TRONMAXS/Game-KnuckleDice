using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BOTwinPlayer : MonoBehaviour
{
    public GameObject WinPanel;

    public TMP_Text TextWinnerRED, TextWinnerBLUE, ScoreRED, ScoreBLUE;

    public GameObject InstantiateMSRED;
    private BOTGamePanelButtonRed _arrayR;
    public GameObject InstantiateMSBLUE;
    private BOTGamePanelButtonRed _arrayB;

    public GameObject TextScoreRED1;
    private BOTScorePlayer _TextScoreR1;

    public GameObject TextScoreRED2;
    private BOTScorePlayer _TextScoreR2;

    public GameObject TextScoreRED3;
    private BOTScorePlayer _TextScoreR3;

    public GameObject TextScoreBLUE1;
    private BOTScorePlayer _TextScoreB1;

    public GameObject TextScoreBLUE2;
    private BOTScorePlayer _TextScoreB2;

    public GameObject TextScoreBLUE3;
    private BOTScorePlayer _TextScoreB3;

    public int ScoreWinerRed, ScoreWinerBlue;

    private void Start()
    {
        _arrayR = InstantiateMSRED.GetComponent<BOTGamePanelButtonRed>();
        _arrayB = InstantiateMSBLUE.GetComponent<BOTGamePanelButtonRed>();

        _TextScoreR1 = TextScoreRED1.GetComponent<BOTScorePlayer>();
        _TextScoreR2 = TextScoreRED2.GetComponent<BOTScorePlayer>();
        _TextScoreR3 = TextScoreRED3.GetComponent<BOTScorePlayer>();

        _TextScoreB1 = TextScoreBLUE1.GetComponent<BOTScorePlayer>();
        _TextScoreB2 = TextScoreBLUE2.GetComponent<BOTScorePlayer>();
        _TextScoreB3 = TextScoreBLUE3.GetComponent<BOTScorePlayer>();
    }

    public void CheckingWinning()
    {
        bool isFilledRED = true;
        bool isFilledBLUE = true;

        for (int i = 0; i < _arrayR.InstantiateBonesRED.GetLength(0) && isFilledRED; i++)
        {
            for (int j = 0; j < _arrayR.InstantiateBonesRED.GetLength(1) && isFilledRED; j++)
            {
                if (_arrayR.InstantiateBonesRED[i, j] == 10)
                {
                    isFilledRED = false;
                }
            }
        }
        for (int i = 0; i < _arrayR.InstantiateBonesBLUE.GetLength(0) && isFilledBLUE; i++)
        {
            for (int j = 0; j < _arrayR.InstantiateBonesBLUE.GetLength(1) && isFilledBLUE; j++)
            {
                if (_arrayB.InstantiateBonesBLUE[i, j] == 10)
                {
                    isFilledBLUE = false;
                }
            }
        }

        if (isFilledRED == true)
        {
            ScoreWinerRed = _TextScoreR1.REDtext1 + _TextScoreR2.REDtext2 + _TextScoreR3.REDtext3;
            ScoreWinerBlue = _TextScoreB1.BLUEtext1 + _TextScoreB1.BLUEtext2 + _TextScoreB1.BLUEtext3;
            WinPanel.SetActive(true);
            if (ScoreWinerRed > ScoreWinerBlue)
            {
                TextWinnerRED.text = "Победа";
                TextWinnerBLUE.text = "Проигрыш";
            }
            else
            {
                TextWinnerRED.text = "Проигрыш";
                TextWinnerBLUE.text = "Победа";
            }
            ScoreRED.text = ScoreWinerRed.ToString();
            ScoreBLUE.text = ScoreWinerBlue.ToString();
            Time.timeScale = 0f;
        }
        else if (isFilledBLUE == true)
        {
            ScoreWinerRed = _TextScoreR1.REDtext1 + _TextScoreR2.REDtext2 + _TextScoreR3.REDtext3;
            ScoreWinerBlue = _TextScoreB1.BLUEtext1 + _TextScoreB1.BLUEtext2 + _TextScoreB1.BLUEtext3;
            WinPanel.SetActive(true);
            if (ScoreWinerBlue > ScoreWinerRed)
            {
                TextWinnerBLUE.text = "Победа";
                TextWinnerRED.text = "Проигрыш";
            }
            else
            {
                TextWinnerBLUE.text = "Проигрыш";
                TextWinnerRED.text = "Победа";
            }
            ScoreBLUE.text = ScoreWinerBlue.ToString();
            ScoreRED.text = ScoreWinerRed.ToString();
            Time.timeScale = 0f;
        }
    }
}
