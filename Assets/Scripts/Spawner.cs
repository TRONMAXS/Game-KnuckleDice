using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BonesRB;
    private GameObject ObjectBonesRB;

    public float timeStart;
    public int timeMax;
    public int randMinStart;
    public int randMax;
    public static bool Dell = true;

    public int MoveSpeedL;
    public int MoveSpeedR;
    private Vector2 _movementDirectionR = Vector2.right;
    private Vector2 _movementDirectionL = Vector2.left;

    public static int direction;

    Vector2 vectorY;

    private void Start()
    {
        direction = Random.Range(0, 2);
    }

    private void Update()
    {
        if (Dell)
        {
            int rand = Random.Range(randMinStart, randMax);
            float randY = Random.Range(120, 1000);

            if (direction == 0) // Левое направление
            {
                MoveSpeedL = Random.Range(1000, 1500);
                vectorY = new Vector2(2000, randY);
                ObjectBonesRB = Instantiate(BonesRB, vectorY, Quaternion.identity);
                ObjectBonesRB.name = "ObjectBonesRB";
                Dell = false;
            }
            else if (direction == 1) // Правое направление
            {
                MoveSpeedR = Random.Range(1000, 1500);
                vectorY = new Vector2(-2000, randY);
                ObjectBonesRB = Instantiate(BonesRB, vectorY, Quaternion.identity);
                ObjectBonesRB.name = "ObjectBonesRB";
                Dell = false;
            }
        }

        if (ObjectBonesRB != null)
        {
            if (direction == 0) // Движение влево
            {
                ObjectBonesRB.transform.Translate(_movementDirectionL * MoveSpeedL * Time.deltaTime);
            }
            else if (direction == 1) // Движение вправо
            {
                ObjectBonesRB.transform.Translate(_movementDirectionR * MoveSpeedR * Time.deltaTime);
            }
        }

        if (GameObject.Find("ObjectBonesRB") != true)
        {
            direction = Random.Range(0, 2);
            Dell = true;
        }
    }
}
