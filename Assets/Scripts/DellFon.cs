using UnityEngine;

public class DellFon : MonoBehaviour
{
    public float timeDell;

    void Start()
    {
        Destroy(gameObject, timeDell);
    }
}
