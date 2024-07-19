using UnityEngine;
using UnityEngine.SceneManagement;


public class GameLeave : MonoBehaviour 
{

    public void Leave()
    {
        SceneManager.LoadScene(0);
    }


}
