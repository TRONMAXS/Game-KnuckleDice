using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppInformation : MonoBehaviour
{
    public void OpenUrlGitHub()
    {
        string url = "https://github.com/TRONMAXS/Game-KnuckleDice";
        Application.OpenURL(url);
    }
}
