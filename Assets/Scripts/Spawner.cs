using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BonesRB;
    private GameObject ObjectBonesRB;

    public float timeStart;
    public int timeMax;
    public int randMinStart;
    public int randMax;
    private float timeDell = 2f;

    public static int direction;

    Vector2 vectorY;

    private void Start()
    {
       randMax = timeMax;
       randMax -= 4;
       direction = Random.Range(0, 2);
    }

    private void Update()
    {
        int rand = Random.Range(randMinStart, randMax);
        timeStart += Time.deltaTime;

        if (direction == 0)
        {
            float randY = Random.Range(120, 1000);
            vectorY = new Vector2(2000, randY);

            if (timeStart >= timeMax)
            {
                ObjectBonesRB = Instantiate(BonesRB, vectorY, Quaternion.identity);
                timeStart = rand;
                Destroy(ObjectBonesRB, timeDell);
            }
        }

        if (direction == 1)
        {
            float randY = Random.Range(120, 1000);
            vectorY = new Vector2(-2000, randY);

            if (timeStart >= timeMax)
            {
                ObjectBonesRB = Instantiate(BonesRB, vectorY, Quaternion.identity);
                timeStart = rand;
                Destroy(ObjectBonesRB, timeDell);
            }
        }
    }
}
