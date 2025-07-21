using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] BonesRB;
    private GameObject ObjectBonesRB;

    private List<GameObject> spawnedObjects = new List<GameObject>();

    private readonly int randTimeMin = 0;
    private readonly int randTimeMax = 10;
    [SerializeField]
    private int randTime;

    [SerializeField]
    private int MoveSpeedL;
    [SerializeField]
    private int MoveSpeedR;
    private readonly Vector2 _movementDirectionR = Vector2.right;
    private readonly Vector2 _movementDirectionL = Vector2.left;

    private static int direction;

    private readonly Vector2[] RightVectorY = new Vector2[10];
    private readonly Vector2[] LeftVectorY = new Vector2[10];



    private void Start()
    {
        direction = Random.Range(0, 2);
        // Инициализация RightVectorY
        RightVectorY[0] = new Vector2(2000, 100);
        RightVectorY[1] = new Vector2(2000, 220);
        RightVectorY[2] = new Vector2(2000, 340);
        RightVectorY[3] = new Vector2(2000, 460);
        RightVectorY[4] = new Vector2(2000, 580);
        RightVectorY[5] = new Vector2(2000, 700);
        RightVectorY[6] = new Vector2(2000, 820);
        RightVectorY[7] = new Vector2(2000, 940);
        RightVectorY[8] = new Vector2(2000, 1060);
        RightVectorY[9] = new Vector2(2000, 1180);
        // Инициализация LeftVectorY
        LeftVectorY[0] = new Vector2(-2000, 100);
        LeftVectorY[1] = new Vector2(-2000, 220);
        LeftVectorY[2] = new Vector2(-2000, 340);
        LeftVectorY[3] = new Vector2(-2000, 460);
        LeftVectorY[4] = new Vector2(-2000, 580);
        LeftVectorY[5] = new Vector2(-2000, 700);
        LeftVectorY[6] = new Vector2(-2000, 820);
        LeftVectorY[7] = new Vector2(-2000, 940);
        LeftVectorY[8] = new Vector2(-2000, 1060);
        LeftVectorY[9] = new Vector2(-2000, 1180);

        StartCoroutine(SpawnObject());
    }

    private void Update()
    {
        foreach (var obj in spawnedObjects)
        {
            if (obj != null)
            {
                if (direction == 0)
                    obj.transform.Translate(MoveSpeedL * Time.deltaTime * _movementDirectionL);
                else if (direction == 1)
                    obj.transform.Translate(MoveSpeedR * Time.deltaTime * _movementDirectionR);
            }
        }
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            randTime = Random.Range(randTimeMin, randTimeMax);
            int randIndex = Random.Range(0, 6);
            int randY = Random.Range(0, 10);

            if (direction == 0)
            {
                MoveSpeedL = Random.Range(1000, 1500);
                ObjectBonesRB = Instantiate(BonesRB[randIndex], RightVectorY[randY], Quaternion.identity);
                ObjectBonesRB.name = $"L{randY}";
            }
            else if (direction == 1)
            {
                MoveSpeedR = Random.Range(1000, 1500);
                ObjectBonesRB = Instantiate(BonesRB[randIndex], LeftVectorY[randY], Quaternion.identity);
                ObjectBonesRB.name = $"R{randY}";
            }
            spawnedObjects.Add(ObjectBonesRB);
            yield return new WaitForSeconds(randTime);
        }
    }
}
