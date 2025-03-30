using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FON")
        {
            GameObject ObjectBonesRB = GameObject.Find("ObjectBonesRB");
            Destroy(ObjectBonesRB);
            Spawner.Dell = true;
        }
    }
}
