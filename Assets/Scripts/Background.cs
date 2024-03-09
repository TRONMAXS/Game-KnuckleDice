using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SelectionBase]

public class Background : MonoBehaviour
{
    public int SpawnerDirection;

    [SerializeField] private Vector2 _movementDirection;

    void Start()
    {
        //direction = Random.RandomRange(0, 2);
        SpawnerDirection = Spawner.direction;

        Debug.Log("SpawnerDirection;");
        Debug.Log(SpawnerDirection);


        if (SpawnerDirection == 0)
        {
            _movementDirection.x = -15;
        }
        if (SpawnerDirection == 1)
        {
            _movementDirection.x = 15;
        }
    }


    private void Update()
    {
        if (SpawnerDirection == 0 || _movementDirection.x <= -10)
        {
            transform.Translate(_movementDirection, Space.World);
        }

        if (SpawnerDirection == 1 || _movementDirection.x >= 10)
        {
            transform.Translate(_movementDirection, Space.World);
        }
    }
}
