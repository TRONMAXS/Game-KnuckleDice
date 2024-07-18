using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManeger : MonoBehaviour
{


    public void SceneMR(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }

}
