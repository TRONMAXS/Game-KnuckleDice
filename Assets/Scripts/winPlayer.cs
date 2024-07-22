using UnityEngine;
using UnityEngine.UI;

public class winPlayer : MonoBehaviour
{
    public GameObject WinPanel;

    public Text TextWinnerRED, TextWinnerBLUE, ScoreRED, ScoreBLUE;

    public GameObject InstantiateMSRED;
    private GamePanelButtonRed _arrayR;
    public GameObject InstantiateMSBLUE;
    private GamePanelButtonRed _arrayB;

    public GameObject TextScoreRED1;
    private ScorePlayer _TextScoreR1;

    public GameObject TextScoreRED2;
    private ScorePlayer _TextScoreR2;

    public GameObject TextScoreRED3;
    private ScorePlayer _TextScoreR3;

    public GameObject TextScoreBLUE1;
    private ScorePlayer _TextScoreB1;

    public GameObject TextScoreBLUE2;
    private ScorePlayer _TextScoreB2;

    public GameObject TextScoreBLUE3;
    private ScorePlayer _TextScoreB3;

    public int ScoreWinerRed, ScoreWinerBlue;

    private void Start()
    {
        _arrayR = InstantiateMSRED.GetComponent<GamePanelButtonRed>();
        _arrayB = InstantiateMSBLUE.GetComponent<GamePanelButtonRed>();

        _TextScoreR1 = TextScoreRED1.GetComponent<ScorePlayer>();
        _TextScoreR2 = TextScoreRED2.GetComponent<ScorePlayer>();
        _TextScoreR3 = TextScoreRED3.GetComponent<ScorePlayer>();

        _TextScoreB1 = TextScoreBLUE1.GetComponent<ScorePlayer>();
        _TextScoreB2 = TextScoreBLUE2.GetComponent<ScorePlayer>();
        _TextScoreB3 = TextScoreBLUE3.GetComponent<ScorePlayer>();
    }

    public void CheckingWinning()
    {
        bool isFilledRED = true;
        bool isFilledBLUE = true;
        for (int i = 0; i < _arrayR.InstantiateBonesRED.GetLength(0) && isFilledRED; i++)
        {
            for (int j = 0; j < _arrayR.InstantiateBonesRED.GetLength(1) && isFilledRED; j++)
            {
                if (_arrayR.InstantiateBonesRED[i, j] == 0)
                {
                    isFilledRED = false;
                }
            }
        }
        for (int i = 0; i < _arrayR.InstantiateBonesBLUE.GetLength(0) && isFilledBLUE; i++)
        {
            for (int j = 0; j < _arrayR.InstantiateBonesBLUE.GetLength(1) && isFilledBLUE; j++)
            {
                if (_arrayR.InstantiateBonesBLUE[i, j] == 0)
                {
                    isFilledBLUE = false;
                }
            }
        }

        //Победа - Выиграл
        //Проигрыш - Проиграл
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
        }
    }
}        
