using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{

    public GameObject BonesRB;

    public float timeStart;
    public int timeMax;
    public int randMinStart;
    public int randMax;

    public static int direction;

    Vector2 vectorY;


    private void Start()
    {
       randMax = timeMax;
       randMax -= 4;

        direction = Random.Range(0, 2);
        Debug.Log("direction");
        Debug.Log(direction);
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

                Instantiate(BonesRB, vectorY, Quaternion.identity);

                timeStart = rand;

            }
        }

        if (direction == 1)
        {
            float randY = Random.Range(120, 1000);
            vectorY = new Vector2(-2000, randY);


            if (timeStart >= timeMax)
            {

                Instantiate(BonesRB, vectorY, Quaternion.identity);

                timeStart = rand;

            }
        }
    }
}
