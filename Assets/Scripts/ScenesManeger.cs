using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManeger : MonoBehaviour
{


    public void SceneMR(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }

}
